using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public void AddGrade(double grade)
        {
            Book book2 = new Book();
            book2.AddGrade(90.1);
            grades.Add(grade);
        }
        List<double> grades;
    }
}