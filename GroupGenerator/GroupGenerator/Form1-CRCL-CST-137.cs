using System.ComponentModel;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GroupGenerator
{
    public partial class Form1 : Form
    {
        /*

Display a studentObj list

Add and modify students

Shuffle the list

Split into a specific number of groups

Split into groups of a certain size

Pick a studentObj at random
        */
        private Random random = new Random();
        private Student studentObj;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person.DisplayMode = Person.DisplayModeFirstLastName;
        }

        private void RefreshList()
        {
            this.StudentListBox.DataBindings.Clear();
        }

        private void ImportData()
        {
            try
            {
                Student.studentList.Clear();    // Clear the list before importing new data

                Student.studentList = new BindingList<Student>();

                this.ImportOrAdd(Student.studentList);

                Student.GroupedList = Student.studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        private void ImportOrAdd(BindingList<Student> neededList)
        {
            try
            {
                string[] lines = this.UserInputTextBox.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                this.studentObj = new Student(lines[0]);

                foreach (string line in lines)
                {
                    this.studentObj = new Student(line);
                    neededList.Add(this.studentObj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        private void Display()
        {
            this.StudentListBox.Items.Clear();
            for (int i = 0; i < Student.GroupedList.Count; i++)
            {
                this.StudentListBox.Items.Add(Student.GroupedList[i].ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.ImportOrAdd(Student.studentList);
            this.Display();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            this.ImportData();
            this.Display();
        }

        private void RandomStudent()
        {
            Random random = new Random();
            int index;
            for (int i = 0; i < 7; i++)
            {
                index = random.Next(Student.studentList.Count);
                Student randomStudent = Student.studentList[index];
                this.StudentListBox.SelectedIndex = index;
                Thread.Sleep(500);
            }
        }

        private void Shuffle()
        {
            var shuffledList = Student.studentList.OrderBy(s => this.random.Next()).ToList();
            Student.studentList = new BindingList<Student>(shuffledList);

            this.StudentListBox.Items.Clear();

            foreach (var student in Student.studentList)
            {
                this.StudentListBox.Items.Add(student.ToString());
            }
        }

        public void Split()
        {
            // Get the total number of students
            int totalStudents = Student.studentList.Count;
        }

        private void FirstNameLastshortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshList();
            Student.IsLastNameShort = true;
            Person.DisplayMode = Person.DisplayModeFirstLastName;
            this.Display();
        }

        private void FirstLastnameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshList();
            Student.IsLastNameShort = false;
            Person.DisplayMode = Person.DisplayModeFirstLastName;
            this.Display();
        }

        private void LastFirstnameIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Person.DisplayMode = Person.DisplayModeLastCommaFirstName;
            this.Display();
        }

        private void PickOneRandomlyButton_Click(object sender, EventArgs e)
        {
            this.RandomStudent();
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            this.Shuffle();
        }
    }
}