namespace ClassLibrary
{
     public class Internship
    {
        public Student? Intern { get; private set; }//property
        public Internship(Student intern) //constructor
        {
            Intern = intern;
            Intern.Internship = this;
        }

    }
}
