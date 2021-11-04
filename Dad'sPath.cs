using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_s_Morning_
{
    class Dad_sPath
    {

        string userInput6;
        string userInput7;

        List<string> foodEaten = new List<string>();

        public void LeftOrRight()
        {
            Console.Clear();
            Console.WriteLine("   Outside you got a choice to go LEFT or RIGHT. Where do like to go?\n\n   1) Left.       2) Right.");
            userInput6 = Console.ReadLine();
            if (userInput6.ToLower() == "left" || userInput6 == "1")
            {
                Left();
            }

            if (userInput6.ToLower() == "right" || userInput6 == "2")
            {
                Right();
            }

            else
            {
                LeftOrRight();
            }
        }

        public void Left()
        {
            Console.Clear();
            Console.WriteLine("   Exploring the Left side of the street. you noticed that dad started to ");
            Console.ReadKey();
            Typewrite("                        *YYYYYYYYYYyyyyyaaAAAaaaaAAAnnnNNNnn*");
            Console.WriteLine("\n Would you like to: ");
            Console.WriteLine("\n          1) Yawn.       2) Sniff.       3) Explore.");
            userInput7 = Console.ReadLine();
            if (userInput7.ToLower() == "yawn" || userInput7 == "1")
            {
                Typewrite("\n\n   'GGGggghhiiiiaaaa!'");
                Console.ReadKey();
                Console.WriteLine("\n   Your dad can't help but laugh from the strange sound you just made. So much so that you can't helped but to be happy and pounce on him. He calmed you down with a...");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Dog Treat");
                Console.ResetColor();
                Console.ReadKey();
                foodEaten.Add("Dog Treat");
                Typewrite("\n\n                   NOM NOM NOM NOM NOM NOM NOM * burp *      ");
                Console.ReadLine();
                Console.WriteLine("\n   Later you went home");
                Console.ReadLine();
                Ending2();
            }

            if (userInput7.ToLower() == "sniff" || userInput7 == "2")
            {
                Console.WriteLine("   While he is yawning you sniffed around");
                Console.ReadLine();
                Typewrite("\n   *GASP*");
                Console.WriteLine("   You smell 3 different food on a bush up ahead. Being so hungry you can't help but go after it but...");
                Console.ReadKey();
                Typewrite("\n    GGGghhhaaaaa!!!");
                Console.ReadKey();
                Console.WriteLine("   The leash is too short to reach it. Upset you ended the walk and headed home.");
                Console.ReadLine();
                Ending3();
            }

            if (userInput7.ToLower() == "explore" || userInput7 == "3")
            {
                Console.WriteLine("   While he is yawning you took this chance to look frantically for any food you can find and you did. You found....");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Bread Piece");
                Console.ResetColor();
                Console.ReadLine();
                Typewrite("\n  ggggGGGGGGGGGGHUHHHUAAAAAAAAAAAAAaaaaa!!!!      ");
                Console.ReadKey();
                Console.WriteLine("\n   Your dad shoved his sausage fingers in your mouth. Removing the bread you found and tossing it away.\n  Upset he scolded you and headed home.");
                Console.ReadLine();
                Ending3();
            }

            else
            {
                Left();
            }
        } 

        public void Right()
        {
            Console.Clear();
            Console.WriteLine("   As you wondered on the rigth side of the street you pooped. While dad is bussy picking up your poop, you smell something good. Do you....\n\n   Want to:   1) Wait        2)Pull (To go find the source of the smell");
            userInput7 = Console.ReadLine();
            if (userInput7.ToLower() == "wait" || userInput7 == "1")
            {
                Console.WriteLine("   Despite the delicious smell you waited.");
                Console.ReadLine();
                Typewrite("\n\n         *pet* *pet* *pet* *pet* *pet* *pet* *pet* *pet*");
                Console.WriteLine("\n    He congratulate you and headed home");
                Console.ReadLine();
                Ending3();
            }

            if (userInput7.ToLower() == "pull" || userInput7 == "2")
            {
                Typewrite("\n      *bbbbrrrrrrrrrrruuuuuUUUUUMMMMMBBBLLLLLEEEEE*");
                Console.ReadKey();
                Console.WriteLine("\n   Your stomach rumbles and decided to after the delicious smell.");
                Console.ReadLine();
                Typewrite("\n    GGGghhhaaaaa!!!");
                Console.ReadKey();
                Console.WriteLine("\n   Your dad was suprised but held a firm grip on your leash. Defeated you were not only scolded but head home early.");
                Console.ReadLine();
                Ending3();
            }

            else
            {
                Right();
            }
        } 

        public void Ending2()
        {
            Food ending2 = new Food();
            Console.Clear();
            ending2.junoAteAtleastTwo();
            Console.ReadLine();
        }

        public void Ending3()
        {
            Food ending3 = new Food();
            Console.Clear();
            ending3.junoAteNothing();
            Console.ReadLine();
        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(30);
            }
        }
    }
}
