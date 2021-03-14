import { action, makeObservable, observable, runInAction } from "mobx";
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
  @observable.ref hubConnection: HubConnection | null = null;

  @action createHubConnection = () => {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl("http://localhost:5000/query", {
          accessTokenFactory: () => localStorage.getItem('jwt')!
      })
      .configureLogging(LogLevel.Information)
      .build();

    this.hubConnection
      .start()
      .then(() => console.log(this.hubConnection!.state))
      .catch((error) => console.log("Error establishing connection: ", error));

    this.hubConnection.on("ReceiveQueryTexts", message => {
        this.user!.sentQueryTexts.push(message)
    })
  };

  @action stopHubConnection = () => {
      this.hubConnection?.stop()
  }

  @action sendQueryText = async (values: any) => {
    try {
        await this.hubConnection?.invoke("SendQueryTextToLegalx", values)
    } catch (error) {
        console.log(error)
    }
  }

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
      });
    } catch (error) {
      console.log(error);
    }
  };
}

export default createContext(new LawyerStore());
