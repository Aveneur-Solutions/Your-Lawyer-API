# Your-Lawyer-API
Restful Api of Your Lawyer Application
Clean Architecture was followed to develop the Restful APIs. The design pattern that was followed is CQRS and Meidatr Pattern.
There are five different projects in One solution folder. Every project is responsible for creating the api but all of them play different roles in the application. 

API project is the web api project where all the controllers exist but no business logic is implemented . API project is only responsible for recieving http requests and sending result back to the user .

Application project is where all the business logics of the application are implemented. API recieves the http request then passes request to application project . The application project takes help from persistence and domain project performs the task and returns the logic to API project and API then returns it to the user. 



