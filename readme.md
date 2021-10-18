# _{Friday Week 10 - Factory}

### By _{Becket Harvey}_


#### _Technologies Used_
* C#
* .NET v5.0
* ASP.NET Core MVC
* HTML
* Bootstrap
* MySQL
* CSS
* MySQL Workbench
* Razor
* Entity FrameworkCore
* .NET Core CLI

## Description _This project allows the user the explore the database concept of many to many relationships using the structure of a fictional factory employing several engineers._



## Setup/Installation Requirements
 - Clone or download the zip file of this repository to your desktop
 - Navigate into the top level directory
 - Open in your code editor
 - Create a .gitignore file that includes the following:
>
>*/obj/
>*/bin/
>*/appsettings.json

 - Commit and push your .gitignore file to your repo
 - Create a file named "appsettings.json" in the root directory add the following code to the appsettings.json file:
>{
>  "ConnectionStrings": {
>      "DefaultConnection": "Server=localhost;Port=3306;database=brandon_eads;uid=root;pwd=[YOUR-PASSWORD-HERE];"
>  }
>}
 - Replace [YOUR-PASSWORD-HERE] with your unique MySql password
 - 
 - Launch the MySql server:
 - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your   unique MySql password

 - Insert your MySQL password and user Id
 - Make sure to have .NET 5.0 installed
 - Run `$ dotnet restore` to install bin & obj folders
 - Make sure to have EntityFrameworkCore.Design 5.0 added and dotnet ef installed globally


## Additional Steps
* In your terminal navigate to the main project folder.
* If Migrations folder is not present run $ dotnet ef migrations add Initial to add Migrations folder
* Then run $ dotnet ef database update to create the schema
* Navigate to the main project folder in the command line or terminal
* Run the command `dotnet restore` to restore the project dependencies
* Run the command `dotnet build` to build and compile the project
* Run the command `dotnet run` to start the live server to view the project


## Known Bugs
* _Email if you find any!_

## License
_{MIT}_ This is open source for anyone to use and I am not responsible for any problems resulting from its use or implementation

## Contact Information
* Find me on Github under SunshinePunch!