using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_s_Morning_
{
    class Program
    {
        static void Main()
        {
            bool running = true;
            int menuSelect;

            while (running == true)
            {


                Console.Clear();
                Console.Title = "Juno's Morning";


                String title = @"              -*=                                                -#@%%**:                 
            .*++%@+.                                          :+#%%%#=+==                 
            +===#%%#+.                                      -*##%@@%==-:+                 
           :=:-=#%@###+.                                  :*####@%@*=-::=.                
           =---=*@@%####+.                               +####%@%@%+=----:                
           +-===*%@@######+.                           :####%@%@@%*+=====:                
           +==++%%%@@%######-                         +####@@%%@@#*+++++=:                
           +++++#%@%%@%######*.                     .*#####%@%%@%***++++*.                
           =+++**#@@%@#########- :::::  .-=======- -##%%%%%%@@%@%******+*                 
           :*****##@%@@%%%%%%%%@%%%%%%%%%%%%%%%%%%%@%%%%%%%%@@@@%%#*****=                 
            **##%%%@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@%######                  
            :##%%%%@%%%%%%%%%%%%%%%%%%%%%%%%%%#####%%%%%%%%%%%%%%%%@%%%%=                 
           .-*#@%%%%%%%%%%%%%%##****#%%%%%%#*********%%%%%%%%%%%%%%%%@%#*                 
           .#@@%%%%%%%%%%%%%#********#%%%#************#%%%%%%%%%%%%%%@%=.                 
           :#@@@%%%@%%%@%@%***********%%#**************#@%%%%%%%%%%%%%%=:                 
            =#@%%%%%@%####**###*******************##%#******#%%%%%%%%%%%%#.               
          :%%%%%%%%@%%#***##@#=%****************#@%=#@##*****#@%%%%%%%%%%%*               
         -%%%%%%%%%@@%%#####@@@@****************#@@%@@+###***%%%%%%%%%%%%%@               
         %%%%%%%%%%%%%****#%#%%%*****************@#*#%#***####@%%%%%%%%%%*:               
          :=*%@@@%%%*********#%#*****************##***************#%%@@%=.                
          :+%%%%%%%*********#%******++************%***************#%%%%%%@*.              
         *%%%%%%%%%#**************+==--=+***********************#%%%%%%%%%%%=             
       .#%%%%%%%%#*************=--=#%#=::-*#***********************#%%%@@@@@@=            
       #%@@%%%%#*************#-:=*%@@@%-:::=#***********************#%%%@@@+-:            
      .*%@%%%%##**************+#%%@@@@%#=::=********************####%%%%%@@@+             
       +@%%%%%%###*******#%*#%##%%%%@@%%%%++********************#%%%%%%%%%@@@:            
      -@%%%%%%%%###*****#%#*#%%@@@@@@@@@@%%*+#**#%#**#**********##%%%%@%%%%@@+            
      %@%%%%%%%#####***####**@%%@@@@@@@%%%%=##***%%%%@#*******#####%%%@@@%%@@+            
     :@%%%%%%%########*###+++#@%@@@@@@@%%*--=**+*%%%%#*****########%%%%@@@@@@=            
     =@@@@@%%%#############++=+#@@@@@@@#+::+:--*%%%%#****###########%%%%@#*%%             
     -@@%@%%%%%############%*-----=++=-::::-:=*%#%%#**#############%%%%%@@++*             
      =:.@%%%%%%#############%#*******++++=**%+=%%%##############%%%%%%%%@+===            
        .@%%%%%%#############%%%%++++##++++++*-#%%###############%%@%%%%%%=-=+.           
         @%%%%%%############**%%*++++*#++++*=*#%#################%%@%%%%@+-:-+*           
         *%@@%%%%%############**+++++#+++++-%%%#################%%%@@%%@*-:::=++          
         .%##%%@%%######%##*+#*+++++*++++*+*%%##*==#############%%@%#@%=-:::::-=+:        
            -@%#%%###%%%#*=--=##++++*+++*==%%##+=--=##%########%%%@#+=-:::::::::--=:      
             -*++***#++=:::::-#%##**#+*###%%**==::::-*%%%%%%%%%@@#+++=-:::::::::::::=     
            -*+++++*+-:::::::-+%%#=##%*#=#*=*==:::::::-=*###%*+*+-::=*==-::::::::::=.     
           =+===++**-::::::::-=##%%%####+-++==:::::::::::--==---::::::++==-:::::=-:       
         -+=--=++**=-:::::::::-=*++===+=+++=-:::::::::::::::::::::::::::+*+=-:::-==-:     
       :+=---=++**=-:::::::::::-==++++++++=-:::::::::::::::::::::::::::::-*+=-::::=-      
      +=-----=+**==--::::::::::::--======-:::::::::::::::::::::::::::-+==+*==-::=-        
      ==-----++#**#*--::::::::::::::::::::::::::::::::::::::::::::::::-+=---:::::=        
       .-=*+==+***#=----::::::::::::::::::::::::::::::::::::::::::::::::+=-:::::::=       
     :=+**+=-=+****=------:::::::::::::::::::::::::::::::::::::::::::::::+=-:::::::-   
                         _____ _                                                   
                        |_   _| |__   ___                                          
                          | | | '_ \ / _ \                                         
                          | | | | | |  __/                                         
                ___       |_|_|_| |_|\___|                                         
               / _ \ _ __ __| (_)_ __   __ _ _ __ _   _                            
              | | | | '__/ _` | | '_ \ / _` | '__| | | |                           
              | |_| | | | (_| | | | | | (_| | |  | |_| |                           
      _   _    \___/|_|  \__,_|_|_| |_|\__,_|_| _ \__, |  _     _                  
     | | | |_ __  _ __ ___ _ __ ___   __ _ _ __| ||___/ _| |__ | | ___             
     | | | | '_ \| '__/ _ \ '_ ` _ \ / _` | '__| |/ / _` | '_ \| |/ _ \            
     | |_| | | | | | |  __/ | | | | | (_| | |  |   < (_| | |_) | |  __/            
     _\___/|_| |_|_|_ \___|_| |_| |_|\__,_|_|__|_|\_\__,_|_.__/|_|\___|            
    |  _ \ ___ _ __| |__   __ _ _ __  ___  | __ )  ___  _ __(_)_ __   __ _         
    | |_) / _ \ '__| '_ \ / _` | '_ \/ __| |  _ \ / _ \| '__| | '_ \ / _` |        
    |  __/  __/ |  | | | | (_| | |_) \__ \ | |_) | (_) | |  | | | | | (_| |        
  __|_|_  \___|_|  |_| |_|\__,_| .__/|___/_|____/ \___/|_|  |_|_| |_|\__, |        
 |  \/  | ___  _ __ _ __ (_)_ _|_| __ _  |  ___|__  _ __      | |_   |___/_   ___  
 | |\/| |/ _ \| '__| '_ \| | '_ \ / _` | | |_ / _ \| '__|  _  | | | | | '_ \ / _ \ 
 | |  | | (_) | |  | | | | | | | | (_| | |  _| (_) | |    | |_| | |_| | | | | (_) |
 |_|  |_|\___/|_|  |_| |_|_|_| |_|\__, | |_|  \___/|_|     \___/ \__,_|_| |_|\___/ 
                                  |___/                                            ";






                Console.WriteLine(title);
                Console.WriteLine("\n\n            Please choose a number below");
                Console.WriteLine("\n          1) Play game          2) Credits             3) Exit Game");

                menuSelect = Convert.ToInt16(Console.ReadLine());
                
                switch (menuSelect)
                {
                    case 1:
                        playGame();
                        break;

                    case 2:
                        credits();
                        break;

                    case 3:
                        exitGame();
                        break;
                }

            }
        }

        public static void playGame()
        {
            Game myGame1 = new Game();

            myGame1.storyChoicesArrays();

            myGame1.userTypoErrors();

            myGame1.firstScenario();
            ///place the star game sequnce.
        }

        public static void credits()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("\n     This game was coded by Leonardo Sanchez");
            Console.WriteLine("       The art was created by Ariely Gonzalez");
            Console.WriteLine("       The story was writen by Ariely Gonzales and improvise by Leonardo Sanchez");//<<<----The story isn't fully done. I just made it straight to the point.
            Console.WriteLine("\n     Press 'Enter' to return to main menu");
            Console.WriteLine("\n-------------------Hopefully you enjoy or enjoyed the game-------------------------------");
            Console.ReadLine();
        }

        public static void exitGame()
        {
            Environment.Exit(0);
        }

        public static void Error()   ///<<<<---------Ask about how to send the user here if they type anything but 1, 2, 3
        {
            Console.Clear();
            Console.WriteLine("\n   Sorry but I didn't understood that. Try again.");
            Console.ReadLine();
        }

    }
}
