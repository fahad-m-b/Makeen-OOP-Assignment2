using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2.Modul
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public class Task_Track
    {
        public Task_Track(string title, string description, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nPriority: {Priority}\nCompleted: {IsCompleted}\n----------";
        }
    }
    public class TaskList
    {
        public TaskList()
        {
            Tasks = new List<Task_Track>();
        }

        public List<Task_Track> Tasks { get; set; }
        public List<Task_Track> this[TaskPriority priority]
        {
            get { return Tasks.Where(t => t.Priority == priority).ToList(); }
        }
        public void AddTask(Task_Track task)
        {
            Tasks.Add(task);
        }
        public void MarkComplete(string completeTask)
        {
            Task_Track task = Tasks.Find(t => t.Title.Equals(completeTask));
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"Task:{completeTask} Is Completed now");
            }
            else
            {
                Console.WriteLine($"No task with the name:{completeTask}");
            }
        }
        public void ShowAll()
        {
            Console.WriteLine("All Tasks:");
            foreach(var task in Tasks)
            {
                Console.WriteLine($"*{task}");
            }
        }

    }
}
