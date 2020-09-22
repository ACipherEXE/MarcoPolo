/* Christopher Negron
 * negroncj@mail.uc.edu
 * Contemporary Programming, IT3045
 * Assignment #3
 * Due: 9/17/2020
 * Design and program a class that models something in the real world. You are the domain expert: pick something that has meaning to you.
 * 
 * Your VS solution should have 2 classes: one will contain your entry point (Main method) and the other will contain your real-world model. 
 * In the Main method declare and instantiate your class, then demonstrate how it  works. 
 * 
 * Your model should have at least:
 * one static method, // done
 * one static property, //done
 * two  non-static methods, //done
 * and three non-static properties. //done 
 * Demonstrate all these artifatcs in your Main method. //done
 * 
 * Refrence: 
 * Visual C# How to program: Chapter 5.6 if else
 * Class Meeting on 9/15/2020
 * 
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace negroncj_Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            MarcoPolo marcoPolo = new MarcoPolo();
            //I want to play a game with my program, Marco and Polo
            // A fun game about useing your ears to find the other person
            //to do that I am going to make a other class 
            //Who are we playing with?
            String Player = "Windows 10";
            String YourName = "Christopher";
            //Non static Method 1/2
            marcoPolo.NamePlayer(Player);
            Console.WriteLine("Player: "+ Player);

            //Can I talk to it?
            //static property 1/1
            MarcoPolo.Feedback = "hello";
            Console.WriteLine("\n" + YourName +": "+"Hello?");
            Console.WriteLine(Player +": "+MarcoPolo.Feedback);

           

            //Can player hear me?
            String result = "Can you hear me?";

            //Static Method 1/1
            MarcoPolo.CanYouHearMeNow(result);
            Console.WriteLine("\n" + YourName +": "+result);
            Console.WriteLine(Player + ": "+MarcoPolo.CanYouHearMeNow(result));

            //I say Marco to the other class



            String scream = "Marco";
            // non-static properties 1/3
            marcoPolo.Response = scream;
            // Responds with polo
            Console.WriteLine("\n" + YourName + ": " + "lets play Marco Polo");
            Console.WriteLine(YourName + ": " + scream);
            Console.WriteLine(Player + ": " + marcoPolo.Response);


            //Area we are playing


            String Area = "pool";
            //non-static properties 2/3
            marcoPolo.Action = Area;
            //Responds with Action: swimming
            Console.WriteLine("\n" + YourName + ": " + "we are playing in a " +Area);
            Console.WriteLine(Player + ": "+marcoPolo.Action);

            //did he found me?

            String DidHeFindMe = "yes";
            //non-static properties 3/3
            marcoPolo.Found = DidHeFindMe;
            Console.WriteLine("\n"+YourName + ": " + "Did you find me?: " + DidHeFindMe);
            Console.WriteLine(Player + ": " + marcoPolo.Found);

            

            //Now lets show all the informacion we got in one sheet
           //non static method 2/2
           Console.WriteLine("\n"+Player +" has "+marcoPolo.FinalResult("Won"));
           Console.WriteLine("\n" + YourName + " has " + marcoPolo.FinalResult("Lose"));

        }
        
    }
}
