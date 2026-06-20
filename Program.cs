namespace Task7
{
    internal class Program
    {
        // Shani Maroz
        // 211579263

        static void Main(string[] args)
        {
            TaskManager t = new TaskManager();

            //AddTask
            Console.WriteLine("Please enter the TaskId");
            int TaskId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Description");
            string Description = Console.ReadLine();
            Console.WriteLine("Please enter the priority");
            int Priority = int.Parse(Console.ReadLine());

            Task newTask = new Task(TaskId, Description, Priority);
            t.AddTask(newTask);

            //RemoveTask
            Console.WriteLine("which task would you like to remove? ");
            int Taskid = int.Parse(Console.ReadLine());
            t.RemoveTask(Taskid);

            //UndoRemoveTask
            t.UndoRemove();

        }
    }
}
