namespace PriorityScheduling
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageInput = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelChoice = new System.Windows.Forms.Panel();
            this.checkBoxSjf = new System.Windows.Forms.CheckBox();
            this.checkBoxPreemptive = new System.Windows.Forms.CheckBox();
            this.panelPreemptive = new System.Windows.Forms.Panel();
            this.textSwitchTime = new System.Windows.Forms.TextBox();
            this.labelTimeSlice = new System.Windows.Forms.Label();
            this.textTimeSlice = new System.Windows.Forms.TextBox();
            this.labelSwitchTime = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.textArrival = new System.Windows.Forms.TextBox();
            this.textPriority = new System.Windows.Forms.TextBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.textCpuBurst = new System.Windows.Forms.TextBox();
            this.labelGridView = new System.Windows.Forms.Label();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpuBurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageOutput = new System.Windows.Forms.TabPage();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningProirity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.pageInput.SuspendLayout();
            this.panelChoice.SuspendLayout();
            this.panelPreemptive.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.pageOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageInput);
            this.tabControl.Controls.Add(this.pageOutput);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(641, 421);
            this.tabControl.TabIndex = 3;
            // 
            // pageInput
            // 
            this.pageInput.Controls.Add(this.buttonClear);
            this.pageInput.Controls.Add(this.panelChoice);
            this.pageInput.Controls.Add(this.panelPreemptive);
            this.pageInput.Controls.Add(this.buttonCalc);
            this.pageInput.Controls.Add(this.panelData);
            this.pageInput.Controls.Add(this.labelGridView);
            this.pageInput.Controls.Add(this.dataGridViewInput);
            this.pageInput.Location = new System.Drawing.Point(4, 22);
            this.pageInput.Name = "pageInput";
            this.pageInput.Padding = new System.Windows.Forms.Padding(3);
            this.pageInput.Size = new System.Drawing.Size(633, 395);
            this.pageInput.TabIndex = 0;
            this.pageInput.Text = "Input";
            this.pageInput.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(453, 363);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(171, 25);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear list of processes";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelChoice
            // 
            this.panelChoice.Controls.Add(this.checkBoxSjf);
            this.panelChoice.Controls.Add(this.checkBoxPreemptive);
            this.panelChoice.Location = new System.Drawing.Point(453, 23);
            this.panelChoice.Name = "panelChoice";
            this.panelChoice.Size = new System.Drawing.Size(171, 46);
            this.panelChoice.TabIndex = 13;
            // 
            // checkBoxSjf
            // 
            this.checkBoxSjf.AutoSize = true;
            this.checkBoxSjf.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSjf.Name = "checkBoxSjf";
            this.checkBoxSjf.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSjf.TabIndex = 1;
            this.checkBoxSjf.Text = "SJF";
            this.checkBoxSjf.UseVisualStyleBackColor = true;
            this.checkBoxSjf.CheckedChanged += new System.EventHandler(this.CheckBoxSjf_CheckedChanged);
            // 
            // checkBoxPreemptive
            // 
            this.checkBoxPreemptive.AutoSize = true;
            this.checkBoxPreemptive.Location = new System.Drawing.Point(3, 26);
            this.checkBoxPreemptive.Name = "checkBoxPreemptive";
            this.checkBoxPreemptive.Size = new System.Drawing.Size(79, 17);
            this.checkBoxPreemptive.TabIndex = 2;
            this.checkBoxPreemptive.Text = "Preemptive";
            this.checkBoxPreemptive.UseVisualStyleBackColor = true;
            this.checkBoxPreemptive.CheckedChanged += new System.EventHandler(this.CheckBoxPreemptive_CheckedChanged);
            // 
            // panelPreemptive
            // 
            this.panelPreemptive.Controls.Add(this.textSwitchTime);
            this.panelPreemptive.Controls.Add(this.labelTimeSlice);
            this.panelPreemptive.Controls.Add(this.textTimeSlice);
            this.panelPreemptive.Controls.Add(this.labelSwitchTime);
            this.panelPreemptive.Location = new System.Drawing.Point(453, 75);
            this.panelPreemptive.Name = "panelPreemptive";
            this.panelPreemptive.Size = new System.Drawing.Size(171, 60);
            this.panelPreemptive.TabIndex = 12;
            // 
            // textSwitchTime
            // 
            this.textSwitchTime.Location = new System.Drawing.Point(64, 32);
            this.textSwitchTime.Name = "textSwitchTime";
            this.textSwitchTime.Size = new System.Drawing.Size(100, 20);
            this.textSwitchTime.TabIndex = 6;
            this.textSwitchTime.Visible = false;
            // 
            // labelTimeSlice
            // 
            this.labelTimeSlice.AutoSize = true;
            this.labelTimeSlice.Location = new System.Drawing.Point(3, 9);
            this.labelTimeSlice.Name = "labelTimeSlice";
            this.labelTimeSlice.Size = new System.Drawing.Size(54, 13);
            this.labelTimeSlice.TabIndex = 3;
            this.labelTimeSlice.Text = "Time slice";
            this.labelTimeSlice.Visible = false;
            // 
            // textTimeSlice
            // 
            this.textTimeSlice.Location = new System.Drawing.Point(64, 6);
            this.textTimeSlice.Name = "textTimeSlice";
            this.textTimeSlice.Size = new System.Drawing.Size(100, 20);
            this.textTimeSlice.TabIndex = 4;
            this.textTimeSlice.Visible = false;
            // 
            // labelSwitchTime
            // 
            this.labelSwitchTime.AutoSize = true;
            this.labelSwitchTime.Location = new System.Drawing.Point(3, 35);
            this.labelSwitchTime.Name = "labelSwitchTime";
            this.labelSwitchTime.Size = new System.Drawing.Size(61, 13);
            this.labelSwitchTime.TabIndex = 5;
            this.labelSwitchTime.Text = "Switch time";
            this.labelSwitchTime.Visible = false;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(453, 307);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(171, 50);
            this.buttonCalc.TabIndex = 11;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.buttonRandom);
            this.panelData.Controls.Add(this.buttonAdd);
            this.panelData.Controls.Add(this.labelArrivalTime);
            this.panelData.Controls.Add(this.textArrival);
            this.panelData.Controls.Add(this.textPriority);
            this.panelData.Controls.Add(this.labelPriority);
            this.panelData.Controls.Add(this.labelCPU);
            this.panelData.Controls.Add(this.textCpuBurst);
            this.panelData.Location = new System.Drawing.Point(453, 141);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(171, 160);
            this.panelData.TabIndex = 10;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(6, 126);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(158, 23);
            this.buttonRandom.TabIndex = 16;
            this.buttonRandom.Text = "Get random numbers";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Location = new System.Drawing.Point(3, 70);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(58, 13);
            this.labelArrivalTime.TabIndex = 14;
            this.labelArrivalTime.Text = "Arrival time";
            // 
            // textArrival
            // 
            this.textArrival.Location = new System.Drawing.Point(64, 67);
            this.textArrival.Name = "textArrival";
            this.textArrival.Size = new System.Drawing.Size(100, 20);
            this.textArrival.TabIndex = 13;
            // 
            // textPriority
            // 
            this.textPriority.Location = new System.Drawing.Point(64, 37);
            this.textPriority.Name = "textPriority";
            this.textPriority.Size = new System.Drawing.Size(100, 20);
            this.textPriority.TabIndex = 12;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(3, 40);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(38, 13);
            this.labelPriority.TabIndex = 11;
            this.labelPriority.Text = "Priority";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(3, 10);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(55, 13);
            this.labelCPU.TabIndex = 10;
            this.labelCPU.Text = "CPU burst";
            // 
            // textCpuBurst
            // 
            this.textCpuBurst.Location = new System.Drawing.Point(64, 7);
            this.textCpuBurst.Name = "textCpuBurst";
            this.textCpuBurst.Size = new System.Drawing.Size(100, 20);
            this.textCpuBurst.TabIndex = 9;
            // 
            // labelGridView
            // 
            this.labelGridView.AutoSize = true;
            this.labelGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGridView.Location = new System.Drawing.Point(6, 3);
            this.labelGridView.Name = "labelGridView";
            this.labelGridView.Size = new System.Drawing.Size(115, 17);
            this.labelGridView.TabIndex = 8;
            this.labelGridView.Text = "List of processes";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CpuBurst,
            this.Priority,
            this.ArrivalTime});
            this.dataGridViewInput.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(444, 366);
            this.dataGridViewInput.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CpuBurst
            // 
            this.CpuBurst.HeaderText = "CPU burst";
            this.CpuBurst.Name = "CpuBurst";
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // pageOutput
            // 
            this.pageOutput.Controls.Add(this.buttonClear2);
            this.pageOutput.Controls.Add(this.dataGridViewOutput);
            this.pageOutput.Location = new System.Drawing.Point(4, 22);
            this.pageOutput.Name = "pageOutput";
            this.pageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.pageOutput.Size = new System.Drawing.Size(633, 395);
            this.pageOutput.TabIndex = 1;
            this.pageOutput.Text = "Output";
            this.pageOutput.UseVisualStyleBackColor = true;
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(458, 6);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(169, 36);
            this.buttonClear2.TabIndex = 1;
            this.buttonClear2.Text = "Clear list";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Click += new System.EventHandler(this.ButtonClear2_Click);
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.RunningId,
            this.RunningProirity,
            this.RunningRemaining});
            this.dataGridViewOutput.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.Size = new System.Drawing.Size(446, 383);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // RunningId
            // 
            this.RunningId.HeaderText = "ID";
            this.RunningId.Name = "RunningId";
            // 
            // RunningProirity
            // 
            this.RunningProirity.HeaderText = "Priority";
            this.RunningProirity.Name = "RunningProirity";
            // 
            // RunningRemaining
            // 
            this.RunningRemaining.HeaderText = "Remaining time";
            this.RunningRemaining.Name = "RunningRemaining";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(663, 445);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Priority scheduling algorithm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.pageInput.ResumeLayout(false);
            this.pageInput.PerformLayout();
            this.panelChoice.ResumeLayout(false);
            this.panelChoice.PerformLayout();
            this.panelPreemptive.ResumeLayout(false);
            this.panelPreemptive.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.pageOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageInput;
        private System.Windows.Forms.TabPage pageOutput;
        private System.Windows.Forms.CheckBox checkBoxPreemptive;
        private System.Windows.Forms.CheckBox checkBoxSjf;
        private System.Windows.Forms.Label labelTimeSlice;
        private System.Windows.Forms.TextBox textTimeSlice;
        private System.Windows.Forms.TextBox textSwitchTime;
        private System.Windows.Forms.Label labelSwitchTime;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpuBurst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.TextBox textArrival;
        private System.Windows.Forms.TextBox textPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.TextBox textCpuBurst;
        private System.Windows.Forms.Label labelGridView;
        private System.Windows.Forms.Panel panelPreemptive;
        private System.Windows.Forms.Panel panelChoice;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningProirity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningRemaining;
    }
}

