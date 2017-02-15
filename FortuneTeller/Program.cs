using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to The Fortune Teller Program, ENTER / TYPE your First Name");
            string firstName = (Console.ReadLine());
            Console.WriteLine("ENTER / TYPE your Last Name");
            string lastName = (Console.ReadLine());
            Console.WriteLine("ENTER / TYPE quit if you would like to quit");
            string name = (Console.ReadLine());

            switch (name.ToLower())
            {
                case "quit":    
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;

                case "yes":
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;
                case "no":
                    Console.WriteLine("\a" + "I knew you weren't a quitter");
                    break;
            }
                
            Console.WriteLine("ENTER / TYPE your age");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER / TYPE quit if you would like to quit");
            string name1 = (Console.ReadLine());
            switch (name1.ToLower())
            {
                case "quit":
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;

                case "yes":
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;
                case "no":
                    Console.WriteLine("\a" + "I knew you weren't a quitter");
                    break;
            }

            Console.WriteLine("ENTER / TYPE your birth month as a number");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER / TYPE quit if you would like to quit");
            string name2 = (Console.ReadLine());
            switch (name2.ToLower())
            {
                case "quit":
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;

                case "yes":
                    Console.WriteLine("\a" + "Nobody likes a quitter");
                    break;
                case "no":
                    Console.WriteLine("\a" + "I knew you weren't a quitter");
                    break;
            }

            Console.WriteLine("ENTER / TYPE your favorite ROYGBIV color, IF you do NOT know what ROYGBIV means TYPE Help");
            string favColor = (Console.ReadLine());
            string[] color = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            
            if (favColor.ToLower() == "help") 
            {
                Console.WriteLine("ROYGIB means / represents R = Red, O = Orange, Y = Yellow, G = Green, B = Blue, I = Indigo, V = Violet");
            }
            
            Console.WriteLine("ENTER / TYPE how many siblings you have");
            int siBlings = int.Parse(Console.ReadLine());

            if (userAge % 2 == 0)
            {
                Console.WriteLine( firstName + "  " + lastName + " will retire in 10 years " );
            }
            else
            {
               Console.WriteLine( firstName + "  " + lastName + " will retire in 12 years " );
            }
            switch (birthMonth)
            {
                case 1:
                Console.WriteLine(" with $10,000 in the bank ");
                    break;

                case 2:
                    Console.WriteLine(" with $10,000 in the bank ");
                    break;

                case 3:
                    Console.WriteLine(" with $10,000 in the bank ");
                    break;

                case 4:
                    Console.WriteLine(" with $7,500 in the bank ");
                    break;

                case 5:
                    Console.WriteLine(" with $7,500 in the bank ");
                    break;

                case 6:
                    Console.WriteLine(" with $7,500 in the bank ");
                    break;

                case 7:
                    Console.WriteLine(" with $7,500 in the bank ");
                    break;

                case 8:
                    Console.WriteLine(" with $7,500 in the bank ");
                    break;
                case 9:
                    Console.WriteLine(" with $5,000 in the bank ");
                    break;

                case 10:
                    Console.WriteLine(" with $5,000 in the bank ");
                    break;

                case 11:
                    Console.WriteLine(" with $5,000 in the bank ");
                    break;

                case 12:
                    Console.WriteLine(" with $5,000 in the bank ");
                    break;
                default:

                    Console.WriteLine(" will retire with no money in the bank ");
                    break;
            }
            if (siBlings == 0)
            {
                Console.WriteLine(" with a vacation home in Las Vegas ");
            }
            else if (siBlings == 1)
            {
                Console.WriteLine(" with a vacation home at Disney World ");
            }
            else if (siBlings == 2)
            {
                Console.WriteLine(" with a vacation home at Myrtle Beach ");
            }
            else if (siBlings == 3)
            {
                Console.WriteLine(" with a vacation home at San Diego ");
            }
            else if (siBlings > 3)
            {
                Console.WriteLine(" with a vacation home at Hawaii ");
            }
            else if (siBlings < 0)
            {
                Console.WriteLine(" with a vacation home on your couch ");
            }

            switch (favColor.ToLower())    
            {
                case "red":     
                          Console.WriteLine( " & a corvette");
                          break;
                    
                case "orange":     
                             Console.WriteLine(" & a Kia Soul ");
                             break;

                case "yellow":
                             Console.WriteLine(" & a VW Bettle ");
                             break;

                case "green":
                            Console.WriteLine(" & a moped ");
                            break;

                case "blue":
                           Console.WriteLine(" & a Ford Truck ");
                           break;

                case "indigo":
                             Console.WriteLine(" & a Toyota Prius ");
                             break;

                case "violet":
                    Console.WriteLine(" & a Honda Accord ");
                    break;
                default: 

                    Console.WriteLine(" unknown character ");
                    break;
            }
            Console.WriteLine();
        }
    }
}
