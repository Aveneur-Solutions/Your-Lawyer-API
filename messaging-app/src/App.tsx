import { observer } from 'mobx-react-lite'
import React, { useContext, useEffect, useState } from 'react'
import './App.css'
import LawyerStore from './stores/lawyerStore'

const App = () => {
  const [body, setBody] = useState("")

  const lawyerStore = useContext(LawyerStore)
  const {user, getCurrentUser, createHubConnection, stopHubConnection, sendQueryText} = lawyerStore

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
      {user && user.sentQueryTexts.map((message: any) => {
        return <div key={message.id}>{message.text}</div>
      })}
    </div>
  )
}

export default observer(App)
