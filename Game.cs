using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_s_Morning_
{
    class Game
    {
        string userInput1;
        string userInput2;
        string userInput3;
        string userInput4;
        string userInput5;

        string[] contentArray1 = new string[6];
        string[] mistakeArrays = new string[1];
        List<string> foodEaten = new List<string>();

        public void storyChoicesArrays()
        {
            contentArray1[0] = "\n   Your name is Juno Itchybarky Sanchez. You are a one and a half year old Rough Collie dog and your dad calls you his “big baby”, because you love to whine. If you’re not trying to steal someone’s attention, you’re trying to steal your family’s “people” food. You’re spoiled enough to be given expensive can food and endless treats, but you’ll turn your nose up at them in exchange for cakes and cookies, and especially your favorite: Cheesy popcorn. When you’re not begging to have your favorite toys thrown at 50 miles an hour at play time, you’re sleeping on your parents bed in a pile of plushies. But you’re just an average, everyday puppy dog, and this is your morning.";

            contentArray1[1] = "\n\n    It’s been a long night and you’ve been sound asleep in your parents room, using your favorite blue crocodile toy as a pillow. All through the night you’ve been hearing miscellaneous noises around your house. Big Vroom-vrooms (cars) passing, a couple of little cats, sometimes a songbird, but you know it’s morning when light starts to creep in through the windows.\n Your eyes flutter open, and you get up on your paws with a biiiiig stretch. You realize quickly that you’re kinda hungry, kinda wanna play, and kinda-really need to poop and pee. It’s time to start the day! So, who’re you gonna say good morning to? \n        1) mom     2)Dad       3)Grandma      4)Grandpa";

            contentArray1[2] = "\n   Grandpa  woken and walked to make coffee";

            contentArray1[3] = "\n\n   mom woke up and kiss you then woke up dad. He then takes you outside directly.";//<<<----Useless and to scared to remove it. It might ruin the code or not. Not going to riskk it

            contentArray1[4] = "\n   He finish his coffe and head to the bathroom";

            contentArray1[5] = "   You huffed in annoyance. Would you like to: \n\n      1) Wait.       2) Explore.     ";
        }

        public void userTypoErrors()
        {
            mistakeArrays[0] = "\n\n\n                           ........wwwwwWWWWWWOOOOOOAAAAaaAAAAAAAAaaaaAAAAAAAHHHHH!!!!!!!!!";
        }

        public void firstScenario()
        {


            Console.Clear();
            Console.WriteLine(contentArray1[0]);
            Console.WriteLine(contentArray1[1]);

            userInput1 = Console.ReadLine();

            if (userInput1 == "1")
            {
                Console.Clear();
                Console.WriteLine("\n   Your black and white claws click on the wooden as you approach the bed where your parents are. You can’t help but wag your tail upon seeing dad’s face buried in his pillow. He’s so silly, still sleeping when it’s already time to get up. Usually he’s the first one to get up with you, and Mom stays under the covers.\n You stand there for a moment, just wagging your tail and hoping they get up, but it’s been a whole minute now, and a minute is an eternity in dog time. So you decide to give them a little encouragement to get up.\n\n  Type BABY MODE for the Wah-mbulance\n\n  Type BABY MODE");
                userInput2 = Console.ReadLine();

                if (userInput2.ToLower() == "baby mode") .
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine("   'Waaaaah, waaaah….' You paw at the side of the bed that mom always sits at. She always gives into your crying!\n 'Come on Mom, we’ve gotta go out and eat garbage…' You cry at her. You jump onto the bed and waddle around a bit, and then a minute later you’re making eye contact with each other. Then Mom looks at Dad and prods at his back. You hear him take a deep breath before he gets up.\n 'Dad will walk you…' Mom tells me, and I get off the bed with dad. Finally, it’s time for your walk!");
                    Console.ReadLine();
                    OutsideWithDad();
                }
                else
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine("   'Waaaaah, waaaah….' You paw at the side of the bed that mom always sits at. She always gives into your crying!\n 'Come on Mom, we’ve gotta go out and eat garbage…' You cry at her. You jump onto the bed and waddle around a bit, and then a minute later you’re making eye contact with each other. Then Mom looks at Dad and prods at his back. You hear him take a deep breath before he gets up.\n 'Dad will walk you…' Mom tells me, and I get off the bed with dad. Finally, it’s time for your walk!");
                    Console.ReadLine();
                    OutsideWithDad();
                }
            }

            if (userInput1 == "2")
            {
                Console.Clear();
                Console.WriteLine("\n   Your black and white claws click on the wooden as you approach the bed where your parents are. You can’t help but wag your tail upon seeing dad’s face buried in his pillow. He’s so silly, still sleeping when it’s already time to get up. Usually he’s the first one to get up with you, and Mom stays under the covers.\n You stand there for a moment, just wagging your tail and hoping they get up, but it’s been a whole minute now, and a minute is an eternity in dog time. So you decide to give them a little encouragement to get up.\n\n  Type BABY MODE for the Wah-mbulance");
                userInput2 = Console.ReadLine();

                if (userInput2.ToLower() == "baby mode" || userInput2.ToLower() == "babymode") 
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine("   Waaah…' You push your big needle nose into your dad’s personal space, and whine incessantly, perhaps too much. But dad’s really testing your patience...  which isn’t a lot, because you’re a baby.\nYou wait… and wait… and wait.It’s not working.It’s time for drastic measures. You climb onto the bed and bounce right on dad’s belly.He makes the most groaniest groan you’ve ever heard, and you’re elated because that means he sure isn’t sleeping anymore!\nHe reaches his hand out to pet you and wishes you good morning, and without a moment’s hesitance, he’s off the bed and stretching. Finally, it’s time for your walk!");
                    Console.ReadLine();
                    OutsideWithDad();
                }
                else
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine("   Waaah…' You push your big needle nose into your dad’s personal space, and whine incessantly, perhaps too much. But dad’s really testing your patience...  which isn’t a lot, because you’re a baby.\nYou wait… and wait… and wait.It’s not working.It’s time for drastic measures. You climb onto the bed and bounce right on dad’s belly.He makes the most groaniest groan you’ve ever heard, and you’re elated because that means he sure isn’t sleeping anymore!\nHe reaches his hand out to pet you and wishes you good morning, and without a moment’s hesitance, he’s off the bed and stretching. Finally, it’s time for your walk!");
                    Console.ReadLine();
                    OutsideWithDad();
                }
            }

            if (userInput1 == "3")
            {
                Console.Clear();
                Console.WriteLine("\n   You decide to leave the bedroom, your parents’ snoring fading in the distance as you pad out of the room. You enter the kitchen, your ears pricking up at the sound of something, or rather someone, moving. You wag your fluffy squirrel tail upon immediately seeing Grandma. You decide to say good morning!\n You paw up at her and whine for some pets. She pets you gladly, but doesn’t give you much more attention than that. Her people words pass right in one ear and out the other, but she points in the direction of the bedroom and says a few words you recognize…. “Play… Grandpa…” And then she goes back to doing whatever she was up to in the kitchen. It’s clear that she doesn’t wanna be bothered right now… Let’s go see what Grandpa is doing.");
                Console.WriteLine(contentArray1[2]);
                Console.ReadLine();
                GrandpaChoice();
            }

            if (userInput1 == "4")
            {
                Console.Clear();
                Console.WriteLine(contentArray1[2]);
                Console.ReadLine();
                GrandpaChoice();
            }

            else
            {
                firstScenario();
            }

        }

        public void GrandpaChoice()
        {
            Console.WriteLine("\n   what would you like to do?\n    1) Bark (to hurry him up)     2) Wait      3) Leave (to wake up mom or dad)");
            userInput3 = Console.ReadLine();
            if (userInput3.ToLower() == "bark" || userInput3 == "1")
            {
                GrandpaChoicePart2();
            }

            if (userInput3.ToLower() == "wait" || userInput3 == "2")
            {
                GrandpaChoicePart2();
            }

            if (userInput3.ToLower() == "leave" || userInput3 == "3")
            {
                Console.Clear();
                Console.WriteLine("\n   Juno got bored and decided to wake up his parents. fustrated that they're still asleep you activated....\n  Type BABY MODE");
                userInput4 = Console.ReadLine();

                if (userInput4.ToLower() == "baby mode") 
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine(contentArray1[3]);
                    Console.ReadLine();
                    OutsideWithDad();
                }
                else
                {
                    Console.Clear();
                    Typewrite(mistakeArrays[0]);
                    Console.ReadKey();
                    Console.WriteLine(contentArray1[3]);
                    Console.ReadLine();
                    OutsideWithDad();
                }
            }

            else
            {
                GrandpaChoice();
            }
        }

        public void GrandpaChoicePart2()
        {
            Console.WriteLine(contentArray1[4]);
            Console.WriteLine(contentArray1[5]);
            userInput5 = Console.ReadLine();
            if (userInput5.ToLower() == "wait" || userInput5 == "1")
            {
                Console.WriteLine("\n\n   You waited patiently.... Moments later he got out and took you outsides.");
                Console.ReadLine();
                OutsideWithGrandpa();
            }

            if (userInput5.ToLower() == "explore" || userInput5 == "2")
            {
                Console.WriteLine("   You decided to look around whie he finished and found...");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  Chicken Bone");
                Console.ResetColor();
                Typewrite("\n\n                   NOM NOM NOM NOM NOM NOM NOM *burp*      ");
                foodEaten.Add("Chicken Bone");
                Console.ReadLine();
                Console.WriteLine("\n   You then went back to see if he is done and he is. He then took you outside");
                Console.ReadLine();
                OutsideWithGrandpa();
            }
            else
            {
                GrandpaChoicePart2();
            }
        }

        public void OutsideWithDad()
        {
            Dad_sPath dad_sPath1 = new Dad_sPath();
            Console.Clear();
            dad_sPath1.LeftOrRight();
            Console.ReadLine();
        }

        public void OutsideWithGrandpa()
        {
            Grandpa_sPath grandpa_sPath1 = new Grandpa_sPath();
            Console.Clear();
            grandpa_sPath1.LeftOrRight();
            Console.ReadLine();
        }

        //    BELOW HERE IS NOTHING IMPORTANT BUT THE TYPEWRITER
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(1);
            }
        }

     }
}
