using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2019AlgorithmLab
{
    class BruteForceGuesser : Guesser
    {
        public BruteForceGuesser()
        {
            this.Name = "BruteForce-Hight2Low";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
        }

        public BruteForceGuesser(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "BruteForce-Hight2Low Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = MaxRandomNum;
            this.Max = 0;
        }


        public override int RunOnce(Random random)
        {
            int target = random.Next(1, MaxRandomNum + 1);

            for (int j = MaxRandomNum; j > 0; j--)
            {
                CurrentCount++;
                if (j == target)
                {
                    break;
                }
            }
            return CurrentCount;
        }

    }
}
