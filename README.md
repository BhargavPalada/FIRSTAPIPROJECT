README.txt

First.API - Game Management REST API
====================================

Overview
--------
First.API is a .NET 8 Web API project for managing a collection of games using MongoDB as the backend database. It provides endpoints to create, read, update, and delete (CRUD) game records.

Features
--------
- RESTful API for managing games
- MongoDB integration using the official MongoDB.Driver
- Strongly-typed configuration via IOptions pattern
- Model validation and mapping using MongoDB.Bson attributes

Project Structure
-----------------
- First.API/Models/Games.cs: Game entity model with MongoDB mapping attributes
- First.API/Models/GamesDBSettings.cs: Database settings model
- First.API/Services/GameServices.cs: Service layer for CRUD operations
- First.API/Controllers/GamesController.cs: API controller exposing endpoints

Game Model
----------
The `Games` class represents a game with the following properties:
- Id (string): MongoDB ObjectId, primary key
- Name (string): Name of the game
- Description (string): Game description
- Author (string): Game author
- ReleaseDate (DateTime): Release date
- Genre (string): Game genre

Configuration
-------------
Database settings are configured in `appsettings.json`:

  { "GamesDBSettings": { "GamesCollectionName": "Games", "ConnectionString": "mongodb://localhost:27017", "DatabaseName": "GameDB" } }



Endpoints
---------
Assuming the controller route is `/api/games`:

- GET `/api/games`  
  Returns a list of all games.

- GET `/api/games/{id}`  
  Returns a single game by its Id.

- POST `/api/games`  
  Creates a new game.  
  Request body: JSON representation of a `Games` object.

- PUT `/api/games/{id}`  
  Updates an existing game by Id.  
  Request body: JSON representation of a `Games` object.

- DELETE `/api/games/{id}`  
  Deletes a game by Id.

Setup & Running
---------------
1. Ensure you have .NET 8 SDK and MongoDB installed and running.
2. Clone the repository.
3. Update `appsettings.json` with your MongoDB connection details.
4. Build the project:
5. Run the API:
6. The API will be available at `https://localhost:{port}/api/games

Notes
-----
- All MongoDB documents must have a valid ObjectId in the `Id` field.
- Use tools like Postman or curl to test the API endpoints.
- For development, you may use `appsettings.Development.json` for local overrides.

License
-------
This project is provided as-is for educational purposes.
