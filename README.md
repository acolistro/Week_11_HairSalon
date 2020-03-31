# _Eau Claire's Salon_

#### _ASP.NET MVC Week 11 Independent Project for Epicodus_, _Mar. 20 2020_

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
|User can delete stylists|User selects "Delete" from options on "David Bowie" Details page|"David Bowie" is removed from the stylists table, as well as all their clients.|
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

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/acolistro/Week_11_HairSalon``
* ``cd Week_11_HairSalon``

_Confirm that you have navigated to the HairSalon.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Recreate the ``alyssa_colistro`` database using the following MySQL commands (in Terminal on macOS or PowerShell on Windows):_
* CREATE DATABASE alyssa_colistro;
* USE alyssa_colistro;
* CREATE TABLE `alyssa_colistro`.`stylists` (
  `StylistId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  `Specialty` VARCHAR(255) NULL,
  `HireDate` VARCHAR(255) NULL,
  `StationAssignment` INT NULL,
  PRIMARY KEY (`StylistId`));
* CREATE TABLE `alyssa_colistro`.`clients` (
  `ClientId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  `StylistId` INT NULL DEFAULT 0,
  PRIMARY KEY (`ClientId`));

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd Week_11_HairSalon``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of the Week_11_HairSalon directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

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
