using System.ComponentModel;

namespace GroupGenerator
{
    internal class Student : Person, IStudent
    {
        // Stores all students added to the app
        public static BindingList<Student> studentList = new BindingList<Student>();

        // Stores the list after shuffle/split (used for grouping)
        public static BindingList<Student> GroupedList = new BindingList<Student>();

        private string Id;

        // Constructor that takes a single full name string
        public Student(string name)
            : base(name)
        {
            this.Name = name;
        }

        // Constructor with first and last name
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Used to determine if last name should be shown short (e.g., D.)
        public static bool IsLastNameShort { get; set; }

        // Name formatting based on display mode and IsLastNameShort flag
        public override string Name
        {
            get
            {
                if (Person.DisplayMode == Person.DisplayModeFirstLastName && IsLastNameShort)
                {
                    return this.FirstName + " " + this.LastName.Substring(0, 1) + ".";
                }
                else if (Person.DisplayMode == Person.DisplayModeFirstLastName)
                {
                    return this.FirstName + " " + this.LastName;
                }
                else if (Person.DisplayMode == Person.DisplayModeLastCommaFirstName)
                {
                    return this.LastName + ", " + this.FirstName + " " + this.ID;
                }
                else
                {
                    return "Invalid display mode!";
                }
            }

            set
            {
                // Parses full name with or without a comma and sets properties
                if (value.Contains(','))
                {
                    string[] nameParts = value.Trim().Split(' ');
                    this.LastName = nameParts[0].Replace(',', ' ').Trim();
                    nameParts[0] = string.Empty;
                    this.ID = nameParts[nameParts.Length - 1].Trim();
                    nameParts[nameParts.Length - 1] = string.Empty;
                    this.FirstName = string.Join(" ", nameParts).Trim();
                }
                else
                {
                    string[] nameParts = value.Trim().Split(' ');
                    this.ID = nameParts[nameParts.Length - 1].Trim();
                    nameParts[nameParts.Length - 1] = string.Empty;
                    this.FirstName = nameParts[0].Trim();
                    nameParts[0] = string.Empty;
                    this.LastName = string.Join(" ", nameParts).Trim();
                }
            }
        }

        // Student number with basic validation
        public string ID
        {
            get => this.Id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student number cannot be empty.", nameof(this.ID));
                }

                this.Id = value.Trim();
            }
        }

        // Adds a student to the studentList
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            studentList.Add(student);
        }

        // Creates randomized groups from GroupedList
        public List<List<Student>> CreateGroups(int numberOfGroups)
        {
            if (numberOfGroups <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfGroups), "Number of groups must be positive.");
            }

            List<List<Student>> result = new List<List<Student>>();
            for (int i = 0; i < numberOfGroups; i++)
            {
                result.Add(new List<Student>());
            }

            var random = new Random();
            var shuffledStudents = new List<Student>(GroupedList.OrderBy(s => random.Next()));

            for (int i = 0; i < shuffledStudents.Count; i++)
            {
                result[i % numberOfGroups].Add(shuffledStudents[i]);
            }

            return result;
        }

        // Display student name in listbox
        public override string ToString()
        {
            return this.Name;
        }
    }
}
