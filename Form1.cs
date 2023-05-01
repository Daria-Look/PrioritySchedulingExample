using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PriorityScheduling
{    
    public partial class MainForm : Form
    {
        public int timeSlice = -1, timeSwitch = -1;
        public int id = 0, timeCpu, priority, timeArrival;
        public bool isSjf = false;
        private List<Process> list = new List<Process>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            // get random numbers
            Random random = new Random();
            timeCpu = random.Next(1, 20);
            priority = random.Next(1, 20);
            timeArrival = random.Next(1, 50);

            // make visible results
            textCpuBurst.Text = Convert.ToString(timeCpu);
            textPriority.Text = Convert.ToString(priority);
            textArrival.Text = Convert.ToString(timeArrival);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            // the best method I have ever seen is below as a comment
            // it deletes selected rows in datagridview
            /*
             * foreach (DataGridViewRow item in this.dataGridViewInput.SelectedRows)
            {
                dataGridViewInput.Rows.RemoveAt(item.Index);
            }
            */

            // make the history clear
            dataGridViewInput.Rows.Clear();
            id = 0;
            timeSlice = -1;
            timeSwitch = -1;
            isSjf = false;
            list.Clear();
        }

        private void AddingToList()
        {
            foreach (DataGridViewRow row in dataGridViewInput.Rows)
            {
                // get converted values
                id = Convert.ToInt32(row.Cells[0].Value);
                timeCpu = Convert.ToInt32(row.Cells[1].Value);
                priority = Convert.ToInt32(row.Cells[2].Value);
                timeArrival = Convert.ToInt32(row.Cells[3].Value);

                // set values
                Process process = new Process(id, timeCpu, priority, timeArrival);
                list.Add(process);
            }
        }

        private void NonPreemptiveNotSjf()
        {
            
        }

        private void NonPreemptiveSjf()
        {

        }

        private void PreemptiveNotSjf()
        {

        }

        private void PreemptiveSjf()
        {

        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            AddingToList();
            if (timeSwitch == -1 && timeSlice == -1 && !isSjf)
            {
                NonPreemptiveNotSjf();                
            }
            else if (timeSwitch == -1 && timeSlice == -1 && isSjf)
            {
                NonPreemptiveSjf();
            }
            else if (timeSwitch != -1 && timeSlice != -1 && !isSjf)
            {
                PreemptiveNotSjf();
            }
            else
            {
                PreemptiveSjf();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxPreemptive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPreemptive.Checked == true)
            {
                // make components visible
                labelTimeSlice.Visible = true;
                textTimeSlice.Visible = true;
                labelSwitchTime.Visible = true;
                textSwitchTime.Visible = true;

                if (!String.IsNullOrEmpty(Convert.ToString(textTimeSlice.Text)))
                {
                    timeSlice = Convert.ToInt32(textTimeSlice.Text);
                    timeSwitch = Convert.ToInt32(textSwitchTime.Text);
                }
            }
            else
            {
                labelTimeSlice.Visible = false;
                textTimeSlice.Visible = false;
                labelSwitchTime.Visible = false;
                textSwitchTime.Visible = false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // get all data about new process
            timeCpu = Convert.ToInt32(textCpuBurst.Text); 
            priority = Convert.ToInt32(textPriority.Text);
            timeArrival = Convert.ToInt32(textArrival.Text);
                       
            id++; // make id of process
            dataGridViewInput.Rows.Add(id, timeCpu, priority, timeArrival); // add data to table

            // make clear textboxes
            textCpuBurst.Text = "";
            textPriority.Text = "";
            textArrival.Text = "";
        }

        private void CheckBoxSjf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSjf.Checked == true)
            {
                isSjf = true; 
            }
            else
            {
                isSjf = false;
            }
        }
    }
}
