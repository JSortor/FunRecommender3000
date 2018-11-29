using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommender3000
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome, to the FunRecommender3000");
            Console.WriteLine("What type of fun are you in the mood for tonight?\n(Please enter the number of your selection)\nYour choices are :");
            Console.WriteLine("1) Action\n2) Chilling\n3) Danger\n4) Good Food");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out int answer1);
                while (!int.TryParse(input1, out answer1))
                {
                    Console.WriteLine("Sorry, Your input was not understood, please re-enter selection");
                    Console.WriteLine("What type of fun are you in the mood for tonight?\n(Please enter the number of your selection)\nYour choices are :");
                    Console.WriteLine("1) Action\n2) Chilling\n3) Danger\n4) Good Food");
                    input1 = Console.ReadLine();
                    int.TryParse(input1, out answer1);
                }
            Console.WriteLine("How many people are you bringing with you?");
            Console.WriteLine("Here are your choices :\n1) 0\n2) 1-4\n3) 5-10\n4) 11+");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out int answer2);
                
                if ((answer1 == 1) && (answer2 == 1))
                {
                    Console.WriteLine("Okay if your in the mood for action, then you should go stock car racing and travel in your sneakers!");
                }
                else if ((answer1 == 1) && (answer2 == 2))
                {
                    Console.WriteLine("Okay if your in the mood for action, then you should go stock car racing and travel in a sedan!");
                }
                else if ((answer1 == 1) && (answer2 == 3))
                {
                    Console.WriteLine("Okay if your in the mood for action, then you should go stock car racing and travel in a volkswagen bus!");
                }
                else if ((answer1 == 1) && (answer2 == 4))
                {
                    Console.WriteLine("Okay if your in the moof for action, then you should go stock car racing and travel in an airplane!");
                }
                else if ((answer1 == 2) && (answer2 == 1))
                {
                    Console.WriteLine("Okay if your in the mood for chilling, Then you should go hiking and travel in your sneakers!");
                }
                else if ((answer1 == 2) && (answer2 == 2))
                {
                    Console.WriteLine("Okay if your in the mood for chilling, then you should go hiking and travel in a sedan!");
                }
                else if ((answer1 == 2) && (answer2 == 3))
                {
                    Console.WriteLine("Okay if your in the mood for chilling, then you should go hiking and travel in a volkswagen bus!");
                }
                else if ((answer1 == 2) && (answer2 == 4))
                {
                    Console.WriteLine("Okay if your in the mood for chilling, then you should go hiking and travel in an airplane!");
                }
                else if ((answer1 == 3) && (answer2 == 1))
                {
                    Console.WriteLine("Okay if your in the mood for danger, then you should go skydiving and travel in your sneakers!");
                }
                else if ((answer1 == 3) && (answer2 == 2))
                {
                    Console.WriteLine("Okay if your in the mood for danger, then you should go skydiving and travel in a sedan!");
                }
                else if ((answer1 == 3) && (answer2 == 3))
                {
                    Console.WriteLine("Okay if your in the mood for danger, then you should go skydiving and travel in a volkswagen bus!");
                }
                else if ((answer1 == 3) && (answer2 == 4))
                {
                    Console.WriteLine("Okay if your in the mood for danger, then you should go skydiving and travel in an airplane!");
                }
                else if ((answer1 == 4) && (answer2 == 1))
                {
                    Console.WriteLine("Okay if your in the mood for good food, then you should go to taco bell and travel in your sneakers!");
                }
                else if ((answer1 == 4) && (answer2 == 2))
                {
                    Console.WriteLine("Okay if your in the mood for good food, then you should go to taco bell and travel in a sedan!");
                }
                else if ((answer1 == 4) && (answer2 == 3))
                {
                    Console.WriteLine("Okay if your in the mood for good food, then you should go to taco bell and travel in a volkswagen bus!");
                }
                else if ((answer1 == 4) && (answer2 == 4))
                {
                    Console.WriteLine("Okay if your in the mood for good food, then you should go to taco bell and travel in an airplane! ");
                }
           
            Console.WriteLine("GoodBye");
            Console.ReadKey();
        }
    }
}
