using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesYodAlefArens
{
    class Circle
    {
        private double radius;

        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius= radius;

        }
        public double GetCircumfence()
        {
            return 2*Math.PI*radius;
        }
    }
}
