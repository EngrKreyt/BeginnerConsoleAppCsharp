// See https://aka.ms/new-console-template for more information
//Console.Clear();
Console.WriteLine("Rio's Console App for Beginners");
do
{
    try
    {
        

        // Main Menu

        String[] mainmenu = new String[] { "[1] Enter", "[2] Settings", "[3] Exit" };

        foreach (string menu in mainmenu)
        {
            Console.WriteLine(menu);
        }

        for (int i = 0; i < mainmenu.Length; i++)
        {
            int mainMenuOpt = Convert.ToInt32(Console.ReadLine());

            int choice1 = Convert.ToInt32(mainmenu[0] = "1"); //update
            int choice2 = Convert.ToInt32(mainmenu[1] = "2"); //update
            int choice3 = Convert.ToInt32(mainmenu[2] = "3"); //update
            if (mainMenuOpt == choice1)
            {
                Console.WriteLine("You have chosen1");

                Console.Clear();
                String[] menu1 = new String[] { "[1] Enter User", "[2] Exit" };

                foreach (string menu in menu1)
                {
                    Console.WriteLine(menu);
                }
                for (int j = 0; j < menu1.Length; i++)
                {
                    int userMenuChoice = Convert.ToInt32(Console.ReadLine());

                    int userchoice1 = Convert.ToInt32(menu1[0] = "1"); //update
                    int userchoice2 = Convert.ToInt32(menu1[1] = "2"); //update
                    if (userMenuChoice == userchoice1)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter UserName:");
                        string? username = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Welcome: " + username);
                        BeginnerConsoleApp.ProgramMenu instance = new BeginnerConsoleApp.ProgramMenu();
                        instance.progMenu();
                        break;
                    }
                    if (mainMenuOpt == choice2)
                    {
                        Console.WriteLine("You have chosen2");
                        //Console.Clear();
                        //temp = choice2;
                        break;
                    }
                    if (mainMenuOpt == choice3)
                    {
                        Console.WriteLine("Goodbye");
                        //temp = choice3;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! ... Try again!");
                    }

                }

                //temp = choice1;
                break;
            }
            if (mainMenuOpt == choice2)
            {
                Console.WriteLine("You have chosen2");
                //Console.Clear();
                //temp = choice2;
                break;
            }
            if (mainMenuOpt == choice3)
            {
                Console.WriteLine("You have chosen3");
                //temp = choice3;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! ... Try again!\n Press Esc to exit or Press Any key To Continue...");
                break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: "+ex );
    }
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape || Console.ReadKey.key != 3);
