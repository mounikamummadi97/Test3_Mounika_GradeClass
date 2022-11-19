using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3_Mounika_ClassLibraryGradeCalculation;

namespace Test3_Mounika_GradeClass
{
    public class StudentGrade : Student, Student_Marks
    {
        public int Telugu { get; set; }
        public int Hindi { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }



        double totalMarks;



        public void SetStudentMarks()
        {



            Console.WriteLine("Enter Telugu Marks ");
            Telugu = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Hindi Marks ");
            Hindi = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter English Marks ");
            English = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Maths Marks ");
            Maths = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Science Marks ");
            Science = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Social Marks ");
            Social = int.Parse(Console.ReadLine());
        }
        public void DisplayStudentMarks()
        {
            Console.WriteLine("Telugu Marks : " + Telugu);
            Console.WriteLine("Hindi Marks : " + Hindi);
            Console.WriteLine("English Marks : " + English);
            Console.WriteLine("Maths Marks : " + Maths);
            Console.WriteLine("Science Marks : " + Science);
            Console.WriteLine("Social Marks : " + Social);
        }
        public void CalculateGrade()
        {
            StudentDetails();
            Console.WriteLine("------------");
            DisplayStudentDetails();
            Console.WriteLine("------------");
            SetStudentMarks();
            Console.WriteLine("------------");
            DisplayStudentMarks();
            Console.WriteLine("------------");



            totalMarks = Telugu + Hindi + English + Maths + Science + Social;
            Console.WriteLine("TotalMarks Marks : " + totalMarks);



            if (Telugu >= 35 && Hindi >= 35 && English >= 35 && Maths >= 35 && Science >= 35 && Social >= 35)
            {



                if (totalMarks >= 450 && totalMarks <= 600)
                {
                    Console.WriteLine("Student Grade is \"A\"");
                }
                else if (totalMarks >= 300 && totalMarks < 450)
                {
                    Console.WriteLine("Student Grade is \"B\"");
                }
                else
                {
                    Console.WriteLine("Student Grade is \"C\"");
                }
            }
            else
            {
                Console.WriteLine("Student failed ");
            }
        }
    }
}