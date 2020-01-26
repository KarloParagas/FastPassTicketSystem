﻿namespace FastPassTicketSystem
{
    partial class TitleBar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuestsEnterLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextEntryLabel = new System.Windows.Forms.Label();
            this.TotalTicketsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IssueTicketBtn = new System.Windows.Forms.Button();
            this.TitleBarTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(34, 627);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(725, 376);
            this.listBox1.TabIndex = 0;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Location = new System.Drawing.Point(34, 1036);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(260, 55);
            this.OptionsBtn.TabIndex = 1;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(499, 1036);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(260, 55);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuestsEnterLabel);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // GuestsEnterLabel
            // 
            this.GuestsEnterLabel.Location = new System.Drawing.Point(16, 83);
            this.GuestsEnterLabel.Name = "GuestsEnterLabel";
            this.GuestsEnterLabel.Size = new System.Drawing.Size(244, 32);
            this.GuestsEnterLabel.TabIndex = 6;
            this.GuestsEnterLabel.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextEntryLabel);
            this.groupBox2.Controls.Add(this.TotalTicketsLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(34, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 287);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // NextEntryLabel
            // 
            this.NextEntryLabel.Location = new System.Drawing.Point(374, 175);
            this.NextEntryLabel.Name = "NextEntryLabel";
            this.NextEntryLabel.Size = new System.Drawing.Size(240, 38);
            this.NextEntryLabel.TabIndex = 3;
            this.NextEntryLabel.Text = "0";
            this.NextEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTicketsLabel
            // 
            this.TotalTicketsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalTicketsLabel.Location = new System.Drawing.Point(374, 78);
            this.TotalTicketsLabel.Name = "TotalTicketsLabel";
            this.TotalTicketsLabel.Size = new System.Drawing.Size(240, 38);
            this.TotalTicketsLabel.TabIndex = 2;
            this.TotalTicketsLabel.Text = "0";
            this.TotalTicketsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Next available entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // IssueTicketBtn
            // 
            this.IssueTicketBtn.Location = new System.Drawing.Point(34, 544);
            this.IssueTicketBtn.Name = "IssueTicketBtn";
            this.IssueTicketBtn.Size = new System.Drawing.Size(299, 55);
            this.IssueTicketBtn.TabIndex = 5;
            this.IssueTicketBtn.Text = "Issue Ticket";
            this.IssueTicketBtn.UseVisualStyleBackColor = true;
            // 
            // TitleBarTime
            // 
            this.TitleBarTime.Interval = 1000;
            this.TitleBarTime.Tick += new System.EventHandler(this.TitleBarTime_Tick);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 1103);
            this.Controls.Add(this.IssueTicketBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "TitleBar";
            this.Text = "Time Display";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label GuestsEnterLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IssueTicketBtn;
        private System.Windows.Forms.Label NextEntryLabel;
        private System.Windows.Forms.Label TotalTicketsLabel;
        private System.Windows.Forms.Timer TitleBarTime;
    }
}

