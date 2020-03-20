# _Best Restaurants_

#### _ASP.NET MVC Week 11 Independent Project for Epicodus_, _Mar. 19 2020_

#### By _**Alyssa Colistro**_


## Description

_A website where a hair salon (user) can add and edit and track clients based on the stylists they employ._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|User can can choose to add a new stylist| "Karen Smith"| "Karen Smith" is added to the stylist database|
|User can view all stylists|Selects "view all"|All stylists in the stylist table of the database are printed to the page|
|User can view all clients of each stylist|Clicks "Karen Smith"|All clients that serve "Karen Smith" are displayed.|
|User can edit added stylists|"Karen Smith" --> "David Bowie"|"Karen Smith" is updated to "David Bowie" in the stylist table|
|User can delete stylists|User selects "Delete" from options on "David Bowie" Details page|"David Bowie" is removed from the stylists table.|
|User can add a new client and specify which stylist it belongs to, as well as other client details.|"Beyonce Knowles", "David Bowie"|"Beyonce Knowles" is added to the clients table, with the idea of the specified stylist in a stylist column.|
|User can view all clients|Selects "view all"|User can see all clients listed in the clients table.|
|User can edit clients|"Beyonce Knowles" --> "Michele Obama"|"Beyonce Knowles" is updated to "Michele Obama" in the restaraunt table.|
|User can delete clients|User selects "Delete"|The row with "Michele Obama" is removed from the clients table.|
|User can enter a query to search existing stylists |User enters "Octavia Spencer"| Search results return a link to the stylist Octavia Spencer, which then can take the user to all Octavia Spencer's clients |


## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/acolistro/Week_11_Salon``
* ``cd HairSalon.Solution``

_Confirm that you have navigated to the Week_11_Salon.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd HairSalon``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``


_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

### Create Project Database
* Navigate to your terminal and open MySQL
```sh
mysql -uroot -p<your_password_here>
```
* Once in MySQL, create a database for storing project data:
```sh
CREATE DATABASE `hair_salon`;
```
* Create a table in hair_salon for storing stylist data:
```sh
CREATE TABLE `stylists` (
  `stylistid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stylistid`));
```
* Create a table in hair_salon for storing client data:
```sh
CREATE TABLE `clients` (
  `clientid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `stylistid` int(11) DEFAULT '0',
  PRIMARY KEY (`clientid`));
```

Your project is now ready.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/acolistro/week_11_salon/issues) here on GitHub._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _dotnet script_
* _MySQL_
* _EF Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Alyssa Colistro_**