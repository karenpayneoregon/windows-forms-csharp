using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int _pause = 2000;
        static async Task Main(string[] args)
        {
            Console.Title = "Music for the mood";
            
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press ESC to stop");
                Console.ResetColor();
                Console.WriteLine();
                await DoWork();
            }
        }

        private static async Task DoWork()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MUSIC FOR THE MOOD");
            Console.WriteLine("What vibe of music do you want to feel? \n a) Chilled-out \n b) HARD BOP \n c) Grandiose");
            Console.ResetColor();
            Console.WriteLine();
            
            ConsoleKeyInfo result = Console.ReadKey(true);

            if (result.Key == ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("adiós");
                await Task.Delay(_pause);
                Environment.Exit(0);
            }

            string input = result.KeyChar.ToString().ToLower();
            
            
            switch (input.ToLower())
            {
                case "a":
                    Console.WriteLine("The creator of this program made some music like that. You wanna listen? (Y/N)");
                    string inputa = Console.ReadLine();
                    
                    switch (inputa)
                    {
                        case var x when string.Equals(inputa, "Y", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Well, then, check out AMJOJC on Bandlab! He's made some chill pop songs before!");
                            await Task.Delay(_pause);
                            break;
                        case var x when string.Equals(inputa, "N", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Then check out Chillhop! You can just head to the main page of your account and start playing an infinite playlist of lofi hip-hop!");
                            await Task.Delay(_pause);
                            break;
                    }

                    break;
                case "b":
                    Console.WriteLine("Electronic? (Y/N)");
                    string inputb = Console.ReadLine();
                    
                    switch (inputb.ToLower())
                    {
                        case var x when string.Equals(inputb, "Y", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Funk Level? (Negative/None/High/CHONK)");
                            string inputby = Console.ReadLine(); 
                            switch (inputby)
                            {
                                case var name when string.Equals(inputby, "Negative", StringComparison.InvariantCultureIgnoreCase):
                                    Console.WriteLine("Then HARDCORE TANO*C is for you! They make hyper-hardcore electronic music!");
                                    await Task.Delay(_pause);
                                    break;
                                case var name when string.Equals(inputby, "None", StringComparison.InvariantCultureIgnoreCase):
                                    Console.WriteLine("The MAX DDR Collection will do you good if you just want simple bops. Listen to it!");
                                    await Task.Delay(_pause);
                                    break;
                                case var name when string.Equals(inputby, "High", StringComparison.InvariantCultureIgnoreCase):
                                    Console.WriteLine("The PARANOiA DDR Collection would definitely suit you and others who want bouncy funky bops right now. Try it out!");
                                    await Task.Delay(_pause);
                                    break;
                                case var name when string.Equals(inputby, "CHONK", StringComparison.InvariantCultureIgnoreCase):
                                    Console.WriteLine("Have you heard of KNOWER? They make super funk bombs that humans instinctively rave to. Come on and see!");
                                    await Task.Delay(_pause);
                                    break;
                                default:
                                    Console.WriteLine("Say what?");
                                    await Task.Delay(_pause);
                                    break;
                            }

                            break;
                        case var x when string.Equals(inputb, "N", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Then listen to Thank You Scientist. They make nice Prog Rock.");
                            await Task.Delay(_pause);
                            break;
                    }

                    break;
                case "c":
                    
                    
                    Console.Write("(");
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("O");
                    Console.ResetColor();

                    Console.Write(")ld or (");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("N");
                    Console.ResetColor();

                    Console.Write(")ew classical?\n");
                    
                    
                    string inputc = Console.ReadLine();
                    
                    switch (inputc)
                    {
                        case var name when string.Equals(inputc, "o", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Listen to Percy Grainger then! He's a composer from the late 19th / early 20th century who composes in sometimes classical, sometimes romantic style.");
                            await Task.Delay(_pause);
                            break;
                        case var name when string.Equals(inputc, "n", StringComparison.InvariantCultureIgnoreCase):
                            Console.WriteLine("Then you can listen to Christopher Cerrone! He's a contemporary composer who sometimes utilises surrealist poetry as the lyrics of his pieces. His instrumental pieces also give off some of the grandest feelings you'll experience!");
                            await Task.Delay(_pause);
                            break;
                    }

                    break;
            }
        }
    }
}

