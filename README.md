# Implementing an API Gateway in ASP.NET Core with YARP

## Overview
This repository contains the source code and detailed instructions for implementing an API Gateway using YARP (Yet Another Reverse Proxy) in ASP.NET Core. The project demonstrates how to configure a gateway that routes requests to different microservices, enhancing the scalability and security of your application.

## Note
This repository accompanies an article written in Italian. While the code comments and variable names are in English, the full explanation and tutorial are available in Italian on the blog post linked below.

## Key Features
- Configuration of an API Gateway using YARP
- Routing of requests to multiple microservices
- Custom header handling to demonstrate YARP's capabilities
- Example project setup for testing the gateway

## Prerequisites
- Visual Studio 2022 or later
- .NET 7.0 SDK or later
- Basic knowledge of ASP.NET Core Web API and YARP

## Getting Started
1. Clone this repository.
2. Open the solution in Visual Studio.
3. Build and run both the `APIGateway` and `APIGateway.Customers` projects.
4. Use tools like `curl`, Postman, or Swagger UI to test the API Gateway.

## Project Structure
- **APIGateway:** Contains the gateway configuration using YARP.
- **APIGateway.Customers:** A sample microservice with API endpoints that the gateway routes to.
- **appsettings.json:** Configures the routes and headers for the gateway.

## Usage
The gateway project is configured to route requests to the `APIGateway.Customers` project. You can customize the routing rules, headers, and other settings in the `appsettings.json` file of the `APIGateway` project.

### Example Requests
- **Create a new customer:**
  ```bash
  curl --location --request POST 'http://localhost:5000/customers/create?customer=nuovo%20cst'
- **List all customers:**
  ```bash
  curl --location 'http://localhost:5000/customers/all'

## Advanced Topics
- Extending the gateway to handle more microservices.
- Customizing YARP middleware for logging, authentication, or load balancing.
- Performance considerations when using an API Gateway.

## Contributing
Feel free to fork this repository, suggest improvements, and submit pull requests. Contributions that enhance the functionality or documentation are highly appreciated.

## Learn More
For a detailed explanation of the concepts and implementation, check out the full article (in Italian) on https://cosminirimescu.com.