﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //run_cmd(@"C:\Users\RLB\Desktop\Cognata\Python\DevelopScripts\AccessibleScripts\try.py");

            //run_cmd(@"C:\Users\RLB\Desktop\Cognata\Python\DevelopScripts\SceneScripts\ScenarioGeneratorSelect.py");
            run_cmd(@"C:\Users\RLB\Desktop\Cognata\Python\DevelopScripts\AccessibleScripts\AnalysingRuns.py");
            Car_choosing_comboBox.Items.Add("Hummer");   //adding items to the dropdown
            Car_choosing_comboBox.Items.Add("Oshkosh");
            Car_choosing_comboBox.Items.Add("Sedan");


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Type_of_leactures_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Scenario_selection_comboBox.Items.Clear();
            if (Type_of_leactures_comboBox.SelectedItem.Equals("Run selected scenarios"))
            {
                Scenario_selection_comboBox.Visible = true;
                Scenario_selection_title.Visible = true;
                Number_of_runs_textBox.Visible = true;
                Number_of_runs_title.Visible = true;
            }
            else
            {
                Scenario_selection_comboBox.Visible = false;
                Scenario_selection_title.Visible = false;
                Number_of_runs_textBox.Visible = false;
                Number_of_runs_title.Visible = false;
            }

        }

        private void Analysis_results_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            // Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void run_cmd(string fileName)
        {
            Process p = new Process();
            //p.StartInfo = new ProcessStartInfo(@"C:\Users\RLB\anaconda3\envs\CognataPackEnv\python.exe", fileName)
            String python = @"C:\Python39\python.exe";
            Console.WriteLine("running cmd: " + python + " " + fileName);
            p.StartInfo = new ProcessStartInfo(python, fileName)
            {
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            p.Start();

            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();

            //p.WaitForInputIdle();

            //Console.WriteLine(output);

            //Console.ReadLine();

        }
    }
}
