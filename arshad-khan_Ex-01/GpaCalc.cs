using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arshad_khan_Ex_01
{
    public partial class GpaCalcForm : Form
    {
        public GpaCalcForm()
        {
            Thread splashGpa = new Thread(new ThreadStart(OpenSplash));
            splashGpa.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            splashGpa.Abort();
        }
        public void OpenSplash()
        {
            Application.Run(new Splash());
        }
        private void buttonCalcGPA_Click(object sender, EventArgs e)
        {
            try
            {
                int cred1 = Convert.ToInt32(comboBoxCred1.Text);
                int cred2 = Convert.ToInt32(comboBoxCred2.Text);
                int cred3 = Convert.ToInt32(comboBoxCred3.Text);
                int cred4 = Convert.ToInt32(comboBoxCred4.Text);
                int cred5 = Convert.ToInt32(comboBoxCred5.Text);
                int cred6 = Convert.ToInt32(comboBoxCred6.Text);
                int cred7 = Convert.ToInt32(comboBoxCred7.Text);

                double grade1 = Convert.ToDouble(textBoxGrade1.Text);
                double grade2 = Convert.ToDouble(textBoxGrade2.Text);
                double grade3 = Convert.ToDouble(textBoxGrade3.Text);
                double grade4 = Convert.ToDouble(textBoxGrade4.Text);
                double grade5 = Convert.ToDouble(textBoxGrade5.Text);
                double grade6 = Convert.ToDouble(textBoxGrade6.Text);
                double grade7 = Convert.ToDouble(textBoxGrade7.Text);

                int totalCreds = cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7;

                double credValue1 = grade1 * cred1;
                double credValue2 = grade2 * cred2;
                double credValue3 = grade3 * cred3;
                double credValue4 = grade4 * cred4;
                double credValue5 = grade5 * cred5;
                double credValue6 = grade6 * cred6;
                double credValue7 = grade7 * cred7;

                double totalCredValue = credValue1 + credValue2 + credValue3 + credValue4 + credValue5 + credValue6 + credValue7;

                double result = totalCredValue / totalCreds;
                labelResultGPA.Text = "My GPA is: " + result.ToString("0.##");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: " , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void GpaCalcForm_Load(object sender, EventArgs e)
        {
            this.Activate();

            //load file in datagridview
            string filename = @"C:\\S21\COMP123\LabAssignments\Arshad-Khan_Comp123-Sec010_Lab4\gpafile.txt";
            StreamReader text = new StreamReader(filename);
            dataGridView2.ColumnCount=3;
            int rows = 0;

            while (!text.EndOfStream)
            {
                string lines = text.ReadLine();
                string[] cols = lines.Split('\t');
                dataGridView2.Rows.Add();
                for (int i = 0; i < cols.Length; i++)
                {
                    dataGridView2[i, rows].Value = cols[i];
                }
                rows++;
            }
            text.Close();

            //digital clock
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void buttonCourseList_Click(object sender, EventArgs e)
        {
            List<string> courses = new List<string>();
            courses.Add("Comm160, 3 credits");
            courses.Add("Comp100, 4 credits");
            courses.Add("Comp120, 4 credits");
            courses.Add("Gned127, 3 credits");
            courses.Add("Math175, 3 credits");
            courses.Add("Bi111, 3 credits");
            courses.Add("Ch101, 4 credits");
            courses.Add("Math176, 3 credits");
            courses.Add("Comp213, 4 credits");
            courses.Add("Math269, 3 credits");
            courses.Add("Cnet212, 4 credits");
            courses.Add("Math169, 3 credits");
            courses.Add("Math149, 3 credits");
            courses.Add("Cnet225, 3 credits");
            courses.Add("Cnet332, 4 credits");

            var sortedCourses =
                from course in courses
                orderby course
                select course;
                
            string message = string.Join("\n", sortedCourses);
            MessageBox.Show(message);
        }

        private void buttonGetCourse_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> search = new Dictionary<string, string>();
                search.Add("Comm160", "3 credits");
                search.Add("Comp100", "4 credits");
                search.Add("Comp120", "4 credits");
                search.Add("Gned127", "3 credits");
                search.Add("Math175", "3 credits");
                search.Add("Bi111", "3 credits");
                search.Add("Ch101", "4 credits");
                search.Add("Math176", "3 credits");
                search.Add("Comp213", "4 credits");
                search.Add("Math269", "3 credits");
                search.Add("Cnet212", "4 credits");
                search.Add("Math169", "3 credits");
                search.Add("Math149", "3 credits");
                search.Add("Cnet225", "3 credits");
                search.Add("Cnet332", "4 credits");

                string courseKey = textBoxSearchCourse.Text;
                string message = string.Format(search[courseKey]);
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Please enter a correct course code from the list.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void buttonTargetForm_Click(object sender, EventArgs e)
        {
            TargetGpa targetGpaCalc = new TargetGpa(this);
            targetGpaCalc.Show();
        }

        //generic method requirement is used to send data from TargetGpa form to main GpaCalc form.
        public void SendValue<T>(T generic) 
        {
            string value = generic.ToString();
            labelMainTarget.Text = value;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonAllCnet_Click(object sender, EventArgs e)
        {
            List<string> courses = new List<string>();
            courses.Add("Comm160, 3 credits");
            courses.Add("Comp100, 4 credits");
            courses.Add("Comp120, 4 credits");
            courses.Add("Gned127, 3 credits");
            courses.Add("Math175, 3 credits");
            courses.Add("Bi111, 3 credits");
            courses.Add("Ch101, 4 credits");
            courses.Add("Math176, 3 credits");
            courses.Add("Comp213, 4 credits");
            courses.Add("Math269, 3 credits");
            courses.Add("Cnet212, 4 credits");
            courses.Add("Math169, 3 credits");
            courses.Add("Math149, 3 credits");
            courses.Add("Cnet225, 3 credits");
            courses.Add("Cnet332, 4 credits");

            var startsWithCnet =
                from course in courses
                where course.Contains("Cnet")
                orderby course
                select course;

            string message = string.Join("\n", startsWithCnet);
            MessageBox.Show(message);
        }

        private void buttonMathCourse_Click(object sender, EventArgs e)
        {
            List<string> courses = new List<string>();
            courses.Add("Comm160, 3 credits");
            courses.Add("Comp100, 4 credits");
            courses.Add("Comp120, 4 credits");
            courses.Add("Gned127, 3 credits");
            courses.Add("Math175, 3 credits");
            courses.Add("Bi111, 3 credits");
            courses.Add("Ch101, 4 credits");
            courses.Add("Math176, 3 credits");
            courses.Add("Comp213, 4 credits");
            courses.Add("Math269, 3 credits");
            courses.Add("Cnet212, 4 credits");
            courses.Add("Math169, 3 credits");
            courses.Add("Math149, 3 credits");
            courses.Add("Cnet225, 3 credits");
            courses.Add("Cnet332, 4 credits");

            var startsWithMath =
               from course in courses
               where course.Contains("Math")
               orderby course
               select course;

            string message = string.Join("\n", startsWithMath);
            MessageBox.Show(message);
        }

        private void button3CreditCour_Click(object sender, EventArgs e)
        {
            List<string> courses = new List<string>();
            courses.Add("Comm160, 3 credits");
            courses.Add("Comp100, 4 credits");
            courses.Add("Comp120, 4 credits");
            courses.Add("Gned127, 3 credits");
            courses.Add("Math175, 3 credits");
            courses.Add("Bi111  3 credits");
            courses.Add("Ch101  4 credits");
            courses.Add("Math176, 3 credits");
            courses.Add("Comp213, 4 credits");
            courses.Add("Math269, 3 credits");
            courses.Add("Cnet212, 4 credits");
            courses.Add("Math169, 3 credits");
            courses.Add("Math149, 3 credits");
            courses.Add("Cnet225, 3 credits");
            courses.Add("Cnet332, 4 credits");

            var contains3Creds =
                from course in courses
                where course.Contains("3 credits")
                orderby course
                select course.Substring(0,7);

            string message = string.Join("\n", contains3Creds);
            MessageBox.Show(message);
        }

        private void button4CredCour_Click(object sender, EventArgs e)
        {
            List<string> courses = new List<string>();
            courses.Add("Comm160, 3 credits");
            courses.Add("Comp100, 4 credits");
            courses.Add("Comp120, 4 credits");
            courses.Add("Gned127, 3 credits");
            courses.Add("Math175, 3 credits");
            courses.Add("Bi111  3 credits");
            courses.Add("Ch101  4 credits");
            courses.Add("Math176, 3 credits");
            courses.Add("Comp213, 4 credits");
            courses.Add("Math269, 3 credits");
            courses.Add("Cnet212, 4 credits");
            courses.Add("Math169, 3 credits");
            courses.Add("Math149, 3 credits");
            courses.Add("Cnet225, 3 credits");
            courses.Add("Cnet332, 4 credits");

            var contains4Creds =
                from course in courses
                where course.Contains("4 credits")
                orderby course
                select course.Substring(0, 7);

            string message = string.Join("\n", contains4Creds);
            MessageBox.Show(message);
        }
    }
}
