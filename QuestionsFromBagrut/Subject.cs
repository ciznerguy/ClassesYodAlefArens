using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsFromBagrut
{
    public class Subject
    {
        private string subName;
        private int grade;

        // פעולה בונה ריקה
        public Subject() 
        {
        }

        //פעולה בונה רגילה
        public Subject(string subName, int grade)
        {
            this.subName = subName;
            this.grade = grade;
        }
        //פעולת גישה לשם המקצוע

        public string GetSubName()
        {
            return subName;
        }
        //פעולת גישה לציון
        public int GetGrade()
        {
            return grade;
        }
        //פעולת שינוי לשם המקצוע
        public void SetSubName(string subName)
        {
            this.subName = subName;
        }
        //פעולת שינוי לציון
        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

    }
}
