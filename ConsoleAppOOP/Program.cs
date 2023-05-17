using System;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(2,"Ma Van Meo",
                "Lao Cai, Viet Nam",8.5);
            Student s2 = new Student(3, "Nguyen Thu Ha",
               "Hai Duong, Viet Nam", 7.5);

            Student s3 = new Student(4, "Nguyen Thu Ha",
               "Hai Duong, Viet Nam", 7.5);
            Student s4 = new Student(5, "Nguyen Thu Ha",
               "Hai Duong, Viet Nam", 1.5);
            Student s5 = new Student(6, "Nguyen Thu Ha",
               "Hai Duong, Viet Nam", 5.5);
            Student s6 = new Student(7, "Nguyen Thu Ha",
               "Hai Duong, Viet Nam", 1);


            ManagerStudent managerStudent = new ManagerStudent();
            managerStudent.AddStudent(s1);
            managerStudent.AddStudent(s2);
            managerStudent.AddStudent(s3); 
            managerStudent.AddStudent(s4);
            managerStudent.AddStudent(s5);
            managerStudent.AddStudent(s6);

            managerStudent.ShowAllStudent();

            Console.WriteLine("==================Get One=========================");

            Student a = managerStudent.GetStudentById(2);
            Console.WriteLine(a);

            Console.WriteLine("================Sort list Student===========================");

            managerStudent.SortArray();
            managerStudent.ShowAllStudent();



            Console.ReadLine();


        }
    }
}
