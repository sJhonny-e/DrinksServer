# DrinksServer
Simple API server for managing drinks inventory

Just a simple WebAPI server that implements a RESTful API for a `drink` entity.  
The server is implemented in the `DrinksServer` project.  
Simple server tests are in the `DrinksServer.Tests` project.  

I've added a client implementation for the `Drink` entity to an existing API client, that can be found under `Checkout.ApiClient.Net45\ApiServices\Drinks` (the rest of the client library code was left as-is; it wasn't written by me).  

I've also added a test console app which uses the new client implementation to test the new server API (`ClientTestApp`).  

##Installation
Prerequisites: .Net >= 4.5 , Visual Studio 2015 or later.  
Download the code, open in Visual Studio, restore NuGet packages and build 

##Running
You can run the solution directly from VS

##Tests
Run server tests in Visual Studio (ctrl + R + A)  
For integration tests, start the API server by runing the solution in visual studio, and run the `ClientTestApp` from the command-line.  

##About the server
Just a very ordinary WebAPI server, uses a mock repository for 'storage'.  
I've added support for an IoC container (Unity, in this case).  

##What can be improved
Obviously this is just a little sample app; to make it more production-worthy, the following steps may be worth doing:  
* Split different layers (Model, Controllers, DAL) to different DLLs.  
* Add an authorization layer (just read the authorization header on incoming requests).  
* Have a proper IoC container (I just used Unity because it was the easiest) and initialize it in a better way than in `IoCRegistrator`.  
* Borrow a few functional programming concepts would make the code more robust:  
  * Create a proper Result class (with `success` true / false, and an error type) for the different operations (i.e `DrinksRepository.Create`), instead of returning a boolean for success / failure.
  * Create Value Objects for different parameters (for example - a drink name)
* When using a proper Database, the `Create` method should return the new object's ID
* Add `page` and `resultsPerPage` to the `get` method for pagination; we don't want to dump the whole database into the network..
* As the logic contained in different modules is added, add unit tests to test it.
