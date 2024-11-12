# ABCRetailApp

ABCRetailApp is an e-commerce web application built using ASP.NET Core. The application is designed to manage customer orders, product catalogs, and integrate with a relational database to handle product information and orders efficiently. It provides features for adding, viewing, and managing customers and products.

## Features

- **Customer Management:** Add, update, and view customer information.
- **Product Catalog:** Add, update, and view products.
- **Order Management:** Place, view, and manage orders.
- **Database Integration:** Uses Entity Framework Core to interact with a SQL Server database.

## Technologies Used

- **ASP.NET Core**: For building the web application.
- **Entity Framework Core**: For interacting with the database.
- **SQL Server**: For storing customer, product, and order data.
- **HTML/CSS/JavaScript**: For front-end development.

## Prerequisites

To run this application locally, you will need the following tools:

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download/dotnet)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any compatible relational database
- Visual Studio or any compatible IDE

## Getting Started

Follow these steps to get the application up and running on your local machine:

1. **Clone the repository**
   ```bash
   git clone 
Navigate to the project folder

bash
Copy code
cd ABCRetailApp
Install dependencies Run the following command to restore NuGet packages:

bash
Copy code
dotnet restore
Configure the database connection

In appsettings.json, update the connection string with your local or cloud SQL Server instance.
Example:
json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ABCRetailDb;Trusted_Connection=True;"
}
Apply database migrations

bash
Copy code
dotnet ef database update
Run the application

bash
Copy code
dotnet run
Access the application Open your browser and go to http://localhost:5000 to view the application.

API Endpoints
Customers
GET /api/customers: Get all customers
POST /api/customers: Create a new customer
GET /api/customers/{id}: Get customer by ID
PUT /api/customers/{id}: Update customer details
DELETE /api/customers/{id}: Delete a customer
Products
GET /api/products: Get all products
POST /api/products: Add a new product
GET /api/products/{id}: Get product details
PUT /api/products/{id}: Update product details
DELETE /api/products/{id}: Delete a product
Orders
GET /api/orders: Get all orders
POST /api/orders: Create a new order
GET /api/orders/{id}: Get order details
PUT /api/orders/{id}: Update order status
DELETE /api/orders/{id}: Delete an order
Database Models
Customer: Represents a customer in the system.
Product: Represents a product available for sale.
Order: Represents an order placed by a customer.
Contribution
Contributions are welcome! Feel free to fork the repository and submit a pull request with any improvements, bug fixes, or new features.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgements
ASP.NET Core Documentation
Entity Framework Core Documentation
SQL Server Documentation

