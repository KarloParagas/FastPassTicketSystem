﻿namespace FastPassTicketSystem
{
    partial class OptionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinutesPerWindowTxt = new System.Windows.Forms.TextBox();
            this.EndTimeTxt = new System.Windows.Forms.TextBox();
            this.StartTimeTxt = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "End time:";
            // 
            // MinutesPerWindowTxt
            // 
            this.MinutesPerWindowTxt.Location = new System.Drawing.Point(141, 23);
            this.MinutesPerWindowTxt.Margin = new System.Windows.Forms.Padding(1);
            this.MinutesPerWindowTxt.Name = "MinutesPerWindowTxt";
            this.MinutesPerWindowTxt.Size = new System.Drawing.Size(113, 20);
            this.MinutesPerWindowTxt.TabIndex = 0;
            // 
            // EndTimeTxt
            // 
            this.EndTimeTxt.Location = new System.Drawing.Point(141, 94);
            this.EndTimeTxt.Margin = new System.Windows.Forms.Padding(1);
            this.EndTimeTxt.Name = "EndTimeTxt";
            this.EndTimeTxt.Size = new System.Drawing.Size(113, 20);
            this.EndTimeTxt.TabIndex = 3;
            // 
            // StartTimeTxt
            // 
            this.StartTimeTxt.Location = new System.Drawing.Point(141, 58);
            this.StartTimeTxt.Margin = new System.Windows.Forms.Padding(1);
            this.StartTimeTxt.Name = "StartTimeTxt";
            this.StartTimeTxt.Size = new System.Drawing.Size(113, 20);
            this.StartTimeTxt.TabIndex = 2;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(141, 136);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(1);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(111, 20);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 177);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.StartTimeTxt);
            this.Controls.Add(this.EndTimeTxt);
            this.Controls.Add(this.MinutesPerWindowTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinutesPerWindowTxt;
        private System.Windows.Forms.TextBox EndTimeTxt;
        private System.Windows.Forms.TextBox StartTimeTxt;
        private System.Windows.Forms.Button OkBtn;
    }
}