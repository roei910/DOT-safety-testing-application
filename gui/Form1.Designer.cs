namespace gui
{
    partial class Form1
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
            this.Car_choosing_title = new System.Windows.Forms.Label();
            this.Car_choosing_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_leactures_title = new System.Windows.Forms.Label();
            this.Type_of_leactures_comboBox = new System.Windows.Forms.ComboBox();
            this.Scenario_selection_title = new System.Windows.Forms.Label();
            this.Scenario_selection_comboBox = new System.Windows.Forms.ComboBox();
            this.Number_of_runs_title = new System.Windows.Forms.Label();
            this.Number_of_runs_textBox = new System.Windows.Forms.TextBox();
            this.Analysis_results_button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Car_choosing_title
            // 
            this.Car_choosing_title.AutoSize = true;
            this.Car_choosing_title.BackColor = System.Drawing.Color.Transparent;
            this.Car_choosing_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_choosing_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Car_choosing_title.Location = new System.Drawing.Point(148, 31);
            this.Car_choosing_title.Name = "Car_choosing_title";
            this.Car_choosing_title.Size = new System.Drawing.Size(49, 26);
            this.Car_choosing_title.TabIndex = 0;
            this.Car_choosing_title.Text = "Car:";
            // 
            // Car_choosing_comboBox
            // 
            this.Car_choosing_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Car_choosing_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Car_choosing_comboBox.BackColor = System.Drawing.Color.Azure;
            this.Car_choosing_comboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_choosing_comboBox.FormattingEnabled = true;
            this.Car_choosing_comboBox.Location = new System.Drawing.Point(202, 32);
            this.Car_choosing_comboBox.Name = "Car_choosing_comboBox";
            this.Car_choosing_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Car_choosing_comboBox.TabIndex = 1;
            // 
            // Type_of_leactures_title
            // 
            this.Type_of_leactures_title.AutoSize = true;
            this.Type_of_leactures_title.BackColor = System.Drawing.Color.Transparent;
            this.Type_of_leactures_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_of_leactures_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Type_of_leactures_title.Location = new System.Drawing.Point(33, 65);
            this.Type_of_leactures_title.Name = "Type_of_leactures_title";
            this.Type_of_leactures_title.Size = new System.Drawing.Size(170, 26);
            this.Type_of_leactures_title.TabIndex = 2;
            this.Type_of_leactures_title.Text = "Type of leactures:";
            // 
            // Type_of_leactures_comboBox
            // 
            this.Type_of_leactures_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_of_leactures_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_of_leactures_comboBox.BackColor = System.Drawing.Color.Azure;
            this.Type_of_leactures_comboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_of_leactures_comboBox.FormattingEnabled = true;
            this.Type_of_leactures_comboBox.Items.AddRange(new object[] {
            "Complete examination process",
            "Run selected scenarios"});
            this.Type_of_leactures_comboBox.Location = new System.Drawing.Point(203, 66);
            this.Type_of_leactures_comboBox.Name = "Type_of_leactures_comboBox";
            this.Type_of_leactures_comboBox.Size = new System.Drawing.Size(227, 24);
            this.Type_of_leactures_comboBox.TabIndex = 3;
            this.Type_of_leactures_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_of_leactures_comboBox_SelectedIndexChanged);
            // 
            // Scenario_selection_title
            // 
            this.Scenario_selection_title.AutoSize = true;
            this.Scenario_selection_title.BackColor = System.Drawing.Color.Transparent;
            this.Scenario_selection_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scenario_selection_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Scenario_selection_title.Location = new System.Drawing.Point(25, 99);
            this.Scenario_selection_title.Name = "Scenario_selection_title";
            this.Scenario_selection_title.Size = new System.Drawing.Size(177, 26);
            this.Scenario_selection_title.TabIndex = 4;
            this.Scenario_selection_title.Text = "Scenario selection:";
            this.Scenario_selection_title.Visible = false;
            // 
            // Scenario_selection_comboBox
            // 
            this.Scenario_selection_comboBox.BackColor = System.Drawing.Color.Azure;
            this.Scenario_selection_comboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scenario_selection_comboBox.FormattingEnabled = true;
            this.Scenario_selection_comboBox.Items.AddRange(new object[] {
            "Complete examination process",
            "Run selected scenarios"});
            this.Scenario_selection_comboBox.Location = new System.Drawing.Point(204, 100);
            this.Scenario_selection_comboBox.Name = "Scenario_selection_comboBox";
            this.Scenario_selection_comboBox.Size = new System.Drawing.Size(182, 24);
            this.Scenario_selection_comboBox.TabIndex = 5;
            this.Scenario_selection_comboBox.Visible = false;
            // 
            // Number_of_runs_title
            // 
            this.Number_of_runs_title.AutoSize = true;
            this.Number_of_runs_title.BackColor = System.Drawing.Color.Transparent;
            this.Number_of_runs_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_runs_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Number_of_runs_title.Location = new System.Drawing.Point(40, 136);
            this.Number_of_runs_title.Name = "Number_of_runs_title";
            this.Number_of_runs_title.Size = new System.Drawing.Size(161, 26);
            this.Number_of_runs_title.TabIndex = 6;
            this.Number_of_runs_title.Text = "Number of runs:";
            this.Number_of_runs_title.Visible = false;
            // 
            // Number_of_runs_textBox
            // 
            this.Number_of_runs_textBox.BackColor = System.Drawing.Color.Azure;
            this.Number_of_runs_textBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_runs_textBox.Location = new System.Drawing.Point(204, 139);
            this.Number_of_runs_textBox.Name = "Number_of_runs_textBox";
            this.Number_of_runs_textBox.Size = new System.Drawing.Size(44, 23);
            this.Number_of_runs_textBox.TabIndex = 7;
            this.Number_of_runs_textBox.Visible = false;
            this.Number_of_runs_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Analysis_results_button
            // 
            this.Analysis_results_button.BackColor = System.Drawing.Color.MintCream;
            this.Analysis_results_button.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analysis_results_button.Location = new System.Drawing.Point(371, 183);
            this.Analysis_results_button.Name = "Analysis_results_button";
            this.Analysis_results_button.Size = new System.Drawing.Size(75, 50);
            this.Analysis_results_button.TabIndex = 8;
            this.Analysis_results_button.Text = "Start analysis";
            this.Analysis_results_button.UseVisualStyleBackColor = false;
            this.Analysis_results_button.Click += new System.EventHandler(this.Analysis_results_button_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.LightCyan;
            this.Title.Location = new System.Drawing.Point(1, -1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(400, 76);
            this.Title.TabIndex = 9;
            this.Title.Text = "Analysis of results";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Car_choosing_comboBox);
            this.panel1.Controls.Add(this.Car_choosing_title);
            this.panel1.Controls.Add(this.Analysis_results_button);
            this.panel1.Controls.Add(this.Type_of_leactures_title);
            this.panel1.Controls.Add(this.Number_of_runs_textBox);
            this.panel1.Controls.Add(this.Type_of_leactures_comboBox);
            this.panel1.Controls.Add(this.Number_of_runs_title);
            this.panel1.Controls.Add(this.Scenario_selection_title);
            this.panel1.Controls.Add(this.Scenario_selection_comboBox);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(159, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 251);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "start code saar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::gui.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                                                          ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Car_choosing_title;
        private System.Windows.Forms.ComboBox Car_choosing_comboBox;
        private System.Windows.Forms.Label Type_of_leactures_title;
        private System.Windows.Forms.ComboBox Type_of_leactures_comboBox;
        private System.Windows.Forms.Label Scenario_selection_title;
        private System.Windows.Forms.ComboBox Scenario_selection_comboBox;
        private System.Windows.Forms.Label Number_of_runs_title;
        private System.Windows.Forms.TextBox Number_of_runs_textBox;
        private System.Windows.Forms.Button Analysis_results_button;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

