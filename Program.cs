namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int taskNumber = 1;

            while (taskNumber <= 5 && taskNumber > 0) {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }
            

            
            int attempt = 1;
            //this works at least once because thats what a do while loop does. do x. and then try and manipulate stuff IF it meets the requirements to be manipulated. like imagine in a game do health = 100 because you spawned in. while health is under 25, show that youre close to death, or weapon reload whatever it may be
            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            } while ( attempt <= 3);


            for( int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Step {i}");
            }


            int number = 0;

            while (number <= 6)
            {
                number++;
                if (number == 4)
                {
                    //continue basically says hey, you found 4. do nothing with 4.
                    continue;
                }
                if (number == 6)
                {
                    //break says hey, you found 6. this is the "off" button. turn off.
                    break;
                }

                Console.WriteLine(number);


                /*
                 * I think the easiest loop for me to understand is for loops, since i think I have the most experience.
                 * I do think While and doWhile loops are very useful, i just dont know many uses since i havent done it first hand yet.
                 * 
                 * 
                 * I think the number that was the hardest to 'trace' would probably be the For loops, since you have to understand that you are doing 3 things at once. initialize a counter, say the parameter that it runs, and how to increment the counter all in one little ()
                 * 
                 *comment helpp because it helps to understand why a break or a continue has different things it does.
                 */
            }
        }
    }
}
