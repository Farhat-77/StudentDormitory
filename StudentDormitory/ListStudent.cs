using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDormitory
{
    public class ListStudent
    {
        static void Main(string[] args)
        {

        }
        public int score;
        public string name;
        public int income;
        public int group;

        public override string ToString()
        {
            return (string.Format("Имя студента {0}; score{1}; Group № {2};Размер дохода на одного члена семьи: {3}", name, score, group, income));
        }
    }
  
}
