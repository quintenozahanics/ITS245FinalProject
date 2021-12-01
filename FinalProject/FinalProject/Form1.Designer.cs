
namespace FinalProject
{
    partial class Patient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchOptions = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.allergyButton = new System.Windows.Forms.Button();
            this.generalButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(180, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Demographics";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Allergies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(706, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "General";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(13, 23);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(151, 23);
            this.searchBar.TabIndex = 1;
            // 
            // searchOptions
            // 
            this.searchOptions.FormattingEnabled = true;
            this.searchOptions.Location = new System.Drawing.Point(13, 61);
            this.searchOptions.Name = "searchOptions";
            this.searchOptions.Size = new System.Drawing.Size(151, 23);
            this.searchOptions.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(37, 90);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(37, 199);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(100, 23);
            this.patientButton.TabIndex = 4;
            this.patientButton.Text = "Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            // 
            // allergyButton
            // 
            this.allergyButton.Location = new System.Drawing.Point(37, 239);
            this.allergyButton.Name = "allergyButton";
            this.allergyButton.Size = new System.Drawing.Size(100, 23);
            this.allergyButton.TabIndex = 5;
            this.allergyButton.Text = "Allergies";
            this.allergyButton.UseVisualStyleBackColor = true;
            // 
            // generalButton
            // 
            this.generalButton.Location = new System.Drawing.Point(37, 287);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(100, 23);
            this.generalButton.TabIndex = 6;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(37, 372);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 23);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(37, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 500);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.allergyButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchOptions);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button allergyButton;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
    }
}

