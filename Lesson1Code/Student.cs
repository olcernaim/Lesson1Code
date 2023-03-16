namespace Lesson1Code
{
    class Student : Person
    {
        private int studentNumber;
        //private string name;
        //private string surname;
        private int midtermGrade;
        private int finalGrade;
        private int projectGrade;
        public Student()
        {
            midtermGrade = 0;
            finalGrade = 0;
            projectGrade = 0;
        }

        public Student(int stProjectGrade)
        {
            midtermGrade = 0;
            finalGrade = 0;
            projectGrade = stProjectGrade;
        }
        public void SetStudentNumber(int number)
        {
            studentNumber = number;
        }
        public int GetStudentNumber()
        {
            return studentNumber;
        }
        public void SetName(string stname)
        {
            name = stname;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string stsurname)
        {
            surname = stsurname;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetMidtermGrade(int grade)
        {
            midtermGrade = grade;
        }
        public void SetFinalGrade(int grade)
        {
            finalGrade = grade;
        }
        public void SetProjectGrade(int grade)
        {
            projectGrade = grade;
        }

        public double CalculateTotalGrade()
        {
            double grade = (double)((midtermGrade * 0.35) + (finalGrade * 0.45) + (projectGrade * 0.2));

            return grade;
        }
        //protected:
    };
}
