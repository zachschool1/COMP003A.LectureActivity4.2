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
            } while ( attempt <= 3);

        }
    }
}
