using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello young fellow you look brave for a quest. what is your name");
        string name = Console.ReadLine();
        Console.WriteLine(name + " would you like to start your quest");
        string choice = Console.ReadLine();
        if (choice == "yes" || choice == "y")
        {
            Console.WriteLine(" ok lets start our adventure");
            Console.WriteLine(@" ^  ^  ^   ^      ___I_      ^  ^   ^  ^  ^   ^  ^");
            Console.WriteLine(@"/|\/|\/|\ /|\    /\-_--\    /|\//|\ /|\//|\/|\ /|\/|\ ");
            Console.WriteLine(@"/|\/|\/|\ /|\   /  \_-__\   /|\//|\ /|\//|\/|\ /|\/|\ ");
            Console.WriteLine(@"/|\/|\/|\ /|\   |[]| [] |   /|\//|\ /|\//|\/|\ /|\/|\ ");
        }
        else
        {
            Console.WriteLine(" ok i understand its a dangerous world out there");
        }
        Console.WriteLine(name + " would you like to head to the evil sorcerer's Castle or the spooky bog");
        string question = Console.ReadLine();
    }
}


/*
Function Main
    Declare Boolean choice
    Declare String name
    Declare Boolean spookyBog
    Declare Boolean sorcerersCastle
    
    Output "hello young fellow you look brave for a quest. what is you name"
    Input name
    Output "" & name &"  would you like to start your quest"
    Input choice
    If choice=true
        Output "ok lets start our adventure"
        Output "" & name &" would you like to head to the evil sorcerer's castle or the spooky bog"
        Input choice
        If ((sorcerersCastle=false) &&
(spookyBog=true))
            Output 
        False:
            Output 
        End
    False:
        Output "ok i understand its a dangerous world out there"
    End
End



*/
