using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismTask
{
    internal class Student
    {
        public int[] Grades { get; set; }

        public Student(params int[] grades)    //1,2,3,4,5,6,7
        {
            int count = 0;
            foreach (var grade in grades)
            {
                if (grade % 2 == 0)
                {
                    count++;
                }
            }
            Grades = new int[count];
            int index = 0;
            foreach (var evenGrade in grades)
            {
                if(evenGrade % 2 == 0)
                {
                    Grades[index++] = evenGrade;
                }
            }
        }

    }
}
