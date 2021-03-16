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

  @observable lawyers: any[] = [];
  @observable user: any = null;
  @observable sentQueryTexts: any[] = [];
  @observable receivedQueryTexts: any[] = [];
  @observable.ref hubConnection: HubConnection | null = null;

  @computed get messagesByDate() {
    let messages = [];
    if (this.user) {
      let sent = this.user.sentQueryTexts.slice();
      let received = this.user.receivedQueryTexts.slice();
      messages = sent.concat(received);
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
  };

  @action stopHubConnection = () => {
    this.hubConnection?.stop();
  };

  // @action sendQueryText = async (values: any) => {
  //   let id = this.user.userName + "abcdef";
  //   try {
  //     await this.hubConnection?.invoke("SendQueryTextToLegalx", values);
  //   } catch (error) {
  //     console.log(error);
  //   }
  // };
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

  @action listLawyers = async () => {
    try {
      const amarLawyers = await agent.Lawyer.list();
      runInAction(() => {
        this.lawyers = amarLawyers;
      });
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
      });
    } catch (error) {
      console.log(error);
    }
  };
}

export default createContext(new LawyerStore());
