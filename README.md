# RESTful Web API with Authentication in .NET 7

Welcome to the **RESTful Web API with Authentication in .NET 7** repository! This project demonstrates the implementation of a secure RESTful Web API using the latest .NET 7 framework. The API includes authentication mechanisms to ensure data privacy and access control.

Here are the technologies used in this project:

1. **Framework:**
   - .NET 7: The project utilizes the latest features and improvements from the .NET 7 framework.

2. **Web API:**
   - RESTful API: The project follows REST architectural principles, providing a comprehensive set of endpoints for interacting with resources.

3. **Authentication:**
   - Token-based Authentication: The API implements token-based authentication to ensure secure access. Users need to include their authentication token in the request headers to access protected endpoints.

4. **Web Project:**
   - ASP.NET: The web project, named "Bali Villa," is built using ASP.NET.

5. **Database:**
   - The project uses Microsoft SQL Server as the relational database management system (RDBMS) and utilizes Entity Framework, which is a popular Object-Relational Mapping framework for .NET. It provides a convenient way to interact with a relational database using object-oriented programming concepts.

6. **API Endpoints:**
   - The project defines multiple API endpoints for different resources, such as Users, VillaAPI, and VillaNumberAPI.

7. **Documentation:**
   - Swagger: The API is documented using Swagger, providing a user-friendly interface to explore and test the available endpoints.

8. **Web Interface:**
   - The web project (Bali Villa) includes a user-friendly interface for interacting with the API's authentication features. The authentication flow, login, registration, access control, and logout functionalities are showcased in the interface.

9. **Sample Data:**
   - The project includes pre-seeded sample data to facilitate exploration of the API.


## Features

- **RESTful API:** Build and interact with a comprehensive set of endpoints following REST architectural principles.
- **Authentication:** Implement secure authentication to control access to the API's resources.
- **.NET 7:** Utilize the latest features and improvements from the .NET 7 framework.
- **Sample Data:** Explore the API with pre-seeded sample data.

**Endpoints - Users**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| POST     | /UsersAuth/login        | N/A       |
| POST     | /UsersAuth/register     | N/A       |

**Swagger - Users**

![user](https://github.com/andressasabrantes/BaliVilla-API/assets/87620436/b9355304-bbfb-462e-a60a-558ce03a069c)


**Endpoints - VillaAPI**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| GET      | /VillaAPI               | N/A       |
| POST     | /VillaAPI               | N/A       |
| GET      | /VillaAPI/{id}          | id        |
| DELETE   | /VillaAPI/{id}          | id        |
| PUT      | /VillaAPI/{id}          | id        |
| PATCH    | /VillaAPI/{id}          | id        |

**Swagger - VillaAPI**

![villaAPI](https://github.com/andressasabrantes/BaliVilla-API/assets/87620436/428f5da3-0050-4b19-9335-745cf56b38cf)


**Endpoints - VillaNumberAPI**

| Request  | Endpoint                | Parameter |
|----------|-------------------------|-----------|
| GET      | /VillaNumberAPI         | N/A       |
| POST     | /VillaNumberAPI         | N/A       |
| GET      | /VillaNumberAPI/{id}    | id        |
| DELETE   | /VillaNumberAPI/{id}    | id        |
| PUT      | /VillaNumberAPI/{id}    | id        |
| PATCH    | /VillaNumberAPI/{id}    | id        |

**Swagger - VillaNumberAPI**

![VillaNumberAPI](https://github.com/andressasabrantes/BaliVilla-API/assets/87620436/e06b3937-5d8f-4184-ba81-a2beb8dc381f)


## Authentication
The API implements token-based authentication to ensure secure access. To access protected endpoints, include your authentication token in the request headers.

# Web Project

The web project Bali Villa provides a user-friendly interface for interacting with the API. Below is a walkthrough of the key features with a GIF showcasing the login, registration, access denied for non-admin users, and logout functionalities.

- **Authentication Flow:** The web project incorporates a smooth authentication flow, allowing users to register, log in, and access protected resources based on their roles.

- **Login and Registration:** Users can securely log in or register using the respective forms. The authentication process is token-based, ensuring a secure communication channel between the client and the server.

- **Access Denied for Non-Admin Users:** Certain API endpoints may be restricted to admin users. In the provided example, attempting to access an admin-only resource without the appropriate privileges results in an access denied message.

- **Logout:** Users can easily log out to terminate their session securely.

**User Non-Admin:**

![89wfl8](https://github.com/andressasabrantes/BaliVilla-API/assets/87620436/5209d5b8-d05e-41b5-870e-8ac0c0a136f4)

**Admin User:**

![89wksi](https://github.com/andressasabrantes/BaliVilla-API/assets/87620436/c95ad6ad-4c08-46da-96f9-404f59b8a065)


The web project enhances the overall user experience by providing a visually appealing and intuitive interface for interacting with the API's authentication features. 


## Contributing
Contributions are welcome! If you find a bug or have a suggestion, please create an issue or submit a pull request.
