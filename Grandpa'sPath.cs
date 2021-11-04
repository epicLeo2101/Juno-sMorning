using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_s_Morning_
{
    class Grandpa_sPath
    {

        string userInput8;
        string userInput9;

        List<string> foodEaten = new List<string>();

        public void LeftOrRight()
        { 
            Console.Clear();
            Console.WriteLine("   Outside you got a choice to go LEFT or RIGHT. Where do like to go?\n\n   1) Left.       2) Right.");
            userInput8 = Console.ReadLine();
            if (userInput8.ToLower() == "left" || userInput8 == "1")
            {
                Left();
            }

            if (userInput8.ToLower() == "right" || userInput8 == "2")
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
            Console.WriteLine("   Exploring the Left side of the street. you noticed that grandpa started to ");
            Console.ReadKey();
            Typewrite("                        *YYYYYYYYYYyyyyyaaAAAaaaaAAAnnnNNNnn*");
            Console.WriteLine("\n Would you like to: ");
            Console.WriteLine("\n          1) Yawn.       2) Sniff.       3) Explore.");
            userInput9 = Console.ReadLine();
            if (userInput9.ToLower() == "yawn" || userInput9 == "1")
            {
                Typewrite("\n\n   'GGGggghhiiiiaaaa!'");
                Console.ReadKey();
                Console.WriteLine("\n   Grandpa laugh at your bizzare yawn. his laugh sounded pleasant to you so you sat. He then kneeled down and gave you....");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Dog Treat");
                Console.ResetColor();
                Console.ReadKey();
                foodEaten.Add("Dog Treat");
                Typewrite("\n\n                   NOM NOM NOM NOM NOM NOM NOM * burp *      ");
                Console.ReadLine();
                Typewrite("\n      *pet* *pet* *pet* *pet* *pet* *pet* *pet*");
                Console.ReadKey();
                Console.WriteLine("\n  He peted you all the way home");
                Ending2();
            }

            if (userInput9.ToLower() == "sniff" || userInput9 == "2")
            {
                Console.WriteLine("   While he is yawning you sniffed around");
                Console.ReadLine();
                Typewrite("\n   *GASP*");
                Console.WriteLine("   You smell 3 different food on a bush up ahead. Being so hungry you can't help but go after it. Not sure how the mechanism work around your neck it manage to streched all the way to the bush and you can't believe what you found....");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Pizza Crust, Hot Dog, and Cookie");
                Console.ReadLine();
                Console.ResetColor();
                foodEaten.Add("Pizza Crust");
                foodEaten.Add("Hot Dog");
                foodEaten.Add("Cookie");
                Typewrite("\n   num num num num munch munch munch *GUUULP*           *BUUURP*  ");
                Console.ReadLine();
                Console.WriteLine("\n  You enjoyed a fantastic feast and grandpa was unaware of your deeds. Making it even better. Satisfied you lead tired grandpa back home.");
                Console.ReadLine();
                Ending1();
            }

            if (userInput9.ToLower() == "explore" || userInput9 == "3")
            {
                Console.WriteLine("   Tired Grandpa did a long yawn. You too the opportunity to look for any treats before he notice and then you found....");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Bread Piece");
                Console.ResetColor();
                Console.ReadLine();
                foodEaten.Add("Bread Piece");
                Typewrite("\n\n                   NOM NOM NOM NOM NOM NOM NOM * burp *      ");
                Console.ReadLine();
                Console.WriteLine("\n Grandpa chuckled hearing you burped. He then leaded you home. Disapointed because you could of sworn you smelled more than just bread.");
                Console.ReadLine();
                Ending2();
            }

            else
            {
                Left();
            }
        } 

        public void Right()
        {
            Console.Clear();
            Console.WriteLine("   You pull the tired sleep deprived old man to the right side of the street. You glance around and pooped. While grandpa is busy picking up your mess you can't help but smell something delicious. Do you....\n\n   Want to:   1) Wait        2)Pull (To go find the source of the smell");
            userInput9 = Console.ReadLine();
            if (userInput9.ToLower() == "wait" || userInput9 == "1")
            {
                Console.Clear();
                Console.WriteLine("   You feel bad treating him harshly lately so you waited for him to finish.");
                Console.ReadKey();
                Typewrite("\n\n      *pet* *pet* *pet* *pet* *pet* *pet* *pet* *pet*");
                Console.ReadKey();
                Console.WriteLine("\n   Then he continue on the left side of the street.");
                Console.ReadLine();
                Left();
            }

            if (userInput9.ToLower() == "pull" || userInput9 == "2")
            {
                Typewrite("\n      *bbbbrrrrrrrrrrruuuuuUUUUUMMMMMBBBLLLLLEEEEE*");
                Console.ReadKey();
                Console.WriteLine("\n  Despite of of feeling bad for him you are just so hungry. So you can't help but pull his leash to get the delicious food.");
                Console.ReadKey();
                Typewrite("   '¡AAaayy güeeyYY!'");
                Console.ReadKey();
                Console.WriteLine("\n  He screamed and let go of the leash. You sniffed and found what you were looking for....");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" McDonald piece of meat");
                Console.ResetColor();
                foodEaten.Add("McDonald piece of meat");
                Console.ReadLine();
                Console.WriteLine("\n\n   He ran to you, upset that you ate something but relieved that you didn't ran away. Happy you and grandpa waled to the other side of the street.");
                Console.ReadLine();
                Left();
            }
        }

        public void Ending1()
        {
            Food ending = new Food();
            Console.Clear();
            ending.junoAteEverything();
            Console.ReadLine();
        }

        public void Ending2()
        {
            Food ending2 = new Food();
            Console.Clear();
            ending2.junoAteAtleastTwo();
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
