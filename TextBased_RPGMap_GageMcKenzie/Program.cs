using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBased_RPGMap_GageMcKenzie
{

    internal class Program
    {
        static int placeHolder = 0;
        
        static char[] border = new char[]
        {
            '-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-'
        };
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`',},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`',},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`',},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`',},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`',},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`',},
        
    };
        static void Main(string[] args)
        {
            Display(1);
            
            
        }

        static void Display(int scale =1)
        {
            if (scale == 1) 
            {
                Console.Write(border);
                placeHolder += 1;
                Console.SetCursorPosition(0, placeHolder);
                for (int i = 0; i < map.GetLength(0); i++)
                {



                    for (int j = 0; j < map.GetLength(1); j++)
                    {


                        if (j == 0)
                        {
                            Console.SetCursorPosition(0, placeHolder);
                            
                            placeHolder += 1;
                            Console.Write('|');
                        }
                        if (map[i,j]== '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            
                        }


                    }
                    Console.Write('|');

                }
                Console.WriteLine(' ');
                Console.Write(border);
            }
            if (scale == 2)
            {
                Console.Write(border);
                Console.Write(border);
                placeHolder += 1;
                Console.SetCursorPosition(0, placeHolder);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {


                        if (j == 0)
                        {
                            
                            Console.SetCursorPosition(0, placeHolder);
                            
                            placeHolder += 1;
                            Console.Write('|');
                        }

                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);

                        }



                    }
                    Console.Write('|');
                    for (int j = 0; j < map.GetLength(1); j++)
                    {


                        if (j == 0)
                        {
                            Console.SetCursorPosition(0, placeHolder);
                            Console.Write('|');
                            placeHolder += 1;

                        }

                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);

                        }


                    }

                    Console.Write('|');
                }
                
                Console.SetCursorPosition(0, placeHolder);
                Console.Write(border);
                Console.Write(border);
                
            }
            if (scale == 3)
            {
                Console.Write(border);
                Console.Write(border);
                Console.Write(border);
                placeHolder += 1;
                Console.SetCursorPosition(0, placeHolder);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        

                        if (j == 0)
                        {
                            Console.SetCursorPosition(0, placeHolder);
                             
                            placeHolder += 1;
                            Console.Write('|');
                        }

                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);

                        }


                    }
                    Console.Write('|');
                    for (int j = 0; j < map.GetLength(1); j++)
                    {


                        if (j == 0)
                        {
                            Console.SetCursorPosition(0, placeHolder);

                            placeHolder += 1;
                            Console.Write('|');
                        }

                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);

                        }


                    }
                    Console.Write('|');
                    for (int j = 0; j < map.GetLength(1); j++)
                    {


                        if (j == 0)
                        {
                            Console.SetCursorPosition(0, placeHolder);

                            placeHolder += 1;
                            Console.Write('|');
                        }

                        if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);
                            Console.Write(map[i, j]);

                        }


                    }
                    Console.Write('|');
                }
                Console.SetCursorPosition(0, placeHolder);
                Console.Write(border);
                Console.Write(border);
                Console.Write(border);
            }

            if (scale > 3)
            {
                Console.WriteLine("incorrect scale");
            }
        }

        
    }
}
