namespace GroupGenerator
{
    using System;

    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// DisplayGroupformDisplay mode to display the name like "FirstName LastName".
        /// </summary>
        public const int DisplayModeFirstLastName = 0;

        /// <summary>
        /// DisplayGroupformDisplay mode to display the name like "LastName, FirstName".
        /// </summary>
        public const int DisplayModeLastCommaFirstName = 1;

        /// <summary>
        /// DisplayGroupformDisplay mode of a person.
        /// </summary>
        private static int displayMode = Person.DisplayModeLastCommaFirstName;

        /// <summary>
        /// First name of a person.
        /// </summary>
        private string firstName = string.Empty;

        /// <summary>
        /// Last name of a person.
        /// </summary>
        private string lastName = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's fist name. Can't be empty.</param>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="firstName">Person's fist name. Can't be empty.</param>
        /// <param name="lastName">Person's last name. Can't be empty.</param>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
        }

        /// <summary>
        /// Gets or sets the display mode of a person.
        /// </summary>
        /// <remarks>
        /// Choose from one of the display modes defined in this class.
        /// </remarks>
        public static int DisplayMode
        {
            get
            {
                return displayMode;
            }

            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                displayMode = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public virtual string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("First name cannot be empty.", nameof(this.FirstName));
                }

                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Last name cannot be empty.", nameof(this.LastName));
                }

                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the full name of the person. The returned value will be formatted according to the display mode selected.
        /// </summary>
        public virtual string Name
        {
            get
            {
                switch (Person.DisplayMode)
                {
                    case Person.DisplayModeFirstLastName:
                        return this.FirstName + " " + this.LastName;
                    case Person.DisplayModeLastCommaFirstName:
                        return this.LastName + ", " + this.FirstName;
                    default:
                        return "Invalid display mode!";
                }
            }

            set
            {
                if (value.Contains(','))
                {
                    string[] nameParts = value.Trim().Split(',');
                    this.FirstName = nameParts[1].Trim();
                    this.LastName = nameParts[0].Trim();
                }
                else
                {
                    string[] nameParts = value.Trim().Split(' ');
                    this.LastName = nameParts[nameParts.Length - 1].Trim();
                    nameParts[nameParts.Length - 1] = string.Empty;
                    this.FirstName = string.Join(" ", nameParts).Trim();
                }
            }
        }

        /// <summary>
        /// Returns a string that represents the person according to the display mode selected.
        /// </summary>
        /// <returns>String that represents the person according to the display mode selected.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
