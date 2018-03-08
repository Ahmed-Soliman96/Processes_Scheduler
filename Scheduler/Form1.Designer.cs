namespace Scheduler
{
    partial class Scheduler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.info = new System.Windows.Forms.Label();
            this.Arrival_time_box = new System.Windows.Forms.MaskedTextBox();
            this.arrival_time = new System.Windows.Forms.Label();
            this.burst_time = new System.Windows.Forms.Label();
            this.Burst_time_box = new System.Windows.Forms.MaskedTextBox();
            this.priority = new System.Windows.Forms.Label();
            this.Priority_box = new System.Windows.Forms.MaskedTextBox();
            this.quantum_sjf = new System.Windows.Forms.Label();
            this.Quantum_box = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SchedulingAlgorithm = new System.Windows.Forms.Label();
            this.Gantt = new ZedGraph.ZedGraphControl();
            this.PID = new System.Windows.Forms.Label();
            this.ProcID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(17, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(108, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "SJF (NP)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(220, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "SJF (P)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(318, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(93, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Priority (NP)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(449, 65);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(84, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Priority (P)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(575, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "R.R";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Font = new System.Drawing.Font("Californian FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(17, 111);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(142, 26);
            this.info.TabIndex = 7;
            this.info.Text = "Processes info.";
            // 
            // Arrival_time_box
            // 
            this.Arrival_time_box.Location = new System.Drawing.Point(182, 179);
            this.Arrival_time_box.Mask = "00000";
            this.Arrival_time_box.Name = "Arrival_time_box";
            this.Arrival_time_box.Size = new System.Drawing.Size(88, 20);
            this.Arrival_time_box.TabIndex = 8;
            this.Arrival_time_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Arrival_time_box.ValidatingType = typeof(int);
            this.Arrival_time_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Arrival_time_box_MaskInputRejected);
            // 
            // arrival_time
            // 
            this.arrival_time.AutoSize = true;
            this.arrival_time.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_time.Location = new System.Drawing.Point(179, 148);
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.Size = new System.Drawing.Size(88, 18);
            this.arrival_time.TabIndex = 9;
            this.arrival_time.Text = "Arrival time";
            this.arrival_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // burst_time
            // 
            this.burst_time.AutoSize = true;
            this.burst_time.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burst_time.Location = new System.Drawing.Point(299, 148);
            this.burst_time.Name = "burst_time";
            this.burst_time.Size = new System.Drawing.Size(77, 18);
            this.burst_time.TabIndex = 10;
            this.burst_time.Text = "Burst time";
            this.burst_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Burst_time_box
            // 
            this.Burst_time_box.Location = new System.Drawing.Point(302, 179);
            this.Burst_time_box.Mask = "00000";
            this.Burst_time_box.Name = "Burst_time_box";
            this.Burst_time_box.Size = new System.Drawing.Size(74, 20);
            this.Burst_time_box.TabIndex = 11;
            this.Burst_time_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Burst_time_box.ValidatingType = typeof(int);
            this.Burst_time_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Burst_time_box_MaskInputRejected);
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority.Location = new System.Drawing.Point(403, 148);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(59, 18);
            this.priority.TabIndex = 12;
            this.priority.Text = "Priority";
            this.priority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Priority_box
            // 
            this.Priority_box.Location = new System.Drawing.Point(406, 179);
            this.Priority_box.Mask = "00";
            this.Priority_box.Name = "Priority_box";
            this.Priority_box.Size = new System.Drawing.Size(55, 20);
            this.Priority_box.TabIndex = 13;
            this.Priority_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Priority_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Priority_box_MaskInputRejected);
            // 
            // quantum_sjf
            // 
            this.quantum_sjf.AutoSize = true;
            this.quantum_sjf.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantum_sjf.Location = new System.Drawing.Point(489, 148);
            this.quantum_sjf.Name = "quantum_sjf";
            this.quantum_sjf.Size = new System.Drawing.Size(67, 18);
            this.quantum_sjf.TabIndex = 14;
            this.quantum_sjf.Text = "Quantum";
            this.quantum_sjf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quantum_box
            // 
            this.Quantum_box.Location = new System.Drawing.Point(492, 178);
            this.Quantum_box.Mask = "00";
            this.Quantum_box.Name = "Quantum_box";
            this.Quantum_box.Size = new System.Drawing.Size(63, 20);
            this.Quantum_box.TabIndex = 15;
            this.Quantum_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantum_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Quantum_box_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(182, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SchedulingAlgorithm
            // 
            this.SchedulingAlgorithm.AutoSize = true;
            this.SchedulingAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SchedulingAlgorithm.Font = new System.Drawing.Font("Californian FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedulingAlgorithm.Location = new System.Drawing.Point(17, 19);
            this.SchedulingAlgorithm.Name = "SchedulingAlgorithm";
            this.SchedulingAlgorithm.Size = new System.Drawing.Size(199, 26);
            this.SchedulingAlgorithm.TabIndex = 20;
            this.SchedulingAlgorithm.Text = "Scheduling algorithm";
            // 
            // Gantt
            // 
            this.Gantt.Location = new System.Drawing.Point(17, 285);
            this.Gantt.Name = "Gantt";
            this.Gantt.ScrollGrace = 0D;
            this.Gantt.ScrollMaxX = 0D;
            this.Gantt.ScrollMaxY = 0D;
            this.Gantt.ScrollMaxY2 = 0D;
            this.Gantt.ScrollMinX = 0D;
            this.Gantt.ScrollMinY = 0D;
            this.Gantt.ScrollMinY2 = 0D;
            this.Gantt.Size = new System.Drawing.Size(605, 301);
            this.Gantt.TabIndex = 21;
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(14, 148);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(37, 18);
            this.PID.TabIndex = 22;
            this.PID.Text = "PID";
            // 
            // ProcID
            // 
            this.ProcID.Location = new System.Drawing.Point(17, 178);
            this.ProcID.Name = "ProcID";
            this.ProcID.Size = new System.Drawing.Size(100, 20);
            this.ProcID.TabIndex = 23;
            this.ProcID.TextChanged += new System.EventHandler(this.ProcID_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(528, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 24;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 598);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProcID);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.Gantt);
            this.Controls.Add(this.SchedulingAlgorithm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantum_box);
            this.Controls.Add(this.quantum_sjf);
            this.Controls.Add(this.Priority_box);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.Burst_time_box);
            this.Controls.Add(this.burst_time);
            this.Controls.Add(this.arrival_time);
            this.Controls.Add(this.Arrival_time_box);
            this.Controls.Add(this.info);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.Text = "Scheduling Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SchedulingAlgorithm;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.MaskedTextBox Arrival_time_box;
        private System.Windows.Forms.Label arrival_time;
        private System.Windows.Forms.Label burst_time;
        private System.Windows.Forms.MaskedTextBox Burst_time_box;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.MaskedTextBox Priority_box;
        private System.Windows.Forms.Label quantum_sjf;
        private System.Windows.Forms.MaskedTextBox Quantum_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ZedGraph.ZedGraphControl Gantt;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.TextBox ProcID;
        private System.Windows.Forms.Button button3;
    }
}

