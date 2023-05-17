
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
        
        public Student GetStudentById(int id)
        {
            foreach(Student s in this.students)
            {
                if (s is not null)
                {
                    if (s.Id.Equals(id)) return s;
                    
                }
            }
            return null;
        }
        
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
        //4. sap xep tang dan theo diem
        public Student[] SortArray()
        {
           

            for (int i = 0; i < this.size - 1; i++)
            {
                int smallestVal = i; //index cua vi tri ma Student co Mark nho nhat.
                for (int j = i + 1; j < this.size; j++)
                {
                    if (students[j].Mark < students[smallestVal].Mark)
                    {
                        smallestVal = j;
                    }
                }
                Student tempVar = students[smallestVal];
                students[smallestVal] = students[i];
                students[i] = tempVar;
            }
            return students;
        }
        //5. tim kiem nhi phan
        public int BinarySearch(Student student)
        {
            int left = 0;
            int right = size - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int comparison = students[middle].Id.CompareTo(student.Id);
                if (comparison == 0)
                {
                    return middle;
                }
                else if (comparison < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }


    }
}
