namespace gui
{
    partial class Form2
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
            this.FIle_name_title = new System.Windows.Forms.Label();
            this.file_name_textBox = new System.Windows.Forms.TextBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.Main_menu_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIle_name_title
            // 
            this.FIle_name_title.AutoSize = true;
            this.FIle_name_title.BackColor = System.Drawing.Color.Transparent;
            this.FIle_name_title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIle_name_title.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.FIle_name_title.Location = new System.Drawing.Point(27, 50);
            this.FIle_name_title.Name = "FIle_name_title";
            this.FIle_name_title.Size = new System.Drawing.Size(110, 26);
            this.FIle_name_title.TabIndex = 0;
            this.FIle_name_title.Text = "File name:";
            // 
            // file_name_textBox
            // 
            this.file_name_textBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_name_textBox.Location = new System.Drawing.Point(141, 49);
            this.file_name_textBox.Name = "file_name_textBox";
            this.file_name_textBox.Size = new System.Drawing.Size(269, 25);
            this.file_name_textBox.TabIndex = 1;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.PowderBlue;
            this.Close_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(807, 380);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(60, 28);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Main_menu_button
            // 
            this.Main_menu_button.BackColor = System.Drawing.Color.PowderBlue;
            this.Main_menu_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_menu_button.Location = new System.Drawing.Point(684, 380);
            this.Main_menu_button.Name = "Main_menu_button";
            this.Main_menu_button.Size = new System.Drawing.Size(105, 28);
            this.Main_menu_button.TabIndex = 3;
            this.Main_menu_button.Text = "Main menu";
            this.Main_menu_button.UseVisualStyleBackColor = false;
            this.Main_menu_button.Click += new System.EventHandler(this.Main_menu_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.Azure;
            this.Save_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(416, 45);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(57, 31);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::gui.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Main_menu_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.file_name_textBox);
            this.Controls.Add(this.FIle_name_title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIle_name_title;
        private System.Windows.Forms.TextBox file_name_textBox;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Main_menu_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button button1;
    }
}