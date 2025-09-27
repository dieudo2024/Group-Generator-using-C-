using System.ComponentModel;

namespace GroupGenerator
{
    public partial class Form1 : Form
    {
        // Random number generator used for sufflin and random picking.
        private Random random = new Random();
        private Student studentObj;
        private DisplayGroupForm display = new DisplayGroupForm();

        public Form1()
        {
            this.InitializeComponent();
        }

        // This method refreshes and displays the student list in the DisplayGroupForm.
        private void Display()
        {
            try
            {
                // Reinitialize the form if it was closed
                if (this.display.IsDisposed)
                {
                    this.display = new DisplayGroupForm();
                }

                // Clear the current items in the DisplayListBox before repopulating it.
                this.display.DisplayListBox.Items.Clear();

                // This loop adds each student to the ListBox
                for (int i = 0; i < Student.GroupedList.Count; i++)
                {
                    this.display.DisplayListBox.Items.Add(Student.GroupedList[i].ToString());
                }

                this.display.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot catch a disposed object: " + e.Message);
            }
        }

        // This method imports student data from the text box into the student list
        private void ImportData()
        {
            try
            {
                Student.studentList.Clear();    // Clear the list before importing new data

                Student.studentList = new BindingList<Student>();

                // Parse and add new students
                this.ImportOrAdd();

                // Synchronize the grouped list with the main list which is the studentlist.
                Student.GroupedList = Student.studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        // This method adds student to the listbox
        private void ImportOrAdd()
        {
            try
            {
                string[] lines = this.UserInputTextBox.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    this.studentObj = new Student(line);
                    Student.studentList.Add(this.studentObj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UserInputTextBox.Text))
            {
                MessageBox.Show("No import was made. Please paste student data into the input box first.");
                return;
            }

            this.ImportData();
            this.Display();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UserInputTextBox.Text))
            {
                MessageBox.Show("No import was made. Please paste student data into the input box first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.UserInputTextBox.Text))
            {
                MessageBox.Show("Please add something in the input first");
                return;
            }

            this.ImportOrAdd();
            this.Display();
        }

        // Method to modify a selected student's details directly
        private void Modify()
        {
            // Get the index of the selected student from the display list box
            int selectedIndex = this.display.DisplayListBox.SelectedIndex;

            // Check if a student is selected
            if (selectedIndex < 0)
            {
                // If no student is selected, show an error message and exit the method
                MessageBox.Show("Please select a student from the list to modify.");
                return;
            }

            // Retrieve the new student details from the ModifyTextBox
            string newInput = this.ModifyTextBox.Text.Trim();

            // Check if the new input is empty
            if (string.IsNullOrWhiteSpace(newInput))
            {
                // If the input is empty, show an error message and exit the method
                MessageBox.Show("Please enter the modified student details in the ModifyTextBox.");
                return;
            }

            // Split the input string into parts (assumes "FirstName LastName ID" format)
            string[] nameParts = newInput.Split(' ');

            if (nameParts.Length >= 2)
            {
                // Get the selected student from the GroupedList
                Student selectedStudent = Student.GroupedList[selectedIndex];

                // Directly modify the student's properties
                selectedStudent.FirstName = nameParts[0]; // FirstName is always the first part
                selectedStudent.LastName = nameParts[1];  // LastName is always the second part

                // If there's a third part, it's assumed to be the student ID
                if (nameParts.Length > 2)
                {
                    selectedStudent.ID = nameParts[nameParts.Length - 1]; // ID is the last part
                }

                // Refresh the display to show the updated student list
                this.Display();

                // Show a success message indicating the modification was successful
                MessageBox.Show("Student details updated successfully.");
            }
            else
            {
                // If the name format is incorrect (e.g., missing first or last name), show an error message
                MessageBox.Show("Invalid name format. Please provide both first and last names.");
            }
        }

        private void RandomStudent()
        {
            try
            {
                Random random = new Random();
                int index;
                for (int i = 0; i < 7; i++)
                {
                    index = random.Next(Student.GroupedList.Count);
                    Student randomStudent = Student.GroupedList[index];
                    this.display.DisplayListBox.SelectedIndex = index;
                    Thread.Sleep(500); // Adds delay for visual effect
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Please try again." + e.Message);
            }
        }

        // This method shuffles the order of the students in the grouped list.
        private void Shuffle()
        {
            var shuffledList = Student.GroupedList.OrderBy(s => this.random.Next()).ToList();
            Student.GroupedList = new BindingList<Student>(shuffledList);

            this.display.DisplayListBox.Items.Clear();

            foreach (var student in Student.GroupedList)
            {
                this.display.DisplayListBox.Items.Add(student.ToString());
            }
        }

        // This method splits student into groups based on user input.
        private void Split()
        {
            this.display.DisplayListBox.Items.Clear();

            int total = Student.GroupedList.Count;
            if (total == 0)
            {
                MessageBox.Show("There are no students to split.");
                return;
            }

            int groupCount = 0;
            int groups = 0;
            int members = 0;
            bool isValid1 = int.TryParse(this.NumberOfMembersTextBox.Text.Trim(), out members);
            bool isValid2 = int.TryParse(this.NumberOfGroupsTextBox.Text.Trim(), out groups);
            if (members < 0 || groups < 0)
            {
                    MessageBox.Show("Please enter a valid number of groups or members per group.");
                    return;
            }

            // Priority given to members per group first
            if (isValid1 && members > 0)
            {
                groupCount = (int)Math.Ceiling((double)total / members);
            }
            else if (isValid2 || groups > 0)
            {
                groupCount = groups;

                // Auto-calculate members per group to use inside the loop
                members = (int)Math.Ceiling((double)total / groupCount);
            }
            else
            {
                MessageBox.Show("Please enter a valid number of groups or members per group.");
                return;
            }

            if (groupCount > members * groups && members != 0)
            {
                MessageBox.Show("The expected number of groups and group members do not correspond to the number of students. \n You will get a default number of groups.");
            }

            // Shuffle students before grouping
            var shuffled = Student.GroupedList.OrderBy(s => this.random.Next()).ToList();

            // Create empty groups
            var groupsList = new List<List<Student>>();
            for (int i = 0; i < groupCount; i++)
            {
                groupsList.Add(new List<Student>());
            }

            // Distribute students across groups
            int groupLength = 0;
            int studentsNum = 0;

            while (groupLength < groupsList.Count && studentsNum < shuffled.Count)
            {
                for (int j = 0; j < members && studentsNum < shuffled.Count; j++)
                {
                    groupsList[groupLength].Add(shuffled[studentsNum]);
                    studentsNum++;
                }

                groupLength++;
            }

            // Display grouped results
            for (int i = 0; i < groupsList.Count; i++)
            {
                this.display.DisplayListBox.Items.Add($"Group {i + 1}:");
                foreach (var student in groupsList[i])
                {
                    this.display.DisplayListBox.Items.Add("  " + student);
                }

                this.display.DisplayListBox.Items.Add(" ");
            }
        }

        private void FirstNameLastshortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Student.IsLastNameShort = true;
                Person.DisplayMode = Person.DisplayModeFirstLastName;
                this.Display();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please try again." + exception.Message);
            }
        }

        private void FirstLastnameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Student.IsLastNameShort = false;
                Person.DisplayMode = Person.DisplayModeFirstLastName;
                this.Display();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please try again." + exception.Message);
            }
        }

        private void LastFirstnameIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Person.DisplayMode = Person.DisplayModeLastCommaFirstName;
                this.Display();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please try again." + exception.Message);
            }
        }

        private void PickOneRandomlyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Display();
                this.RandomStudent();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please try again." + exception.Message);
            }
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UserInputTextBox.Text))
            {
                MessageBox.Show("No import was made. Please paste student data into the input box first.");
                return;
            }

            this.Display();
            this.Shuffle();
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Split();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please try again." + exception.Message);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Modify();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during modification: " + ex.Message);
            }
        }
    }
}