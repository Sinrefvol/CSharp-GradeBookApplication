using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            char letter;

            switch (averageGrade)
            {
                case var d when d >= 80.0:
                    letter = 'A';
                    break;
                case var d when d >= 60.0:
                    letter = 'B';
                    break;
                case var d when d >= 40.0:
                    letter = 'C';
                    break;
                case var d when d >= 20.0:
                    letter = 'D';
                    break;
                default:
                    letter = 'F';
                    break;

            }

            return letter;
        }
    }
}
