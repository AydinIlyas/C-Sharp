using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Table
    {
        int counter1=0;
        int counter2=0;
        public int roundcounter = 0;
        public bool win1 = false;
        public bool win2 = false;
        string player1Win = "Player 1 Won!";
        string player2Win = "Player 2 Won!";
        private string[] numbers = new string[]
            {
                "1","2","3" ,
                "4","5","6" ,
                "7","8","9"
            };

        public string[] Numbers
        {
            get
            {
                return numbers;
            }
            set
            {
                numbers = value;
            }

        }

        public void createTable()
        {
            Console.WriteLine("New Game(R)      End Game(E)");
            Console.WriteLine();
            Console.Write($"       |     |     " +
              $"\n    {numbers[0]}  |  {numbers[1]}  |  {numbers[2]}  " +
              $"\n  _____|_____|_____" +
              $"\n       |     |     " +
              $"\n    {numbers[3]}  |  {numbers[4]}  |  {numbers[5]}  " +
              $"\n  _____|_____|_____" +
              $"\n       |     |     " +
              $"\n    {numbers[6]}  |  {numbers[7]}  |  {numbers[8]}  " +
              $"\n       |     |     ");
            Console.WriteLine();
            Console.WriteLine("Player 1:  {0}     Player 2:  {1}  ",counter1,counter2);
        }

        public void checkWin()
        {
            roundcounter++;
            for (int i = 0; i + 2 < numbers.Length; i += 3)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    
                    if (numbers[i] == "X")
                    {
                        win1 = true; ;
                        ++counter1;
                    }
                    else
                    {
                        win2 = true;
                        ++counter2;
                    }
                    break;
                }
            }
            for (int i = 0; i + 6 < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i + 3] && numbers[i + 3] == numbers[i + 6])
                {
                    
                    if (numbers[i] == "X")
                    {
                        win1 = true;
                        ++counter1;
                    }
                    else
                    {
                        win2 = true;
                        ++counter2;
                    }
                    break;
                }
            }
            if (numbers[0] == numbers[4] && numbers[4] == numbers[8])
            {
               
                if (numbers[0] == "X")
                {
                    win1 = true;
                    ++counter1;
                }
                else
                {
                    win2 = true;
                    ++counter2;
                }

            }
            else if (numbers[2] == numbers[4] && numbers[4] == numbers[6])
            {
               
                if (numbers[2] == "X")
                {
                    win1 = true;
                    ++counter1;
                }
                else
                {
                    win2 = true;
                    ++counter2;
                }
            }
            if (win1||win2)
            {
                if(win1)
                Console.WriteLine(player1Win);
                else
                    Console.WriteLine(player2Win);
                Console.WriteLine("Press a button");
                Console.ReadKey();
            }
        }
        public void restart()
        {
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = Convert.ToString(i+1);   
            }
            Console.Clear();
            createTable();
        }
    }
}

