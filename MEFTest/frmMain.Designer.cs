﻿namespace MEFTest
{
    partial class FrmMain
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
            this.lstDriversList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstAlarms = new System.Windows.Forms.ListBox();
            this.btnGetAlarms = new System.Windows.Forms.Button();
            this.lstLoadedDrivers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDriversList
            // 
            this.lstDriversList.FormattingEnabled = true;
            this.lstDriversList.Location = new System.Drawing.Point(8, 30);
            this.lstDriversList.Margin = new System.Windows.Forms.Padding(2);
            this.lstDriversList.Name = "lstDriversList";
            this.lstDriversList.Size = new System.Drawing.Size(191, 199);
            this.lstDriversList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Drivers:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(214, 30);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 67);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "&Load >";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lstAlarms
            // 
            this.lstAlarms.FormattingEnabled = true;
            this.lstAlarms.Location = new System.Drawing.Point(605, 30);
            this.lstAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.lstAlarms.Name = "lstAlarms";
            this.lstAlarms.Size = new System.Drawing.Size(191, 199);
            this.lstAlarms.TabIndex = 0;
            // 
            // btnGetAlarms
            // 
            this.btnGetAlarms.Location = new System.Drawing.Point(512, 91);
            this.btnGetAlarms.Name = "btnGetAlarms";
            this.btnGetAlarms.Size = new System.Drawing.Size(79, 67);
            this.btnGetAlarms.TabIndex = 3;
            this.btnGetAlarms.Text = "&Get Alarms";
            this.btnGetAlarms.UseVisualStyleBackColor = true;
            this.btnGetAlarms.Click += new System.EventHandler(this.BtnGetAlarms_Click);
            // 
            // lstLoadedDrivers
            // 
            this.lstLoadedDrivers.FormattingEnabled = true;
            this.lstLoadedDrivers.Location = new System.Drawing.Point(306, 30);
            this.lstLoadedDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.lstLoadedDrivers.Name = "lstLoadedDrivers";
            this.lstLoadedDrivers.Size = new System.Drawing.Size(191, 199);
            this.lstLoadedDrivers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loaded Drivers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alarms:";
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(214, 114);
            this.btnUnload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(76, 67);
            this.btnUnload.TabIndex = 2;
            this.btnUnload.Text = "< &Unload";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 250);
            this.Controls.Add(this.btnGetAlarms);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAlarms);
            this.Controls.Add(this.lstLoadedDrivers);
            this.Controls.Add(this.lstDriversList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEFTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDriversList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstAlarms;
        private System.Windows.Forms.Button btnGetAlarms;
        private System.Windows.Forms.ListBox lstLoadedDrivers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnload;
    }
}

