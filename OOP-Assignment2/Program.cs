using OOP_Assignment2.Modul;

namespace OOP_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************** Ticket_Booking *******************");

            TicketSystem system = new TicketSystem();

            system.AddTicket(new Ticket_Booking("Movie", "A12", TicketType.Regular ));
            system.AddTicket(new Ticket_Booking("Movie", "A02", TicketType.VIP));
            system.AddTicket(new Ticket_Booking("Movie", "B22", TicketType.BackStage));

            Console.WriteLine("--- Accessing ticket by seat number ---");
            Console.WriteLine(system["A12"]);
            Console.WriteLine(system["A02"]);
            Console.WriteLine(system["B22"]);

            Console.WriteLine("--- Ticket count by Type ---");
            var counts = system.CountTicketByType();

            foreach(var count in counts)
            {
                Console.WriteLine($"{count.Key}: {count.Value}");
            }

            Console.WriteLine("********************** Course_Enrollment *****************");


            CourseCatalog CC = new CourseCatalog();
            CC.AddCourse(new VideoCourse("Math", "Fahad", Level.Begginer, 30));
            CC.AddCourse(new Course_Enrollment("Arabic", "Ali", Level.Advanced));
            CC.AddCourse(new LiveSession("English", "Fayadh", Level.Intermediate, "12/5 | 2:00 PM"));

            foreach (Level level in Enum.GetValues(typeof(Level)))
            {
                Console.WriteLine($"\n--- {level} Courses ---");

                List<Course_Enrollment> levelCourses = CC[level];

                if (levelCourses.Count == 0)
                {
                    Console.WriteLine("No courses found at this level.");
                    continue;
                }

                foreach (Course_Enrollment course in levelCourses)
                {
                    Console.WriteLine($"Course: {course.Name} | Instructor: {course.Instructor}");

                    if (course is VideoCourse video)
                    {
                        Console.WriteLine($"Type: Video Course | Duration: {video.Duration} hours");
                    }
                    else if (course is LiveSession live)
                    {
                        Console.WriteLine($"Type: Live Session | Schedule: {live.DateTime}");
                    }

                }

            }
            Console.WriteLine("*********************** Smart_Home ****************");

            SmartHome home = new SmartHome();

            home[DeviceType.Light].TurnOn();
            home[DeviceType.Fan].TurnOn();
            home[DeviceType.AC].TurnOff();
            

            Console.WriteLine("--- Device Status ---");
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.Fan].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();

            Console.WriteLine("********************** Library_System *****************");

            Library library = new Library();

            library.AddBook(new Book("Nomouth and I Must Scream", "Harlan Ellison"));
            library.AddBook(new Book("Blood Meridian", "Cormac McCarthy"));
            library.AddBook(new Book("All Tomorrow", "C.M. Kösemen"));
            library.AddBook(new Book("Man After Man", "Dougal Dixon"));
            library.AddBook(new Book("Moby Dick", "Herman Melville"));

            Console.WriteLine("\nAccessing book '1984':");
            Console.WriteLine(library["1984"]);

            library.ChangeStatus("1984", BookStatus.CheckedOut);
            library.ChangeStatus("Moby Dick", BookStatus.Reserved);

            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.Available);
            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.CheckedOut);
            Console.WriteLine();
            library.ShowBooksByStatus(BookStatus.Reserved);

            Console.WriteLine("************************* Task_Tracker **************");

            TaskList taskList = new TaskList();

            
            taskList.AddTask(new Task_Track("Finish Assignment", "Complete C# assignment OOP2", TaskPriority.High));
            taskList.AddTask(new Task_Track("Grocery Shopping", "Buy vegetables and fruits", TaskPriority.Medium));
            taskList.AddTask(new Task_Track("Workout", "30 mins morning exercise", TaskPriority.Low));
            taskList.AddTask(new Task_Track("Read Book", "Read 'Clean Code'", TaskPriority.Medium));

            taskList.ShowAll();
            Console.WriteLine();

            Console.WriteLine("High Priority Tasks:");
            foreach (var task in taskList[TaskPriority.High])
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            taskList.MarkComplete("Workout");
            Console.WriteLine();

            taskList.ShowAll();
        }

    }
    }
