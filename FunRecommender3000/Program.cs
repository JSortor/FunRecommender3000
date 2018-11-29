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
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many people are you bringing with you?");
            Console.WriteLine("Here are your choices :\n1) 0\n2) 1-4\n3) 5-10\n4) 11+");
            int answer2 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Console.WriteLine("Congratulations your a big asshole!!!!");
                Console.ReadKey();
            }
        }
    }
}
