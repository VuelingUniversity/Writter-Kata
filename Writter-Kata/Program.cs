using System;
using System.Collections.Generic;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Choose what do you want to do
    1. Create directory and files
    2. Format and move files");

            int action;
            Int32.TryParse(Console.ReadLine(), out action);

            Console.WriteLine(@"Where do you want to write?
    1. File
    2. Cloud");
            int option;
            Container container;
            string format;
            string directory;
          
            Int32.TryParse(Console.ReadLine(), out option);
            container = new Container(option);
            Console.WriteLine(@"Choose the format
    json
    txt
    xml
    yml");
            format = Console.ReadLine();
            Console.WriteLine("Write the name of your directory");
            directory = Console.ReadLine();

            if (action == 1)
            {
                bool exit = false;
                List<string> files = new List<string>();
                while (!exit)
                {
                    Console.WriteLine("Write the names of your files. Write exit to end.");
                    var input = Console.ReadLine();
                    if (input == "exit")
                    {
                        exit = true;

                    }
                    else
                    {
                        files.Add(input);
                    }


                }
                container.Factory.GetWritter(format).Write(files, directory);
            }
            else if(action == 2) {
                string target;
               
                Console.WriteLine("Write the path of the target repository");
                target = Console.ReadLine();
                container.Factory.GetWritter(format).FormatAndMove( target, directory);
            }

        }
    }
}
