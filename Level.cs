using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_app
{
    public class Level
    {
        public byte level;
        public byte levelScore;
        public byte pointPerQuestion;


        public Level(byte level, byte score, byte point)
        {
            this.level = level;
            this.levelScore = score;
            this.pointPerQuestion = point;
        }
    }
}
