using Demo_HelpCode.Model;

namespace Demo_HelpCode.Data
{
    public class StudentAccess
    {
        // Have _ when it's a variable on class level
        private readonly List<Student> _students;

        /**
         * Constructor
         */
        public StudentAccess() { 
            _students = new List<Student>();
        }

        public List<Student> DemoStudents { 
            get {
                _students.Add(new Student(1, "Hans", "Hansen"));
                _students.Add(new Student(2, "Ole", "Olsen"));
                return _students;
            }
        }
    }
}
