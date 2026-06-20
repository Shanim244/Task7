using System;



public class Task : IComparable
{
    public int TaskId { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    public Task(int taskId, string d,int p)
    {
        TaskId = taskId; 
        Description = d; 
        Priority = p;
    }


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


}
