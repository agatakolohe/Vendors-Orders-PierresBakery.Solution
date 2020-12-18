# Vendors & Orders Tracker for Pierre's Bakery

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<p align="center">Basic Webb Application with C# Indenpendent Project for Epicodus, 12-18-2020</p>
<p align="center"> By Agata Kolodziej</p>

## Description

Eighth independent project for Epicodus to demonstrate my understanding of creating C# basic web applications, ASP.NET Core MVC web application, HTTP CRUD methods, MVC application, RESTful routing and test-driven development. This web application will track Pierre's Bakery's vendors and their orders. It will create a web application that will track Pierre's vendors and their purchases. This application will include a splash page welcoming Pierre's Bakery and providing a link to a vendor's page. The vendor's page will contain a link to a page presenting a form that Pierre(user) can fill out to create a new vendor. After the form is submitted, the inputted vendor will be saved to the website and the user will be taken back to the homepage. Pierre (user) can click on a vendor's name and go to a new page that will display all of that vendor's orders. Pierre (user) can also click on a link to a page presenting a form to create a new order for a particular vendor.

\*\*\* add definitions for MVC, CRUD, HTTP, REST

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Vendor()

| Test                                                        | Expect                                                            |
| ----------------------------------------------------------- | ----------------------------------------------------------------- |
| It will instantiate a Vendor object with Vendor constructor | Vendor(string vendorName, string vendorDescription)               |
| It will assign a Vendor Id number to a Vendor               | Vendor(string vendorName, string vendorDescription, int vendorId) |

### Describe: Order()

| Test | Expect |
| ---- | ------ |

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/Vendors-Orders-PierresBakery.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing Packages

- Navigate to the Bakery.Tests folder in the command line
- Use the command `dotnet restore`

##### Run Tests

- Navigate to Bakery.Tests folder in the command line
- Use the commands `dotnet build` and `dotnet restore` to make sure code is compiled and packages are installed
- Use the command `dotnet test` to run tests on all test methods

##### View Online

- To view in browser click the GH-Pages link: [Name of App](URL)
- what to do when open online

## Known Bugs

TODO

## Support and Contact Details

If any errors or bugs occur with installation delete both bin and obj folders and follow the Installing Packages and Run Console Application instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

\*\*list alphabetically

- HTML
- CSS
- Bootstrap
- C# 7.3
- Razor
- ASP.NET Core MVC
- RESTful Routing
- CRUD
- HTTP
- .NET Core 2.2
- REPL
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej
