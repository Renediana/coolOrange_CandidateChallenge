using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class TaskDriver
    {
        static void Main(string[] args)
        {
            Task doingHomework = new Task("Doing Homework");
            Task eatingLunch = new Task("Eating Lunch");
            Task programming = new Task("Programming");

            doingHomework.SetPriority("MAX_PRIORITY");
            doingHomework.SetComplexity(8);

            eatingLunch.SetPriority("MIN_PRIORITY");
            eatingLunch.SetComplexity(2);

            programming.SetComplexity(5);

            List<Task> tasks = new List<Task>()
            {
                doingHomework,
                eatingLunch,
                programming
            };
            Console.WriteLine("TO-DO\n\n---------\n\n");
            foreach (Task t in tasks)
            {
                Console.WriteLine($"{t.Name} priority: {t.GetPriority()} complexity: {t.GetComplexity()}");
            }
            tasks.Sort();
            Console.WriteLine($"\n{tasks[0].Name} is one of the most important tasks");
            Console.ReadKey();
        }
    }
}
