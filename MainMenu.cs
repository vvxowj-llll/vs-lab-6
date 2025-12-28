using System;

class MainMenu
{
    private string[] buttons = { "Start", "Load", "Settings", "Exit" };

    public void ShowMenu()
    {
        Console.WriteLine("=== RoBox ===");
        for (int i = 0; i < buttons.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {buttons[i]}");
        }
    }

    public void Click(string choice)
    {
        if (choice == "Start")
            new Game().StartNewGame();
        else if (choice == "Load")
            new Game().LoadGame();
        else if (choice == "Settings")
            new Settings().OpenSettings();
        else if (choice == "Exit")
        {
            Console.WriteLine("Выход из игры");
            Environment.Exit(0);
        }
    }
}