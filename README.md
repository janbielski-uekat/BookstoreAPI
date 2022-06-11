# BookstoreAPI
A minimal API for managing a small bookstore
## Project goal
The goal of this project was to create a simple web service that would allow managing an SQL database of sale records and products. <br>
The designed API could then act as a "middle man" between a database and a separete UI Aplication such as Blazor WebAssembly or WPF. <br>

## Current stage
At the current stage it is a Minimum Viable Product. Apart form basic CRUD operations it implements functionalities such as:
 <ol>
  <li>searching "Product" table by id, title or author,</li>
  <li>automatic inventory decrementation (when a "sale" record is posted quantity in stock of the bought product is automatically decremented by the quantity purchased),</li>
  <li>automatic completion of fields such as SaleDate, PurchasePrice and Total based on data in "Product" table (the only information needed to post a sale is ProductId and Quantity)</li>
</ol>

## Solution architecture
The solution consists of three separate projects (MS SQL Database Project, Class Library and ASP.NET Minimal API Project).
The Database project includes creation of tables and implementation of stored procedures allowing interaction with the database.
Class Library includes all the code that is not specific for a certian project type (data models and data access). NuGet Package "Dapper" is used as an ORM.
The main project (ASP.NET Minimal Api) contains endpoints definiotions and methods ensuring proper data flow and exception handling.

## Future development
In the future I plan to add user authentication and authorization based on Azure Active Directory and add new funcionalities such as tax handling.
In the next stage I plan to develop a Blazor WebAssembly Application that would serve as a User Interface for cashiers and buisness owner.
