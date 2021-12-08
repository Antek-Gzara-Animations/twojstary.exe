using System;
using static System.Console;

namespace twojstary
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput = "";

            SetCursorPosition(0, 21);
            Write("\n\n<< Mam dla ciebie bojowe zadanie!\n>>");

            while (true)
            {
                Clear();
                setColor(ConsoleColor.White);

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        Write("#");
                    }
                    Write('\n');
                }

                drawHead();

                butelka(36, 5);

                SetCursorPosition(0, 21);

                colorNormal();

                Write("\n\n>>");
                
                UserInput = ReadLine();
                if(UserInput == "quit" || UserInput == "wyjdz")
                {
                    break;
                }
                else if(UserInput == "help" || UserInput == "pomoc")
                {
                    Write("\n-quit\t\t-\t\twyjdz\nTwoj Stary:\n\tt-wojstary -r\t\t-\t\trozmawiaj\n\t-twojstary -q\t\t-\t\twyjdz\n\nenter aby zamknac...");
                    
                    ReadLine();
                }
                else if(UserInput.Length > 11 && UserInput.Substring(0,9) == "twojstary")
                {
                    if(UserInput.Substring(10) == "-r")
                    {
                        WriteLine("<< (gloz w twojej glowie): nie chcialo mi sie tego robic xD");
                        ReadLine();
                    }
                    else if(UserInput.Substring(10) == "-q")
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("<< (glos w twojej glowie): zla komenda");
                        ReadLine();
                    }
                }
                else
                {
                    WriteLine("<< (glos w twojej glowie): zla komenda, napisz \"help\" aby zobaczyc komendy");
                    ReadLine();
                }
            }

            

            WriteLine("\n\ntwojstary.exe has poszedl srac");
            
        }

        static void setColor(ConsoleColor color)
        {
            BackgroundColor = color;
            ForegroundColor = color;
        }

        static void colorNormal()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }

        static void drawHead()
        {
            setColor(ConsoleColor.DarkYellow);

            SetCursorPosition(10, 5);

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Write("#");
                }
                SetCursorPosition(10, 5 + i);
            }

            SetCursorPosition(17, 14);
            Write("####");

            setColor(ConsoleColor.Gray);
            SetCursorPosition(15, 10);
            Write("##########");

            setColor(ConsoleColor.Black);
            SetCursorPosition(17, 11);
            Write("#####");
            SetCursorPosition(17, 12);
            Write('#');
            SetCursorPosition(21, 12);
            Write('#');

            SetCursorPosition(15, 7);
            Write('#');
            SetCursorPosition(23, 7);
            Write('#');

            setColor(ConsoleColor.Gray);
            SetCursorPosition(14, 6);
            Write("###");
            SetCursorPosition(22, 6);
            Write("###");
        }

        static void butelka(int x, int y)
        {
            setColor(ConsoleColor.DarkRed);

            SetCursorPosition(x-2, y);
            Write("#####");

            SetCursorPosition(x-1, y+1);
            Write("###");
            SetCursorPosition(x - 1, y + 2);
            Write("###");
            SetCursorPosition(x - 1, y + 3);
            Write("###");

            SetCursorPosition(x - 2, y + 4);
            Write("#####");
            SetCursorPosition(x - 2, y + 5);
            Write("#####");
            SetCursorPosition(x - 2, y + 6);
            Write("#####");
            SetCursorPosition(x - 2, y + 7);
            Write("#####");
            hand(x, y + 7);
            setColor(ConsoleColor.DarkRed);
            SetCursorPosition(x - 2, y + 8);
            Write("#####");
            SetCursorPosition(x - 2, y + 9);
            Write("#####");
            SetCursorPosition(x - 2, y + 10);
            Write("#####");
        }

        static void hand(int x, int y)
        {
            setColor(ConsoleColor.DarkYellow); 

            SetCursorPosition(x-5, y);
            Write("#########");
            SetCursorPosition(x - 5, y + 1);
            Write("#########");
            SetCursorPosition(x - 5, y + 1);
            Write("#########");
            SetCursorPosition(x - 5, y + 1);
            Write("#########");

            setColor(ConsoleColor.DarkGreen);

            SetCursorPosition(x - 6, y );
            Write("###");
            SetCursorPosition(x - 6, y + 1);
            Write("###");
            SetCursorPosition(x - 6, y + 2);
            Write("###");
            SetCursorPosition(x - 26, y + 3);
            Write("#######################");
            SetCursorPosition(x - 26, y + 4);
            Write("#######################");
            SetCursorPosition(x - 26, y + 5);
            Write("####################");
            SetCursorPosition(x - 26, y + 6);
            Write("####################");
            SetCursorPosition(x - 26, y + 7);
            Write("####################");
            SetCursorPosition(x - 31, y + 3);
            Write("#####");
            SetCursorPosition(x - 31, y + 4);
            Write("#####");
            SetCursorPosition(x - 31, y + 5);
            Write("###");
            SetCursorPosition(x - 31, y + 6);
            Write("###");

            setColor(ConsoleColor.DarkYellow);

            SetCursorPosition(x - 31, y + 7);
            Write("###");
        }
    }
}
