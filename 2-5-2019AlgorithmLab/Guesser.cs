using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2019AlgorithmLab
{
    abstract class Guesser
    {
        protected string Name { get; set; }
        protected int CurrentCount { get; set; }
        protected int MaxRandomNum { get; set; }
        protected int TimesRoRun { get; set; }
        protected int Max { get; set; }
        protected int Min { get; set; }
        protected double Average { get; set; }
        protected List<int> EachCounts = new List<int> { };

        public abstract int RunOnce(Random random);

        public void PrintStats()
        {
            this.Average = (EachCounts.Sum() / TimesRoRun) * 1.0;
            Console.WriteLine($"{Name} ran {TimesRoRun} times.");
            Console.WriteLine($"Average: {this.Average}");
            Console.WriteLine($"Min: {this.Min}");
            Console.WriteLine($"Max: {this.Max}");
            Console.WriteLine();
        }
        public void SetLoopStats()
        {
            if (CurrentCount < Min)
            {
                Min = CurrentCount;
            }
            if (CurrentCount > Max)
            {
                Max = CurrentCount;
            }
            EachCounts.Add(CurrentCount);
            this.CurrentCount = 0;
        }
        public void RunNTimes(Random random)
        {
            for (int i = 0; i < TimesRoRun; i++)
            {
                RunOnce(random);
                SetLoopStats();
            }
        }
    }
}
