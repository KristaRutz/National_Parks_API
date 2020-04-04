# National Parks Database API (C# ASP .NET Application)

## By _**Krista Rutz**_

#### An API application where the user can get and post information about national parks, hosted on [GitHub](https://github.com/KristaRutz/Week-13-Building-an-API-C-Sharp). _Last Updated 04.03.2020._

## Description

This application lets the user create database entries about national parks, letting them add names, states, park codes, regions, website urls, and a note about whether or not the park is open. Ability to get and post parks is included, in addition to put and delete functionality.

This project was developed in C# on the .NET Core platform with ASP.NET Core web processing, using MVC pattern libraries and a SQL database. Specifically, the app was built using Entity Framework and MySQL to create the schema, and it's hosted on [GitHub](https://github.com/KristaRutz/Week-13-Building-an-API-C-Sharp).

It was created for the Epicodus week 13 friday independent project, on week 6 of C# and .NET course: "Building an API".

#### Epicodus skills:

- C#
  <!-- - HTML, CSS -->
  <!-- - Razor view on pages  -->
- MVC pattern (with ASP .NET Core 2.2)
- RESTful routing and CRUD
  <!-- - many-to-many database relationships -->
- Entity framework migrations
  <!-- - Identity and authorization -->
  <!-- - Asynchronous code -->
- MySQL Workbench and server
  <!-- - Bootstrap library -->
- Behavior driven development (BDD)
- Git version control and GitHub
- RESTful API building

## Installation / Set-up

Download or clone the repository to run this program locally!

_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

_This program also makes use of SQL databases. We recommend using MySQL Workbench to build your databases. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for installing MySQL WorkBench and MySQL Community Server on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/Week-13-Building-an-API-C-Sharp) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'Week-13-Building-an-API-C-Sharp'.
  - **To Clone:**
    - Clone from command line into your Desktop: \$ `git clone https://github.com/KristaRutz/Week-13-Building-an-API-C-Sharp`
    - The new directory will be created as 'Desktop/Week-12-Advanced-Databases-and-Authentication-Project'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: \$ `cd Desktop/Week-13-Building-an-API-C-Sharp/NationalParkDirectoryApi`
  - \$ `dotnet restore`
  - \$ `dotnet ef database update`
  - \$ `dotnet build`
  - \$ `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- .NET Core 2.2
  - Server-side in C#
- MySQL database
- Postman

## Specs

Create an API for state and national parks. The API will list state and national parks. Here are the features to include:

- Application includes CRUD functionality and successfully returns responses to API calls.
- Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
- Application is well-documented, including specific documentation on further exploration.
- Once you complete the requirements for the code review, consider adding other functionality from Monday’s Further Exploration. Get creative and add other custom routes, scopes and functionality as well. Here are a few other possibilities to consider:
  - Add a RANDOM endpoint that randomly returns a park.
  - Add a second custom endpoint that accepts parameters. Example: a SEARCH route that allows users to search by specific park names.

Your code will be reviewed for the following objectives:

- [x] Application includes CRUD functionality and successfully returns responses to API calls.

- [ ] Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS.

- [ ] Application is well-documented, including specific documentation on further exploration.

- [ ] Commit history clearly shows eight hours of work.

<!-- <details>
  <summary>Expand specs for this project</summary>

| Spec | Example Input | Expected Output |
| :--- | :------------ | :-------------- |


</details>

<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_, | I want... | so that... |
| :---------------- | :-------- | :--------- |


</details> -->

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
