namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int taskNumber = 1;

            do
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }
            while (taskNumber <= 5 && taskNumber > 0);


        }
    }
}
