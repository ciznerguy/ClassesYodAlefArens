using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsFromBagrut
{
    public class ReportCard
    {
        private string stuName;
        private Subject[] subArray;

        public double Avarage()
        {
            int sum = 0;
            for (int i = 0; i < subArray.Length; i++)
            {
                sum += subArray[i].GetGrade();
            }
            return (double)sum / subArray.Length;
        }
    }
}
