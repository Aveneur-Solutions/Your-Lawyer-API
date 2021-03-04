import { HubConnectionBuilder, LogLevel } from "@microsoft/signalr";

let messages = [];

let connection = null;

export const createConnection = () => {
  connection = new HubConnectionBuilder()
    .withUrl("http://localhost:5000/query", {
        accessTokenFactory: () => localStorage.getItem('jwt')
    })
    .configureLogging(LogLevel.Information)
    .build();

  connection
    .start()
    .then(() => console.log(connection.state))
    .catch((error) => console.log("Error establishing connection: ", error));

  connection.on("ReceiveMessage", (message) => {
    messages.push(message);
  });
};

export const stopConnection = () => {
    connection.stopConnection()
}

const sendMessage = async (body) => {
  try {
    await connection.invoke("SendQueryText", body);
  } catch (error) {
    console.log(error);
  }
};

// const messageList = async () => {
//     try{

//     }catch(error)  {
//         console.log(error)
//     }
// }

export { messages, sendMessage };
