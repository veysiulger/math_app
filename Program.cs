using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace math_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Level level=new Level(1,0,5);
            int answer=level.createQuestion(3,4);
            Console.ReadKey();
        }
    }
}
