using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    //Game States
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    String easyLevelPassword = "easypassword";
    String hardLevelPassword = "hardpassword";


    // Use this for initialization
    void Start ()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Press 1 to go into 1");
        Terminal.WriteLine("Press 2 to go into 2");
        Terminal.WriteLine("\nEnter your selection:");
    }

    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            VerifyPassword(input);
        }
    }

    private void VerifyPassword(string input)
    {
        if ((input == easyLevelPassword && level == 1) || (input == hardLevelPassword && level == 2))
        {
            currentScreen = Screen.Win;
            Terminal.WriteLine("Yupeee, you made it.... !!!!");
        }
        else
        {
            Terminal.WriteLine("Busted, you should run.... !!!!");
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();

        }

        else if (input == "007")
        {
            Terminal.WriteLine("Welcome Mr Bond.");
        }
        else
        {
            Terminal.WriteLine("Please enter a valid number");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
