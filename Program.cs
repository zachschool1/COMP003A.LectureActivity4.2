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
            


        }
    }
}
