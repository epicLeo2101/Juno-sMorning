using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_s_Morning_
{
    class Food
    {
        List<string> foodEaten = new List<string>();

        public void junoAteEverything()
        {
            Console.Clear();
            Console.WriteLine("   Feeling complete and happy you ran to see mom. She was suprised at your enthusiasm she rewarded you with....");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Dried Salmon and Cheesy PopCorn");
            Console.ResetColor();
            Console.ReadLine();
            foodEaten.Add("Dried Salmon");
            foodEaten.Add("Cheesy PopCorn");
            Console.WriteLine("  Later you notice your morning food place down. Happy as you are you ate it gleefully.");
            Console.ReadLine();
            foodEaten.Add("Canned Food");
            Typewrite("\n\n       nom nom nom nom nom nom nom nom nom nom           *buuuuurp*      ");
            Console.ReadLine();
            Environment.Exit(0);

        }

        public void junoAteAtleastTwo()
        {
            Console.Clear();
            Typewrite("   bbrrrrrrrlllllll");
            Console.ReadLine();
            Console.WriteLine("\n   Your stomach is still grumbling for more food. At least is not too bad. However, Grandma noticed your sorrow of lack of food. So she made your favorite....");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Chicken Stew");
            Console.ResetColor();
            Console.ReadLine();
            foodEaten.Add("Chicken Stew");
            Console.WriteLine("\n Despite not having a feast outside. this is just as good.");
            Typewrite("\n\n       nom nom nom nom nom nom nom nom nom nom           *buuuuurp*      ");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void junoAteNothing()
        {
            Console.Clear();
            Console.WriteLine("\n   You came home with an empty stomach. This made you so upset you activated...");
            Console.ReadLine();
            Typewrite("\n  PERMANENT BABY MODE!!!   ");
            Console.ReadLine();
            Console.WriteLine("  You wine, barked, and even went on a food strike. Until they serve you something better than bland food. However, you are very hungry so you ate...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Canned Food");
            Console.ResetColor();
            Console.ReadLine();
            foodEaten.Add("Canned Food");
            Typewrite("\n\n       *lick* *lick* *lick* *lick* *lick* num       *Siiiiigh*  ");
            Console.ReadLine();
            Environment.Exit(0);
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
          // message for the proffesor: this was supposed to be a way to count all the food you eaten and if you ate enough it'll sent you to these endings but this will be due in an hour so I change it.