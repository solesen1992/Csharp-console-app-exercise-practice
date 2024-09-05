
namespace HelpCode.Model
{
    // public instead of internal so it can be used in other projects
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } // ? means that string can be null
        public string? LastName { get; set; }
        
        /**
         * Constructor
         */
        public Student(int id, string? firstName, string? lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        
        /** 
         * ToString
         */
        public override string? ToString()
        {
            //string? thisStudent = Id + ", " + FirstName + " " + LastName;
            string? thisStudent = $"{Id}: {FirstName} {LastName}";
            return thisStudent;
        }
    }
}
