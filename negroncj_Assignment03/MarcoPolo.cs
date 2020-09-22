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
 * Demonstrate all these artifatcs in your Main method. // done
 * 
 * Refrence: 
 * Visual C# How to program: Chapter 5.6 if else
 * Class Meeting on 9/15/2020
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace negroncj_Assignment03
{
    public class MarcoPolo
    {
        //Properties
        //I make it private so the user cant manipulate it.
        private String mResponse; //Make it say marco or polo when I ask
        private String mAction; // find out how the robot will interact. 
        private String mFound; //If the computer found me or not.
       

        public String Response //non static propertie 1/3
        {
            get
            {
                return mResponse; //Returns the set
            }

            set
            {
                if (value == "marco" || value == "Marco") // if you say marco
                {
                    //It will say Polo
                    mResponse = "Polo!";
                }
                else
                {
                    if (value == "polo" || value == "Polo") // If you say polo
                    {
                        //It will say Marco
                        mResponse = "Marco!";
                    }
                }
            }
        }
        public String Action //non static propertie 2/3
        {
            get
            {
                return mAction; //Returns the set
            }

            set
            {
                if (value == "pool" || value == "Pool") // If we are in a pool
                {
                    //It will swim
                    mAction = "Action: Swimming";
                }
                else
                {
                    if (value == "Backyard" || value == "backyard") // If we are in a backyard
                    {
                       //It will run
                        mAction = "Action: Running";
                    }
                }

            }
        }
        public String Found //non static property 3/3
        {
            get
            {
                return mFound; //Returns the set
            }
            set
            {
                if (value == "yes" || value == "Yes") //If I say yes
                {
                    //He will respond
                    mFound = "Gotcha!";
                }
                else
                {
                    if (value == "no" || value == "No") //If I say no
                    {
                        //he will ask
                        mFound = "Where are you?";
                    }
                }
            }
        }

        public static string Feedback //static property 1/1
        {
            get; //Will send back what the user put in main
            set;
           
        }
        public static string CanYouHearMeNow(String Feedback) //static method 1/1
        {
            //If a spesific string is said
            if (Feedback == "Can you hear me?")
            {
                //It will respond
                return "YES! I can";
            }
            else //But if not
            {
                //it will just show periods
                return ".......";
            }
            

        }
        public string NamePlayer(String player) //non static method 1/2
        {
            //Returns the name of the player you have put in main
            return player;
        }
        public string FinalResult(String WinOrLose) //non static method 2/2
        {
            //Will return the string you put in main
            return WinOrLose;
        }
    }
}

