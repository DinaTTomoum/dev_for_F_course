open System.Web.UI.WebControls
Designing data model
type Details =
    { Name: string 
      Description: string }

type Item =
    { Details: Details }

type Exit =
     PassableExit of Details * Destination: Room
     LockedExit of Details * Key: Item * next: Exit
     NoExit of Details option

and Exits =
    {   North: Exit
        South: Exit
        East: Exit
        West: Exit }

and Room = 
    {   Details: Details
    Items: Item list
        Exits: Exits}

let firstRoom =
    {Details = {Name = "first Room"; Description = "You're standing in the room"};
    Items = [];
    Exits =
        {North = NoExit (None);
         South = NoExit (None);
          East = NoExit(None);
          West = NoExit (None) } }