using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1 = "X";
            string player2 = "O";
            string marker;
            string input;
            int correct;
            bool error;
            bool work = true;
            Table table = new Table();
            table.createTable();


            while(work)
            {
                

                if (table.roundcounter % 2 == 0)
                {
                    Console.Write("\nPlayer 1 (X) Choose a field!   ");
                    marker = player1;
                }
                else
                {
                    Console.Write("\nPlayer 2 (O) Choose a field!   ");
                    marker = player2;
                }
                
                
                do
                {
                    error = true;
                    input = Console.ReadLine().ToUpper();
                    
                    if (input == "R")
                    {
                        error = false;
                        continue;
                    }
                    if (input == "E")
                    {
                        error = false;
                        work = false;
                        continue;
                    }
                    if (!int.TryParse(input, out correct) || correct < 1 || correct > 9)
                    {
                        Console.WriteLine("It should be a number between 1 and 9!");
                    }
                    if(int.TryParse(input, out correct)&&correct>=1&&correct<=9)
                    {
                        if (table.Numbers[correct-1] != "X" && table.Numbers[correct-1] != "O")
                        {
                            error = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter another number");
                            
                        }
                        
                    }
                    
                } while (error) ;
                switch (input)
                {
                    case "1":
                        table.Numbers[0] = marker;

                        break;
                    case "2":
                        table.Numbers[1] = marker;

                        break;
                    case "3":
                        table.Numbers[2] = marker;

                        break;
                    case "4":
                        table.Numbers[3] = marker;
                        break;
                    case "5":
                        table.Numbers[4] = marker;

                        break;
                    case "6":
                        table.Numbers[5] = marker;

                        break;
                    case "7":
                        table.Numbers[6] = marker;

                        break;
                    case "8":
                        table.Numbers[7] = marker;

                        break;
                    case "9":
                        table.Numbers[8] = marker;

                        break;
                    default:
                        Console.WriteLine("Tebrikler basardiniz.");
                        break;
                }
                
                Console.Clear();
                table.createTable();
                table.checkWin();
                if(table.win1||table.win2||input=="R")
                {
                    
                    table.win1 = false;
                    table.win2 = false;
                    //table.roundcounter = 0;
                    table.restart();
                }
                else if (input != "R" && table.roundcounter == 9)
                {
                    Console.WriteLine("It is a draw");
                    //table.roundcounter = 0;
                    Console.WriteLine("Press a button");
                    Console.ReadKey();
                    table.restart();
                }
            }
        }

    }
}
