using System.Collections;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (Age > other?.Age)
            {
                return 1;
            }
            else if (Age < other?.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    public class StudentCollection : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void AddStudents(params Student[] studentArray)
        {
            students.AddRange(studentArray);
        }

        public void SortStudents()
        {
            students.Sort();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
