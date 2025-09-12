using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesYodAlefArens
{
    public class MyString
    {
        private char[] theString;

        public MyString(string st)
        { 
            theString = new char[st.Length];

            for (int i = 0; i < theString.Length; i++)
            {
                theString[i] = st[i];

            }
        }

        // פעולה בונה מעתיקה
        public MyString (MyString s)
        {
            theString = new char[s.theString.Length];
            for (int i = 0; i < theString.Length; i++)
            {
                this.theString[i] = s.theString[i];
            }
        }

        public int StringLength()
            {
              return  theString.Length;
             }
        
        public void MyToUpperCase ()
         {
            for (int i = 0; i < theString.Length; i++)
            {
                if (theString[i] >= 'a' && theString[i] <= 'z')
                {
                    theString[i] = (char)(theString[i] - 32);
                }
            }
        }

        public void MyToLowerCase()
        {
            for (int i = 0; i < theString.Length; i++)
            {
                if (theString[i] >= 'A' && theString[i] <= 'Z')
                {
                    theString[i] = (char)(theString[i] + 32);
                }
            }
        }

        public override string ToString()
        {

            string s = "";  

            for (int i = 0; i < theString.Length; i++)
            {
                s += theString[i];
            }

            return s;
        }
    }
}
