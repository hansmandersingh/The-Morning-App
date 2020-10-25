namespace UserInfoPopup
{
    partial class User_Info_Popup
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
            this.First_Name_Label = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.Last_Name_Label = new System.Windows.Forms.Label();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First_Name_Label
            // 
            this.First_Name_Label.AutoSize = true;
            this.First_Name_Label.Location = new System.Drawing.Point(41, 97);
            this.First_Name_Label.Name = "First_Name_Label";
            this.First_Name_Label.Size = new System.Drawing.Size(94, 20);
            this.First_Name_Label.TabIndex = 0;
            this.First_Name_Label.Text = "First Name :";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(166, 97);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(194, 26);
            this.first_name_textBox.TabIndex = 1;
            // 
            // Last_Name_Label
            // 
            this.Last_Name_Label.AutoSize = true;
            this.Last_Name_Label.Location = new System.Drawing.Point(45, 158);
            this.Last_Name_Label.Name = "Last_Name_Label";
            this.Last_Name_Label.Size = new System.Drawing.Size(94, 20);
            this.Last_Name_Label.TabIndex = 2;
            this.Last_Name_Label.Text = "Last Name :";
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(166, 158);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(194, 26);
            this.last_name_textbox.TabIndex = 3;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(143, 238);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(83, 32);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // User_Info_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 337);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.last_name_textbox);
            this.Controls.Add(this.Last_Name_Label);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.First_Name_Label);
            this.Name = "User_Info_Popup";
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Info_Popup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label First_Name_Label;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label Last_Name_Label;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.Button submit_button;
    }
}

