# Hair Salon Wep App
### By Rochelle Roberts
-----

## Description
* Hair Salon App provides means for the salon owner to manage their sylists and clients.

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* HTML
* MySQL
* Entity

## App Installation and Running
* Follow the following stepts using the terminal
* Click on the local host link (Ctrl + click )

```sh
$ git clone https://github.com/rochellev/HairSalon.Solution.git
$ cd \HairSalon.Solution\HairSalon
$ dotnet restore
$ dotnet run
```

## App Database Setup
* The Database is named "rochelle_roberts"
```sh
> CREATE DATABASE rochelle_roberts;
> USE rochelle_roberts;
> CREATE TABLE stylists (SylistId serial PRIMARY KEY, name VARCHAR(255), specialty VARCHAR(255));
> CREATE TABLE clients (ClientId serial PRIMARY KEY, name VARCHAR(255));
```

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |:------------:| :--------------:|
| Salon owner starts app, and they are welcomed by a homepage | salon owner runs app | user sees homepage |
| From the Homepage, Salon owner can click links to see all the stylists | click on link to see sylists | app routes user to stylist page |
| On the Sylist page, salon owner will see a list of all the current sylists working in thier salon | user navigates to sylist page | the page displays the current list of sylists |
| From the Stylist page, Salon owner can add stylists to their salon by filling out a "new stylist" form | salon owner clicks on link to add new stylist, then is routed to the new stylist form | upon submission, the new stylist will be added to the list of stylists |
| Salon owner can add clients to a specific stylist by filling out a "new client" form | salon owner clicks on link to add a client, and fills out form | upon submission, the new client will be added the stylist's list of clients |
