using System;

public class TaskManager
{
    // Shani Maroz
    // 211579263

    public Dictionary<int, Task> TaskMan = new Dictionary<int, Task>();
    public Stack<Task> historyStack = new Stack<Task>();

    // Retrieves a task by its ID
    public Task GetTask(int TaskId)
    {
        if (TaskMan.ContainsKey(TaskId))
        {
            Task t = TaskMan[TaskId];
            return t;
        }
        return null;
    }

    // Adds a new task
    public void AddTask(Task newTask)
    {
        TaskMan.Add(newTask.TaskId, newTask);
    }

    // Removes a task and saves it to the history stack
    public void RemoveTask(int TaskId)
    {
        int saveId = 0;

        if (TaskMan.ContainsKey(TaskId))
        {
            Task savedTask = TaskMan[TaskId];
            historyStack.Push(savedTask);
            TaskMan.Remove(TaskId);
        }

        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    // Restores the last removed task from the history stack
    public void UndoRemove()
    {
        if (historyStack.Count > 0)
        {
            Task SaveTask = historyStack.Pop();
            TaskMan.Add(SaveTask.TaskId, SaveTask);
        }
        else
        {
            Console.WriteLine("History is empty, nothing to undo.");
        }
    }

    // Copies tasks, sorts and prints
    public void PrintAllSorted()
    {
        Task[] tasksArray = new Task[TaskMan.Count];
        int index = 0;

        foreach (Task currentTask in TaskMan.Values)
        {
            tasksArray[index] = currentTask;
            index++;
        }

        Array.Sort(tasksArray);

        foreach (var t in tasksArray)
        {
            Console.WriteLine(t.ToString());
        }

    }
}
