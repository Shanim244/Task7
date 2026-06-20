namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager t = new TaskManager();

            //AddFunction
            Console.WriteLine("Please enter the TaskId");
            int TaskId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Description");
            string Description = Console.ReadLine();
            Console.WriteLine("Please enter the priority");
            int Priority = int.Parse(Console.ReadLine());

            Task newTask = new Task() { TaskId = TaskId, Description = Description, Priority = Priority };
            t.AddTask(newTask);

        }
    }
}
