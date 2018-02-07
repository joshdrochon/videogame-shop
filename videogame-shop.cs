using System;
using System.Collections.Generic;

public class VideoGame
{
    private string Title;
    private string Platform;
    private string Genre;
    private bool Multiplayer;
    private int Price;
    
    //title
    public void SetTitle(string newTitle)
    {
        Title = newTitle;
    }

    public string GetTitle()
    {
        return Title;
    }
    
    //console
    public void SetPlatform(string newPlatform)
    {
        Platform = newPlatform;
    }

    public string GetPlatform()
    {
        return Platform;
    }
    
    //genre
    public void SetGenre(string newGenre)
    {
        Genre = newGenre;
    }

    public string GetGenre()
    {
        return Genre;
    }

    //muliplayer
    public void SetMuliplayer(bool newMultiplayer)
    {
        Multiplayer = newMultiplayer;
    }

    public bool GetMultiplayer()
    {
        return  Multiplayer;
    }

    //price
    public void SetPrice(int newPrice)
    {
        if(newPrice >= 0)
        {
            Price = newPrice;
        }
        else
        {
            Console.WriteLine("Sorry the price for this item cannot be negative!");
        }
    }

    public int GetPrice()
    {
        return Price;
    }


    public VideoGame(string gameTitle, string gamePlatform, string gameGenre, bool multiplayer, int gamePrice)
    {
        Title = gameTitle;
        Platform = gamePlatform;
        Genre = gameGenre;
        Multiplayer = multiplayer;
        Price = gamePrice;
    }
}

public class Program
{
    public static void Main()
    {
        VideoGame tlou = new VideoGame("The Last of Us", "Playstation 3", "Survival horror", true, 30);
        VideoGame mgs = new VideoGame("Metal Gear Solid", "Playstation", "Action-adventure stealth", false, 40);
        VideoGame zelda = new VideoGame("Ocarina of Time", "Nintendo 64", "Action-adventure", false, 70);
        VideoGame halo = new VideoGame("Halo: Combat Evolved", "Xbox", "First-person shooter", true, 20);
        VideoGame overwatch = new VideoGame("Overwatch", "PC", "First-person shooter", true, 30);
        VideoGame tetris = new VideoGame("Tetris", "Nintendo", "Puzzle", false, 40);
        
        
        List<VideoGame> GameDetails = new List<VideoGame>() {tlou, mgs, zelda, halo, overwatch, tetris};

        foreach (VideoGame game in GameDetails) /* 'game' variable stands for each element of the list */
        {   
            Console.WriteLine(game.GetTitle());
            Console.WriteLine(game.GetGamePlatform());
            Console.WriteLine(game.GetPrice());
            Console.WriteLine(game.GetGenre());
            Console.WriteLine(game.GetMultiplayer());
        }
    }
}



// var props = VideoGame.GetProperties();
// foreach(object VideoGame in GameDetails) {
//     foreach(var prop in props) 
//     {
//         Console.WriteLine(game.prop);
//     }
// }

// var props = objectType.GetProperties();
// foreach(object obj in data) {
//     foreach(var prop in props) {
//         object value = prop.GetValue(obj, null); // against prop.Name
//     }
// }





