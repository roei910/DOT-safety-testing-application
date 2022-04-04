using System;
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
using gui.Resources;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialize_combobox_items();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_scenario();
        }

        private void start_scenario()
        {
            create_scene_variables();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"C:\Users\rlbsimteamq\Desktop\Analyse\engine\start_engine.bat";
            processStartInfo.WorkingDirectory = @"C:\Users\rlbsimteamq\Desktop\Analyse";
            Process.Start(processStartInfo);
        }

        private void create_scene_variables()
        {
            var sceneVariables = new SceneVariables
            {
                n_runs = 10,
                groups = 2,
                df_name = "",
                scene_script_name = "MisradHatahbura",
                scene_id = "622774b6a27018002fcce857",//need to change to scene id from a list of scenes
                unique_columns = new Dictionary<string, bool>(){
                    {"AVGPositionInLaneFrame", false},
                    {"STDdevFrame", false },
                    {"AVGPositionInLaneScenario", false},
                    {"MinPositionInLane", false },
                    {"MaxPositionInLane", false },
                    {"PassingPosesInLane", false }
                }
            };
            string fileName = "sceneVariables.json";

            SceneVariables.createFile(sceneVariables, @"C:\Users\rlbsimteamq\Desktop\Analyse\engine", fileName);
        }

        private void initialize_combobox_items()
        {
            Car_choosing_comboBox.Items.Add("Hummer");   //adding items to the dropdown
            Car_choosing_comboBox.Items.Add("Oshkosh");
            Car_choosing_comboBox.Items.Add("Sedan");
        }
    }
}
