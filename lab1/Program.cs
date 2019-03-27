using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XrestickNolick
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set  
        static int choice; //This holds the choice at which position user want to mark   
        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  
        static int flag = 0;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() 
        {
            int menuItem = 0;
            bool loopMenu = true;
            ConsoleKeyInfo cki;
            while (loopMenu)
            {
                Console.Clear();
                
                Console.WriteLine("[arrows] - навiгацiя, [Enter] - вибiр");
                for (int i = 0; i <12; i++) { Console.WriteLine(" "); }
                Console.ResetColor();
                if (menuItem == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("  Грати    ");
                Console.ResetColor();
                if (menuItem == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("  Правила     ");
                Console.ResetColor();
                if (menuItem == 2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("  Керування     ");
                Console.ResetColor();
                if (menuItem == 3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("  Вихiд            ");
                Console.ResetColor();

                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (menuItem == 0) { menuItem = 3; } else { menuItem--; }
                        break;
                    case ConsoleKey.DownArrow:
                        if (menuItem == 3) { menuItem = 0; } else { menuItem++; }
                        break;
                    case ConsoleKey.Enter:
                        switch (menuItem)
                        {
                            case 1://Rules
                                Rules();
                                break;
                            case 2://Control
                                Control();
                                break;
                            case 3://exit button
                                loopMenu = false;
                                break;
                            default://select level button
                                player = 1;
                                for (int i = 1; i < 9; i++)
                                    arr[i] = i.ToString().ToCharArray()[0];
                                Play();
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static void Rules()
        {
            bool loopMenu = true;
            ConsoleKeyInfo cki;
            while (loopMenu)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("          Правила                                                          ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("   1. Перший гравець грає за \"X\"."); 
                Console.WriteLine("   2. Гравцi ходять по черзi.");
                Console.WriteLine("   3. Ставити знаки можна лише на вiльнi клiтинки.");
                Console.WriteLine("   4. Гравець, який розмiщає 3 значки в ряд перемагає, iнакше нiчия.");
                Console.WriteLine("   5. Ряд може бути горизонтальним, вертикальним, дiагональним.");
                Console.WriteLine();
                Console.WriteLine("Натиснiть [Escape] щоб повернутися до меню");
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.Escape:
                        loopMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void Control() 
        {
            bool loopMenu = true;
            ConsoleKeyInfo cki;
            while (loopMenu)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("          Керування                                                          ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("   1. Натискайте цифру, що вiдповiдає клiтинцi, в яку хочете поставити знак.");
                Console.WriteLine("   2. Передайте керування iншому гравцевi.");
                Console.WriteLine();
                Console.WriteLine("Натиснiть [Escape] щоб повернутися до меню");
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.Escape:
                        loopMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
        static void Play()
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear  
                Console.WriteLine("Гравець 1:X Гравець 2:O");
                Console.WriteLine("Натискайте клавiшi вiд 1 до 9, щоб поставити свiй значок в клiтинку");
                Console.WriteLine("Натиснiть [Escape] щоб повернутись до меню");
                if (player % 2 == 0)//checking the chance of the player  
                {
                    Console.WriteLine("Хiд 2 гравця");
                }
                else
                {
                    Console.WriteLine("Хiд 1 гравця");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function
                bool isdigit = false;
                ConsoleKey keypress;

                while (!isdigit)
                {
                    keypress = Console.ReadKey(true).Key;
                    if (keypress == ConsoleKey.Escape)
                    {
                        Menu();
                    }
                    else
                    {
                        string str = keypress.ToString();
                        string number = str.Substring(str.Length-1);
                        isdigit = Int32.TryParse(number, out choice);
                        if (!isdigit) { Console.WriteLine("Вводьте тiльки цифри вiд 1 до 9"); }
                    }
                }
                //choice = int.Parse(Console.ReadLine());
                if (choice > 9 | choice < 1)
                {
                    Console.WriteLine("Вводьте числа вiд 1 до 9");
                    Thread.Sleep(750);
                }
                else if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already marked then show message and load board again  
                {
                    Console.WriteLine("{0} клiтинка вже зайнята {1}", choice, arr[choice]);
                    Thread.Sleep(750);
                }
                flag = CheckWin();// calling of check win  
            } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  
            Console.Clear();// clearing the console  
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Board();// getting filled board again  
            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                Console.WriteLine("Перемiг {0} гравець", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                Console.WriteLine("Нiчия");
            }
            Console.WriteLine("Натиснiть [Enter] почати спочатку або будь-яку iншу клавiшу, щоб повернутися до меню");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    Menu();
                    break;
                case ConsoleKey.Enter:
                    player = 1;
                    for (int i = 1; i < 9; i++)
                        arr[i] = i.ToString().ToCharArray()[0];
                    Play();
                    break;
                default:
                    break;
            }
        }


        static void Board()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not  

        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row   
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row   
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column       
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }

            #endregion
            else
            {
                return 0;
            }
        }
    }
}
