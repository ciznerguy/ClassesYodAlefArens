using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesYodAlefArens
{
    public class CircleCollection
    {
        private Circle[] circles = new Circle[3];
        private int count = 0;

        public bool AddCircle(int radius)
       
        {
            Circle circle = new Circle(radius);
            if (count < circles.Length)
            {
                circles[count] = circle;
                count++;
                return true;
            }
            return false;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
