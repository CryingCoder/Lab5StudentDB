using System.Security.Cryptography.X509Certificates;

namespace Lab5StudentDB
{
    internal class Program
    {

        //MAIN METHOD
        static void Main(string[] args)
        {

            //ARRAYS REQUESTED FOR PROGRAM
            string[] names = new string[9] { "1.Charlotte", "2.Assumpcao", "3.JellyBean", "4.Dracula", "5.Ronan", "6.Tina", "7.Gordon", "8.Torian", "9.Elohim" };
            string[] hometown = new string[9] { "Nashville", "Rio De Janeiro", "the Grocery Store", "Transylvania", "Tokyo", "Preston", "a Blackhole", "the Forest", "Elven woods" };
            string[] favFood = new string[9] { "BBQ", "churasco", "Jellybeans", "...you already know", "Sushi", "Chimi Changas", "negative energy", "field rabbits", "beans" };

            
            //int index = Array.BinarySearch(names, "JellyBean");
            //Console.WriteLine(index);


            
            //INITIAL MESSAGE
            Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-9 or Enter 0 to see a list of all students:");
            bool checkAnother = true;
            //MAIN LOOP TO REPEAT CHECKING STUDENTS IN ARRAY
            while (checkAnother)
            {

                //PROMPT THE USER FOR INPUT
                string input = Console.ReadLine();
                int studentNumber = int.Parse(input);


                //ASK TO PRINT WHOLE ARRAY OR SELECT A SPECIFIC NUMBER
                if (studentNumber == 0)
                {
                    Console.WriteLine("Here's a list of all the Students I know!");
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    //CONFIRM THE NUMBER PROVIDED IS WITHIN THE RANGE
                    if (studentNumber < 1 || studentNumber > names.Length)
                    {
                        Console.WriteLine("Invalid number provided");
                        continue;
                    }

                    //LOOP TO CHECK IF USER INPUT IS WITHIN SCOPE
                    bool tryAgain = true;
                    while (tryAgain)
                    {

                        //OUTPUT THE NAME OF STUDENT AND ASK IF THEY WANT TO KNOW MORE - CONVERT RESPONSE TO VARIABLE
                        Console.WriteLine($"Student " + input + " is " + (names[studentNumber - 1]) + " What would you like to know? Enter \"hometown\" or \"favorite food\":");
                        string userInput = Console.ReadLine().ToLower();

                        //IF LOOP TO DETERMINE WHICH ARRAY WILL BE CALLED ON SECOND PROMPT (i.e "hometwown" or "Favorite Food")
                        if (userInput == "hometown" || userInput == "town" || userInput == "home")
                        {
                            //OUTPUT THE STUDENTS HOMETOWN
                            int studentHome = studentNumber;
                            Console.WriteLine((names[studentNumber - 1]) + " is from " + hometown[studentHome - 1]);
                            tryAgain = false;

                        }
                        else if (userInput == "food" || userInput == "favorite food")
                        {
                            //OUTPUT THE STUDENTS FAVORITE FOOD
                            int studentFood = studentNumber;
                            Console.WriteLine((names[studentNumber - 1]) + "'s favorite food happens to be " + favFood[studentFood - 1]);
                            tryAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("I didn't get that. Please enter \"hometown\" or \"favorite food\":");
                            continue;
                        }
                    }
                }
                
                //GO BACK TO WHILE LOOP AT THE VERY TOP
                checkAnother = AskToContinue();
            }
        }
       
        
        //RETRY METHOD
        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to learn more? Y/N");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine("Enter a different student ID between 1 and 9");
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again.");
                return AskToContinue();
            }
        }
    }
}