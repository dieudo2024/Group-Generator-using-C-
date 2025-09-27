namespace GroupGenerator
{
    internal class Teacher: Person, ITeacher
    {
        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }

        // this method gets the student name
        public string GetName()
        {
            return this.ToString();
        }
    }
}
