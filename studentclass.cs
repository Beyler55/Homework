namespace studentclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Isi = new Student
            {
                HomeworkGrades = new int[] { 100, 100, 100, 100 },
                ProjectGrades = new int[] { 100, 100, 100,100 },
                FinalGrade = 100,
                Attendance = new bool[] { false, true, false, true,false }
            };
            Isi.GetCertificate();
        }
    }
    class Student
    {
        public int[] HomeworkGrades;
        public int[] ProjectGrades;
        public int FinalGrade;
        public bool[] Attendance;

        public void GetCertificate()
        {
            int present = 0;
            double totalresult;
            int sum1 = 0, sum2 = 0;
            int AvgHwGrade = 0, AvgPrGrade = 0;
            for (int i = 0; i < HomeworkGrades.Length; i++)
            {
                sum1 += HomeworkGrades[i];
                AvgHwGrade = sum1 / HomeworkGrades.Length;
            }

            for (int j = 0; j < ProjectGrades.Length; j++)
            {
                sum2 += ProjectGrades[j];
                AvgPrGrade = sum2 / ProjectGrades.Length;
            }

            for (int k = 0; k < Attendance.Length; k++)
            {
                if (Attendance[k] == true)
                {
                    present++;
                }
            }
            double GradePerAttend = 10 / Attendance.Length;
            //davamiyyete 10 bal qalirsa, hemin 10 bal umumi derslerin sayina bolub her gune gore qiymet cixardim.
            //10 gunluk dersin davamiyyet bali ile 5 gunluk eyni olmur mence. Gradeperattend bir gunluk davamiyyete gore dusen baldi.
            //Onu istirak elediyimiz gunlere vursaq tam bal alariq
            totalresult = AvgHwGrade * 0.25 + AvgPrGrade * 0.25 + FinalGrade * 0.4+present*GradePerAttend;
            if (totalresult>90)
            {
                System.Console.WriteLine("High Honour");
            }
            else if (totalresult>80)
            {
                System.Console.WriteLine("Honour");
            }
            else
            {
                System.Console.WriteLine("Normal");
            }

        }
    }
}
