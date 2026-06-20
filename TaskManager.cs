using System;

public class TaskManager
{
    public Dictionary<int, Task> TaskMan = new Dictionary<int, Task>();
    public Stack<Task> historyStack = new Stack<Task>();
    Task[] tasksArray = new Task[TaskMan.Count];

    public Task GetTask(int TaskId)
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
    public void PrintAllSorted()
    {
        int index = 0;

        foreach (Task currentTask in TaskMan.Values)
        {
            tasksArray[index] = currentTask; 
            index++;
        }

       Array.Sort(tasksArray)

        foreach (var t in tasksArray)
        {
            Console.WriteLine(t.ToString());
        }

        
            
       





    }

