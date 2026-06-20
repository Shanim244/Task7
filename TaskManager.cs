using System;

public class TaskManager
{
    public Dictionary<int, Task> TaskMan = new Dictionary<int, Task>();
    public Stack<Task> historyStack = new Stack<Task>();

    public TaskManager GetTask(int TaskId)
    {
        if (TaskMan.ContainsKey(TaskId))
        {
            Task t = TaskMan[TaskId];
            return t;
        }
        return null;
    }

    public void AddTask(Task newTask)
    {
        TaskMan.Add(newTask.TaskId, newTask);
    }
}

