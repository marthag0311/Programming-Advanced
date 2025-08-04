using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Greedy_Algorithms
{
    public class Subject : IComparable<Subject>
    {
        public string Name { get; set;  }
        public double Start { get; set; }
        public double End { get; set; }

        public Subject(string name, double start, double end)
        {
            Name = name;
            Start = start;
            End = end;
        }

        public int CompareTo(Subject other)
        {
            if (this.End < other.End) return -1;
            if (this.End > other.End) return 1;
            return 0;
        }
    }

    public class Practice
    {
        List<Subject> subjects = new List<Subject>();
        public void AddClass(string subject, double start, double end)
        {
            subjects.Add(new Subject(subject, start, end));
        }

        public List<Subject> Scheduling()
        {
            subjects.Sort();

            List<Subject> schedule = new List<Subject>
            {
                subjects[0]
            };

            for (int i = 1; i < subjects.Count; i++)
            {
                if (subjects[i].Start >= schedule[schedule.Count - 1].End)
                {
                    schedule.Add(subjects[i]);
                }    
            }
            return schedule;
        }

        public override string ToString()
        {
            subjects.Sort();
            string s = "";
            foreach (var item in subjects)
            {
                s += item.Name + " " + item.Start + " " + item.End + "\n";
            }
            return s;
        }
    }
}
