import {
  action,
  computed,
  makeObservable,
  observable,
  runInAction,
} from "mobx";
import { createContext } from "react";
import agent from "../agent";
import {
  HubConnection,
  HubConnectionBuilder,
  LogLevel,
} from "@microsoft/signalr";

class LawyerStore {
  constructor() {
    makeObservable(this);
  }

  @observable user: any = null;
  @observable sentQueryTexts: any[] = [];
  @observable receivedQueryTexts: any[] = [];
  @observable sentQueryFiles: any[] = [];
  @observable receivedQueryFiles: any[] = [];
  @observable.ref hubConnection: HubConnection | null = null;

  @computed get messagesByDate() {
    let messages = [];
    if (this.user) {
      let texts = [];
      let files = [];
      let sentTexts = this.user.sentQueryTexts.slice();
      let receivedTexts = this.user.receivedQueryTexts.slice();
      texts = sentTexts.concat(receivedTexts);
      let sentFiles = this.user.sentQueryFiles.slice();
      let receivedFiles = this.user.receivedQueryFiles.slice();
      files = sentFiles.concat(receivedFiles);
      messages = texts.concat(files);
    }
    messages = messages.sort(
      (a: any, b: any) => Date.parse(a.time) - Date.parse(b.time)
    );
    return messages;
  }

  @action createHubConnection = () => {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl("http://localhost:5000/query", {
        accessTokenFactory: () => localStorage.getItem("jwt")!,
      })
      .configureLogging(LogLevel.Information)
      .build();

    this.hubConnection
      .start()
      .then(() => console.log(this.hubConnection!.state))
      .then(() => {
        if (this.hubConnection?.state === "Connected") {
          if (this.user) {
            let id;
            if (this.user.userName === "legalx") {
              id = "VeryBadBitchabcdef";
              this.hubConnection.invoke("ConnectToUser", id);
            } else {
              id = this.user.userName + "abcdef";
              this.hubConnection.invoke("ConnectToLegalx", id);
            }
          }
        }
      })
      .catch((error) => console.log("Error establishing connection: ", error));

    this.hubConnection.on("ReceiveQueryTexts", (message) => {
      this.user!.sentQueryTexts.push(message);
    });

    this.hubConnection.on("ReceiveQueryFiles", (file) => {
      this.user!.sentQueryFiles.push(file);
    });
  };

  @action stopHubConnection = () => {
    this.hubConnection?.stop();
  };

  @action sendQueryText = async (values: any) => {
    try {
      if (this.user.userName === "legalx") {
        await this.hubConnection?.invoke(
          "SendQueryTextToUser",
          values,
          "VeryBadBitch"
        );
      } else {
        await this.hubConnection?.invoke("SendQueryTextToLegalx", values);
      }
    } catch (error) {
      console.log(error);
    }
  };

  @action sendQueryFile = async (file: Blob) => {
    try {
      const formData = new FormData();
      formData.append("File", file);
      if (this.user.userName === "legalx") {
        const message = await agent.Message.fileUploadToUser("VeryBadBitch", file);
        await this.hubConnection?.invoke("SendQueryFileToUser", message, "VeryBadBitch")
      } else {
        const message = await agent.Message.fileUpload(file);
        await this.hubConnection?.invoke("SendQueryFileToLegalx", message);
      }
    } catch (error) {
      console.log(error);
    }
  };

  @action getCurrentUser = async () => {
    try {
      const user = await agent.User.getUser();
      runInAction(() => {
        this.user = user;
        this.sentQueryTexts = user.sentQueryTexts;
        this.receivedQueryTexts = user.receivedQueryTexts;
        this.sentQueryFiles = user.sentQueryFiles;
        this.receivedQueryFiles = user.receivedQueryFiles;
      });
    } catch (error) {
      console.log(error);
    }
  };
}

export default createContext(new LawyerStore());
