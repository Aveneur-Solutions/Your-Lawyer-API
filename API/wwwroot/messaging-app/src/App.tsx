import { observer } from 'mobx-react-lite'
import React, { useContext, useEffect, useState } from 'react'
import './App.css'
import LawyerStore from './stores/lawyerStore'

const App = () => {
  const [body, setBody] = useState("")
  const [selectedFile, setSelectedFile] = useState<Blob | null>();

  const lawyerStore = useContext(LawyerStore)
  const {user, getCurrentUser, createHubConnection, stopHubConnection, sendQueryText, sendQueryFile, messagesByDate} = lawyerStore

  useEffect(() => {
    getCurrentUser().then(() => {
      createHubConnection()
    })
    return () => {
      stopHubConnection()
    }
  }, [getCurrentUser, createHubConnection, stopHubConnection])

  return (
    <div className="App">
      <form onSubmit={(e) => {
        e.preventDefault()
        sendQueryText(body)
      }}>
        <input type="text" name="body" onChange={(e) => setBody(e.target.value)} value={body}/><br />
        <input type="submit" value="Pathiye dau tomar msg. ami abar tomar msg dekhte chai"/>
      </form>
      <form onSubmit={(e) => {
        e.preventDefault()
        sendQueryFile(selectedFile!)
      }}>
        <input type="file" name="body" onChange={(e) => setSelectedFile(e.target.files![0])}/><br />
        <input type="submit" value="Pathiye dau tomar file. ami abar tomar file dekhte chai"/>
      </form>
      {user && messagesByDate.map((message: any) => {
        return <div key={message.id}>{message.text || message.filePath}</div>
      })}
    </div>
  )
}

export default observer(App)
