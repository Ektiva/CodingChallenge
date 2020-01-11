using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    //coordonate To Browse an 2 dimensional array
    class Point
    {
        public int x = 0;
        public int y = 0;
        public int counter = 0;
        
        public Point(int x, int y, int counter)
        {
            this.x = x;
            this.y = y;
            this.counter = counter;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
    }
}
