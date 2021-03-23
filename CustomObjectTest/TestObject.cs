using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObjectTest
{
    public class TestObject
    {
        public int TestIntX { get; set; }
        public int TestIntY { get; set; }

        public int ResultXY { get; set; }

        public void Result(int x, int y)
        {
            TestIntX = x;
            TestIntY = y;

            ResultXY = x + y;
        }
    }
}
