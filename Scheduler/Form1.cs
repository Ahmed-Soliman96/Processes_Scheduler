using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace Scheduler
{
    
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
            CreateGraph(Gantt, "Gantt chart");
        }

        List<Process> processes = new List<Process>();
        int Algorithm;
        int Quantum;
        double AvgWT;
        int t1, t2;
        
        private void ProcID_TextChanged(object sender, EventArgs e) //PID
        {}
        private void Arrival_time_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //AT
        {}
        private void Burst_time_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //BT
        {}
        private void Priority_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //Priority
        {}
        private void Quantum_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //Quantum
        {}

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //FCFS
        { Algorithm = 1; }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //SJF-NP
        { Algorithm = 2; }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //SJF-P
        { Algorithm = 3; }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //Priority-NP
        { Algorithm = 4; }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //Priority-P
        { Algorithm = 5; }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) //RoundRobin
        { Algorithm = 6; }

        private void button1_Click(object sender, EventArgs e) //Add process
        {
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true) || (radioButton6.Checked == true))   Priority_box.Text = "0";
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true) || (radioButton4.Checked == true) || (radioButton5.Checked == true)) Quantum_box.Text = "0";
            if ((ProcID.Text == "") || (Arrival_time_box.Text == "") || (Burst_time_box.Text == "") || (Priority_box.Text == "") || (Quantum_box.Text == ""))
                MessageBox.Show("Add process info.");
            else
            {
                Process p = new Process(ProcID.Text, int.Parse(Arrival_time_box.Text),int.Parse(Burst_time_box.Text),int.Parse(Priority_box.Text));
                processes.Add(p);
                Quantum = int.Parse(Quantum_box.Text);
                ProcID.Clear(); ProcID.Focus();
                Arrival_time_box.Clear(); Arrival_time_box.Focus();
                Burst_time_box.Clear(); Burst_time_box.Focus();
                Priority_box.Clear(); Priority_box.Focus();
                Quantum_box.Clear(); Quantum_box.Focus();
            }
        }
        public void StartScheduling()
        {
            switch(Algorithm)
            {
                case 1: fcfs(); break;
                case 2: sjfnp(); break;
                case 3: sjfp(); break;
                case 4: prnp(); break;
                case 5: prp(); break;
                case 6: rr(); break;
            }
        }
        private void button2_Click(object sender, EventArgs e) //START
        {
            if (processes.Count == 0) MessageBox.Show("Add process info.");
            else
            {
                button1.Enabled = false;
                ProcID.Enabled = false;
                Arrival_time_box.Enabled = false;
                Burst_time_box.Enabled = false;
                Priority_box.Enabled = false;
                Quantum_box.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                StartScheduling();
                MessageBox.Show("Avg. waiting time = " + Convert.ToString(AvgWT) + " Secs.");
            }
        }
        private void button3_Click(object sender, EventArgs e) //RESET
        {
            processes.Clear();
            Gantt.GraphPane.CurveList.Clear();
            Gantt.GraphPane.GraphObjList.Clear();
            Gantt.Invalidate();
            button1.Enabled = true;
            ProcID.Enabled = true;
            Arrival_time_box.Enabled = true;
            Burst_time_box.Enabled = true;
            Priority_box.Enabled = true;           Priority_box.Clear();
            Quantum_box.Enabled = true;           Quantum_box.Clear();
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
        }
        //-----GANTT chart-----//
        private void CreateGraph(ZedGraphControl zg, string schedType)
        {
            GraphPane myPane = zg.GraphPane;
            myPane.Title.Text = schedType;
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "";
            myPane.BarSettings.Type = BarType.Stack;
            myPane.BarSettings.ClusterScaleWidth = 1.5;
            myPane.BarSettings.Base = BarBase.Y;
            zg.AxisChange();
            zg.Refresh();
        }
        private void stackBar(ZedGraphControl zg, string labelName, int val, Color clr)
        {
            ZedGraph.PointPairList listStack = new ZedGraph.PointPairList();
            listStack.Add(val, 0);
            BarItem barC = zg.GraphPane.AddBar(labelName, listStack, clr);
            barC.Bar.Fill = new Fill(clr);
            zg.AxisChange();
            zg.Refresh();
        }
        public Color RandColor(int n)
        {
            Color x = Color.MistyRose;
            List<Color> col=new List<Color>();
            col.Add(Color.AliceBlue); col.Add(Color.BlueViolet); col.Add(Color.Green); col.Add(Color.Lime); col.Add(Color.MistyRose); col.Add(Color.Pink); col.Add(Color.Red); col.Add(Color.Yellow); col.Add(Color.Violet); col.Add(Color.Orchid); col.Add(Color.Magenta);
            for (int i = 0; i < n; i++) x = col[i];
            return x;

        }
        /*------ALGORITHMS------*/
        private void fcfs()
        {
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if (processes[k].arrivalTime > processes[i].arrivalTime || (processes[k].arrivalTime == processes[i].arrivalTime && processes[k].brust > processes[i].brust))
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].arrivalTime > clock)
                {
                    processes[i].start = processes[i].arrivalTime;
                    clock += processes[i].start - processes[i].arrivalTime;
                    clock += processes[i].brust;
                }
                else
                {
                    if (i > 0)
                        processes[i].start = processes[i - 1].end;
                    clock += processes[i].brust;
                }
                if (processes[i].start > processes[i].arrivalTime)
                    processes[i].wait = processes[i].start - processes[i].arrivalTime;
                else processes[i].wait = 0;
                processes[i].end = processes[i].start + processes[i].brust;
                totalwait += processes[i].wait;
            }
            AvgWT = (double)totalwait / (double)processes.Count;
            for (int i = 0; i < processes.Count; i++) //Draw Gantt
            {
                int t = processes[i].brust;
                stackBar(Gantt, processes[i].name, t, RandColor(i));
            }
        }
        //
        private void sjfnp()
        {
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if (processes[k].arrivalTime >= processes[i].arrivalTime && processes[k].brust > processes[i].brust)
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].arrivalTime > clock)
                {
                    processes[i].start = processes[i].arrivalTime;
                    clock += processes[i].start - processes[i].arrivalTime;
                    clock += processes[i].brust;
                }
                else
                {
                    if (i > 0)
                        processes[i].start = processes[i - 1].end;
                    clock += processes[i].brust;
                }
                if (processes[i].start > processes[i].arrivalTime)
                    processes[i].wait = processes[i].start - processes[i].arrivalTime;
                else processes[i].wait = 0;
                processes[i].end = processes[i].start + processes[i].brust;
                totalwait += processes[i].wait;
            }
            AvgWT = (double)totalwait / (double)processes.Count;
            for (int i = 0; i < processes.Count; i++) //Draw Gantt
            {
                int t = processes[i].brust;
                stackBar(Gantt, processes[i].name, t, RandColor(i));
            }
        }
        //
        private void sjfp()
        {
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if (processes[k].arrivalTime >= processes[i].arrivalTime && processes[k].brust > processes[i].brust)
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                for (int j = 0; j < processes.Count; j++)
                {
                    Process temp2;
                    processes[i].remaintime = clock - processes[i].end;
                    if (processes[i].remaintime > processes[j].brust)
                    {
                        temp2 = processes[i];
                        processes[i] = processes[j];
                        processes[j] = temp2;
                    }
                    if (processes[i].arrivalTime > clock)
                    {
                        processes[i].start = processes[i].arrivalTime;
                        clock += processes[i].start - processes[i].arrivalTime;
                        processes[i].end = clock + processes[i].brust;
                        clock += processes[i].brust;
                    }
                    else
                    {
                        if (i > 0)
                            processes[i].start = processes[i - 1].end;
                        clock += processes[i].brust;
                    }
                    if (processes[i].start > processes[i].arrivalTime)
                        processes[i].wait = processes[i].start - processes[i].arrivalTime;
                    else processes[i].wait = 0;
                    totalwait += processes[i].wait;
                    int t = processes[i].brust - processes[i].remaintime;
                    stackBar(Gantt, processes[i].name, t, RandColor(i)); //Draw Gantt
                }
            }
            AvgWT = (double)totalwait / (double)processes.Count;
        }
        //
        private void prnp()
        {
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if ((processes[k].priority > processes[i].priority) && (processes[k].arrivalTime >= processes[i].arrivalTime))
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].arrivalTime > clock)
                {
                    processes[i].start = processes[i].arrivalTime;
                    clock += processes[i].start - processes[i].arrivalTime;
                    clock += processes[i].brust;
                }
                else
                {
                    if (i > 0)
                        processes[i].start = processes[i - 1].end;
                    clock += processes[i].brust;
                }
                if (processes[i].start > processes[i].arrivalTime)
                    processes[i].wait = processes[i].start - processes[i].arrivalTime;
                else processes[i].wait = 0;
                processes[i].end = processes[i].start + processes[i].brust;
                totalwait += processes[i].wait;
            }
            AvgWT = (double)totalwait / (double)processes.Count;
            for (int i = 0; i < processes.Count; i++) //Draw Gantt
            {
                int t = processes[i].brust;
                stackBar(Gantt, processes[i].name, t, RandColor(i));
            }
        }
        //
        private void prp()
        {
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if (processes[k].priority > processes[i].priority)
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < processes.Count; i++)
            {
                for (int j = 0; j < processes.Count; j++)
                {
                    Process temp2;
                    processes[i].remaintime = clock - processes[i].end;
                    if (processes[i].remaintime > processes[j].brust)
                    {
                        temp2 = processes[i];
                        processes[i] = processes[j];
                        processes[j] = temp2;
                    }
                    if (processes[i].arrivalTime > clock)
                    {
                        processes[i].start = processes[i].arrivalTime;
                        clock += processes[i].start - processes[i].arrivalTime;
                        processes[i].end = clock + processes[i].brust;
                        clock += processes[i].brust;
                    }
                    else
                    {
                        if (i > 0)
                            processes[i].start = processes[i - 1].end;
                        clock += processes[i].brust;
                    }
                    if (processes[i].start > processes[i].arrivalTime)
                        processes[i].wait = processes[i].start - processes[i].arrivalTime;
                    else processes[i].wait = 0;
                    processes[i].end = processes[i].start + processes[i].brust;
                    totalwait += processes[i].wait;
                    int t = processes[i].brust - processes[i].remaintime;
                    stackBar(Gantt, processes[i].name, t, RandColor(i)); //Draw Gantt
                }
            }
            AvgWT = (double)totalwait / (double)processes.Count;
        }
        //
        private void rr()
        {
            Queue<Process> q = new Queue<Process>();
            for (int i = 0; i < processes.Count; i++) q.Enqueue(processes[i]);
            
            Process temp;
            for (int k = 0; k < processes.Count; k++)
            {
                for (int i = k + 1; i < processes.Count; i++)
                {
                    if (processes[k].arrivalTime > processes[i].arrivalTime || (processes[k].arrivalTime == processes[i].arrivalTime && processes[k].brust > processes[i].brust))
                    {
                        temp = processes[i];
                        processes[i] = processes[k];
                        processes[k] = temp;
                    }
                }
            }
            bool fin = false;
            for (int i = 0; i < processes.Count; i++) processes[i].remaintime = processes[i].brust;
            rep:
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].remaintime == 0) fin = true ;
                if (processes[i].remaintime > 0)
                {
                    fin = false;
                    Process pq = q.Dequeue();
                    for (int count = Quantum; count >= 0; count--) processes[i].remaintime--;
                    q.Enqueue(pq);
                    processes[i].wait += Quantum;
                    stackBar(Gantt, processes[i].name, Quantum, RandColor(i)); //Draw Gantt
                }
            }
            if (fin == false) goto rep;
            int totalwait = 0;
            for (int i = 0; i < processes.Count; i++) totalwait += processes[i].wait;
            AvgWT = (double)totalwait / (double)processes.Count;
        }
    }
    class Process
    {
        public Process(string name, int arrivalTime, int brust, int priority)
        {
            this.name = name;
            this.arrivalTime = arrivalTime;
            this.brust = brust;
            this.priority = priority;
        }
        public Process()
        { }
        public string name;
        public int arrivalTime;
        public int brust;
        public int remaintime;
        public int priority;
        public int wait;
        public int end;
        public int start;
    }

}