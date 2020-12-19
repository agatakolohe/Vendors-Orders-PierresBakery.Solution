# Vendors & Orders Tracker for Pierre's Bakery

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<p align="center">Basic Web Application with C# Indenpendent Project for Epicodus, 12-18-2020</p>
<p align="center"> By Agata Kolodziej</p>

## Description

Eighth independent project for Epicodus to demonstrate my understanding of creating C# basic web applications, ASP.NET Core MVC web application, HTTP CRUD methods, MVC application, RESTful routing and test-driven development. This web application will track Pierre's bakery vendors and their orders. It is a web application that will track Pierre's(user) vendors and their purchases. This application will include a splash page welcoming Pierre and providing a link to view the current vendor's page and a link to add a new vendor. The vendor's page will list all the current vendors and contain a link to a page presenting a form that Pierre(user) can fill out to create a new vendor. If there are no current vendors, the page will alert Pierre that there are currently no vendors and provide a link to add a new vendor or return to home page. After the form is submitted, the inputted vendor will be saved to the website and the user will be taken back to the homepage. Pierre (user) can click on a vendor's name and go to a new page that will display all of that selected vendor's orders. Pierre (user) can also click on a link to a page presenting a form to create a new order for a particular vendor.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Vendor()

| Test                                                        | Expect                                                |
| ----------------------------------------------------------- | ----------------------------------------------------- |
| It will instantiate a Vendor object with Vendor constructor | Vendor(string vendorName, string vendorDescription)   |
| It will assign a Vendor Id number to a Vendor               | Vendor(int vendorId).toEqual(1);                      |
| It will create a list of Vendor objects                     | vendorList = new List<Vendor> { vendor01, vendor02 }; |
| It will find specific vendor by Vendor Id                   | Vendor.Find(2).toEqual(vendor02);                     |
| It will associate order with vendor                         | vendor.AddOrder(order) order.Items.toEqual(order);    |

### Describe: Order()

| Test                                                       | Expect                                                             |
| ---------------------------------------------------------- | ------------------------------------------------------------------ |
| It will instantiate an Order object with Order constructor | Order(string orderTitle, string orderDescription, int orderPrice)  |
| It will get the current date for OrderDate                 | order.GetOrderDate() order.OrderDate("Friday, December 18, 2020";) |
| It will assign an Order Id number to an Order              | Order(int orderId).toEqual(1);                                     |
| It will create a list of Order objects                     | orderList = new List<Order> { order01, order02 };                  |
| It will find specific order by Order Id                    | Order.Find(2).toEqual(order02);                                    |

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

##### Compiling

- Navigate to the VendorsOrdersPieresBakery folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the VendorsOrdersPierresBakery.Tests folder in the command line
- Use the command `dotnet restore`

##### Run Tests

- Navigate to VendorsOrdersPierresBakery.Tests folder in the command line
- Use the commands `dotnet build` and `dotnet restore` to make sure code is compiled and packages are installed
- Use the command `dotnet test` to run tests on all test methods

##### View In Browser

- To view in browser, navigate to VendorsOrdersPierresBakery folder in the command line
- Use the command `dotnet run` to execute the compiled code and start a localhost
- In browser navigate to http://localhost:5000
- Click "View Your Vendors" to see all added vendors
- Click "Add a New Vendor" to add a new vendor
- Enjoy the web application!

## Known Bugs

VS Code has been a little buggy recently. If after cloning the repo and you are unable to compile restart VS Code.

## Support and Contact Details

If any errors or bugs occur with installation delete both bin and obj folders and follow the Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- .NET Core 2.2
- ASP.NET Core MVC
- Bootstrap
- C# 7.3
- CRUD
- CSS
- GitHub
- HTML
- HTTP
- Razor
- REPL
- RESTful Conventions
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej
