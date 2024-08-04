// Michael Richter 577302 (code)
// Arlo Roos 577441 (code)
// Hendro Opperman 577861 (User manual)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PRG281_Project
{
    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            //objects
            CreateLoans CreateLoans = new CreateLoans();
            Menus menus = new Menus();
            SplashScreen splash = new SplashScreen();

            //variable to close menu
            bool backToMenu = true;
            //close Option refers to the use of the close menu (it keeps its meaning throughout the program)
            bool closeOption = false;

            //insert do while
            //this loop ensures that the program keeps running until the user choses to close the program
            do
            {
                //this thread is is linked to the LOANS splash screen the user sees at the start of the program
                //A thread is used for its built-in Thread.Sleep() method
                //This ensures that the splash screen looks animated
                Thread splashScreen = new Thread(splash.display);
                splashScreen.Start();
                splashScreen.Join();

                //Display all the needed questions and outputs for loan in the console
                closeOption = CreateLoans.DisplayLoan();

               
                //calls a menu with a yes or no outcome
                //the menu is asks the user if they want to go back to the main menu
                //if no is selected the program will automaticaly be closed
                if (closeOption==false)
                {
                    switch (menus.menuYesNoBackToMenu())
                    {
                        case "Yes":
                            backToMenu = true;
                            break;
                        case "No":
                            backToMenu = false;
                            break;
                    }
                }
                else
                {
                    //this ensures that the program closes and exits the loop
                    backToMenu=false;
                }
                

            } while (!(backToMenu.Equals(false)));

            
        }
    }
}
