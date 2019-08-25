# Hair Salon Wep App
### By Rochelle Roberts
-----

## Description
* Hair Salon App helps the Salon Owner manage their sylists and clients.

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* HTML
* MySQL
* Entity

## Installation
* Follow the following stepts using the terminal
* After running project, got to http://localhost:5000

```sh
$ git clone https://github.com/rochellev/HairSalon.Solution.git
$ cd \HairSalon.Solution\HairSalon
$ dotnet restore
$ dotnet ef database update
$ dotnet run
```

## Database Setup
* The Database is named "rochelle_roberts"
* Using migrations to maintain database
* Type dotnet ef database update
* Note: starting mysql varies by machine

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |:------------:| :--------------:|
| Salon owner starts app, and they are welcomed by a homepage | salon owner runs app | user sees homepage |
| From the Homepage, Salon owner can click links to see all the stylists | click on link to see stylists | app routes user to stylist page |
| On the Stylist page, salon owner will see a list of all the current stylists working in their salon | user navigates to stylist page | the page displays the current list of stylists |
| From the Stylist page, Salon owner can add stylists to their salon by filling out a "new stylist" form | salon owner clicks on link to add new stylist, then is routed to the new stylist form | upon submission, the new stylist will be added to the list of stylists |
| Salon owner can add clients to a specific stylist by filling out a "new client" form | salon owner clicks on link to add a client, and fills out form | upon submission, the new client will be added the stylist's list of clients |
