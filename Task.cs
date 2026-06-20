using System;



public class Task : IComparable
{
    // Shani Maroz
    // 211579263

    // Task properties
    public int TaskId { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    // Constructor to initialize a new task
    public Task(int taskId, string d,int p)
    {
        TaskId = taskId; 
        Description = d; 
        Priority = p;
    }

    // Compares tasks by Priority
    public int CompareTo(object obj)
    {
        Task t = (Task)obj;

        if (Priority < t.Priority)
        {
            return -1;
        }
        if (Priority > t.Priority)
        {
            return 1;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"ID: {TaskId}, Description: {Description}, Priority: {Priority}";
    }


}
