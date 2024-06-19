
namespace Mango.ConsoleApp
{
    public class Program
    {
        private static readonly string[] MangoOptions = { "EWAS Mango", "KET&KENT Mango", "ZEBDYA Mango", "SOKARY Mango", "NA3OMY Mango" };
        private static readonly string[] CupSizes = { "Small", "Medium", "Large" };

        public static async Task Main(string[] args)
        {
            Console.Title = "MangoMachine";
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mangoArt = @"
 _ __ ___   __ _ _ __   __ _  ___  
| '_ ` _ \ / _` | '_ \ / _` |/ _ \ 
| | | | | | (_| | | | | (_| | (_) |
|_| |_| |_|\__,_|_| |_|\__, |\___/ 
                        __/ |      
                       |___/ ";

            string sofco = @"
   _____  ____  ______ _____ ____  
  / ____|/ __ \|  ____/ ____/ __ \ 
 | (___ | |  | | |__ | |   | |  | |
  \___ \| |  | |  __|| |   | |  | |
  ____) | |__| | |   | |___| |__| |
 |_____/ \____/|_|    \_____\____/ 
                                   
                                   ";


            Console.WriteLine($"\t\t\t\t\t\t{mangoArt}");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tTouch Screen Is Under Maintenance Right Now! Be a Normal Guys And Use Your Keyboard");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            await Task.Delay(1000);
            Console.WriteLine("Loading Please Wait ...\n");
            await Task.Delay(5000);
            Console.WriteLine("Welcome To SoFco's Free Mango Machine");
            Console.WriteLine("--------------------------------------");
            


            int userInput;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter a number between 1 and 5:");
                Console.WriteLine("1.EWAS Mango");
                Console.WriteLine("2.KET&KENT Mango");
                Console.WriteLine("3.ZEBDYA Mango");
                Console.WriteLine("4.SOKARY Mango");
                Console.WriteLine("5.NA3OMY Mango");
                Console.Write("Your choice: ");

                
                if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 5)
                {
                    Console.WriteLine("\nnaaaaaaaaaaah. Thats Wrong Bro Enter number between 1-5.");
                }

            } while (userInput < 1 || userInput > 5);


            int chosenMangoIndex = userInput - 1;
            string chosenMangoType = MangoOptions[chosenMangoIndex];


            int cupSize;
            do
            {
                await Task.Delay(100);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Select your cup size:");
                Console.WriteLine("1.Small");
                Console.WriteLine("2.Medium");
                Console.WriteLine("3.Large");
                Console.Write("Your choice: ");

                if (!int.TryParse(Console.ReadLine(), out cupSize) || cupSize < 1 || cupSize > 3)
                {
                    Console.WriteLine("\nYou Again!!!. enter a number between 1 and 3.");
                }

            } while (cupSize < 1 || cupSize > 3);


            int chosenCupSizeIndex = cupSize - 1;
            string chosenCupSize = CupSizes[chosenCupSizeIndex];

            Console.ForegroundColor = ConsoleColor.DarkYellow;   
            Console.WriteLine("\nDont Worry Its Completely Free You will Not pay Anything \nBut If You Are a Good Person You Can Support Me\nInstaPay: adhamfahmy@instapay");
                                                            
            await Task.Delay(3000);
            Console.Write($"\nDispensing your {chosenMangoType}");
            await Dispensing();

            Console.WriteLine($"\nYour {chosenMangoType} in a {chosenCupSize} Cup is ready Enjoy!");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine(sofco);


            static async Task Dispensing()
            {
                string[] animations = { ".", ".", ".", ".", ".", ".","." };
                int animationIndex = 0;

                for (int i = 0; i < 7; i++)
                {
                    Console.Write(animations[animationIndex]);
                    await Task.Delay(500);
                    animationIndex++;
                }

                
            }
            
            await Task.Delay(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tTake Your Cup And Go Away");
            await Task.Delay(6000);


        }
    }
}
