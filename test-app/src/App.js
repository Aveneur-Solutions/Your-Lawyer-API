import { useState, useEffect } from "react";
import "./App.css";
import agent from "./agent";
import { messages, sendMessage, createConnection, stopConnection } from "./message";

function App() {
  const [messages, setMessages] = useState([]);
  const [message, setMessage] = useState("");

  const onChangeHandler = (e) => {
    setMessage(e.target.value)
    console.log(message)
  }

  useEffect(() => {
    createConnection()
    return () => {
      stopConnection()
    }
  }, [createConnection, stopConnection]);

  return (
    <div className="App">
      <form onSubmit={(e) => {
        e.preventDefault()
        sendMessage(message)
      }}>
        <input type="text" name="message" onChange={onChangeHandler} value={message} />
        <button type="submit">Message pathau</button>
      </form>

      {messages.map((message) => (
        <p>{message.body}</p>
      ))}
    </div>
  );
}

export default App;
