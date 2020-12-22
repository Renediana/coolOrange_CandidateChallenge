using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class Task : IPriority, IComplexity, IComparable<Task>
    {
        public Task(string name)
        {
            Name = name;
            Priority = "MID_PRIORITY";
        }

        public string Name { get; private set; }
        private string Priority { get; set; }
        private int Complexity { get; set; }

        public int CompareTo(Task task)
        {
            return this.Priority.CompareTo(task.Priority);
        }

        public int GetComplexity()
        {
            return this.Complexity;
        }

        public int GetPriority()
        {
            switch (this.Priority)
            {
                case "MIN_PRIORITY":
                    return 1;
                case "MED_PRIORITY":
                    return 5;
                case "MAX_PRIORITY":
                    return 10;
            }
            return 5;

        }

        public void SetComplexity(int level)
        {
            this.Complexity = level;
        }

        public void SetPriority(string level)
        {
            this.Priority = level;
        }
    }
}
