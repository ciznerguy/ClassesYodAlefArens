using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesYodAlefArens
{
    public class Point
    {   

        private int x;
        private int y;
        string color;
        public Point(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;

        }

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
       public override string ToString()
        {
            return $"Point({x}, {y}, {color})";
        }
    }
}
