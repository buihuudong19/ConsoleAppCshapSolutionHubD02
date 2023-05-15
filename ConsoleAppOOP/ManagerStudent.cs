﻿
namespace ConsoleAppOOP
{
    public class ManagerStudent
    {
        private Student[] students;//null
        private int size; //cho biet so luong sv co thuc 

        public ManagerStudent()
        {
            this.students = new Student[5];
            this.size = 0;
        }



        //1.Cho phep them 1 sinh vien
        public void AddStudent(Student s)
        {
            //check size cua mang
            if(this.size >= this.students.Length)
            {
                Student[] temp = new Student[2 * this.size];
                //move toan bo tu mang cu sang mang temp
                for(int i=0; i < this.size; i++)
                {
                    temp[i] = this.students[i];
                }
                this.students = temp;

            }
            this.students[size++] = s;

        }
        //2. Lay ra 1 sinh vien theo Id nao do
        /*
        public Student GetStudentById(int id)
        {

        }
        */
        //3. hien thi toan bo thong tin sinh vien ra man hinh
        public void ShowAllStudent()
        {
            if (this.size != 0)
            {
                for(int i =0; i<this.size; i++)
                {
                    this.students[i].Display();
                }
            }
        }


    }
}