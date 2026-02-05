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
            }
        }
    }
}
