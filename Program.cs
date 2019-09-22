using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, mood;
            char doAgain;
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("\nHi! Please enter your name");
                name = Console.ReadLine();

                Console.WriteLine("\nNice to meet you " + name + ".  What are you in the mood for? Please choose: \n\nAction \nChilling \nDanger \nFood\n");
                mood = Console.ReadLine();

                if (mood == "action" || mood == "Action" || mood == "ACTION")
                {
                    Console.WriteLine("\nAwesome!. How many people are joining you?\n");
                    string people = Console.ReadLine();
                    int num = -1;
                    if(!int.TryParse(people, out num))
                    {
                        Console.WriteLine("\n" + name + ", please enter digits");
                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("\n" + name + ", Strap on some driving shoes and go stock car racing.");
                    }
                    else if (num <= 4)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go stock car racing. You should probably take an Uber.");
                    }
                    else if (num <= 10)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go stock car racing.  Your going to need an Uber XL.");
                    }
                    else if (num >= 11)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go stock car racing.  Your going to need to call and Uber Air!");
                    }
                }

                else if (mood == "chilling" || mood == "Chilling" || mood == "CHILLING")
                {
                    Console.WriteLine("\nCool! How many people are joining you?");
                    string people = Console.ReadLine();
                    int num = -1;
                    if(!int.TryParse(people, out num))
                    {
                        Console.WriteLine("\n" + name + ", please enter digits");
                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("\n" + name + ", I think you should go hiking in some comfortable hiking shoes.");
                    }
                    else if (num <= 4)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go hiking. You should probably take an Uber..");
                    }
                    else if (num <= 10)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go hiking.  You're going to need an Uber XL");
                    }
                    else if (num >= 11)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go hiking.  Your're going to need to call an Uber Air!");
                    }
                }

                else if (mood == "danger" || mood == "Danger" || mood == "DANGER")
                {
                    Console.WriteLine("\nDope! How many people are joining you?");
                    string people = Console.ReadLine();
                    int num = -1;
                    if (!int.TryParse(people, out num))
                    {
                        Console.WriteLine("\n" + name + ", please enter digits");
                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("\n" + name + ", I think you should go sky diving in some tightly tied shoes!");
                    }
                    else if (num <= 4)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go sky diving. You should probably take an Uber.");
                    }
                    else if (num <= 10)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go sky diving.  You're going to need an Uber XL.");
                    }
                    else if (num >= 11)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go sky diving.  You're going to need to call and Uber Air!");
                    }
                }
                else if (mood == "food" || mood == "Food" || mood == "FOOD")
                {
                    Console.WriteLine("\nFantastic! How many people are joining you ?");
                    string people = Console.ReadLine();
                    int num = -1;
                    if (!int.TryParse(people, out num))
                    {
                        Console.WriteLine("\n" + name + ", please enter digits");
                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("\n" + name + ", I think you should go to Taco Bell in some fresh kicks!");
                    }
                    else if (num <= 4)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go to Taco Bell. You should probably take an Uber.");
                    }
                    else if (num <= 10)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go to Taco Bell.  You're going to need an Uber XL.");
                    }
                    else if (num >= 11)
                    {
                        Console.WriteLine("\n" + name + ", I think you and your " + people + " friends should go to Taco Bell.  You're going to need to call and Uber Air!");
                    }
                }
                else
                {
                    Console.WriteLine("\nI'm sorry.  Please enter one of the following:\naction\nchilling\ndanger\nfood");
                }

            Console.WriteLine("\n\nWould you like to run the program again. ('Y' or 'N')\n");
            doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain == 'y' || doAgain == 'Y')
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Console.WriteLine("\nThanks for the chat.  Have a great time!");
                    Console.ReadKey();
                }
            }
        }
    }
}
        
    




                

         

