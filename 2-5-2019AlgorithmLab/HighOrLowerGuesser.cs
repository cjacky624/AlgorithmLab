using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2019AlgorithmLab
{
    class HighOrLowerGuesser : Guesser
    {
        public HighOrLowerGuesser()
        {
            this.Name = "HighOrLower Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
        }

        public HighOrLowerGuesser(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "HighOrLower Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = this.MaxRandomNum;

        }

        public override int RunOnce(Random random)
        {
            int low = 1;
            int high = this.MaxRandomNum;

            int target = random.Next(1, MaxRandomNum + 1);
            int guess = random.Next(1, MaxRandomNum + 1);

            while (guess != target)
            {
                CurrentCount++;
                if (guess < target)
                {
                    low = guess;
                    guess = random.Next(low, high + 1);
                }
                else
                {
                    high = guess;
                    guess = random.Next(low, high + 1);
                }
            }
            if (CurrentCount == 0)
                CurrentCount++;
            return CurrentCount;
        }

    }
}
