using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueueExample;

internal class TaskManager
{
    private Queue<string> taskQueue = new Queue<string>();

    // Enqueue a task to the queue without proper synchronization
    public void EnqueueTask(string task)
    {
        // No explicit synchronization, potential for race conditions
        taskQueue.Enqueue(task);
    }

    // Dequeue and process tasks without proper synchronization
    public void ProcessTasks()
    {
        // Use a separate thread to process tasks
        Task.Run(() =>
        {
            while (true)
            {
                // No explicit synchronization, potential for race conditions

                // Dequeue and process tasks
                while (taskQueue.Count > 0)
                {
                    string task = taskQueue.Dequeue();
                    Console.WriteLine($"Processing task: {task}");
                    
                    // Your task processing logic goes here

                    // Simulate processing interval
                    Thread.Sleep(1000);
                }
            }
        });
    }
}
