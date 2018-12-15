using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        public const int FeedMultiplier = 30;

        private int _numberOfCows;
        public int NumberOfCows
        {
            get { return _numberOfCows;}
            set { _numberOfCows = value;
                BagsOfFeed = _numberOfCows * FeedMultiplier;
            }
        }
    }
}
