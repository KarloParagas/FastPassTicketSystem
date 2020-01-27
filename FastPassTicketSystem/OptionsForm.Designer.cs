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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinutesPerWindowTxt = new System.Windows.Forms.TextBox();
            this.EndTimeTxt = new System.Windows.Forms.TextBox();
            this.FirstTicketNumTxt = new System.Windows.Forms.TextBox();
            this.StartTimeTxt = new System.Windows.Forms.TextBox();
            this.GuestsPerWindowTxt = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // MinutesPerWindowTxt
            // 
            this.MinutesPerWindowTxt.Location = new System.Drawing.Point(375, 55);
            this.MinutesPerWindowTxt.Name = "MinutesPerWindowTxt";
            this.MinutesPerWindowTxt.Size = new System.Drawing.Size(295, 38);
            this.MinutesPerWindowTxt.TabIndex = 5;
            // 
            // EndTimeTxt
            // 
            this.EndTimeTxt.Location = new System.Drawing.Point(375, 314);
            this.EndTimeTxt.Name = "EndTimeTxt";
            this.EndTimeTxt.Size = new System.Drawing.Size(295, 38);
            this.EndTimeTxt.TabIndex = 6;
            // 
            // FirstTicketNumTxt
            // 
            this.FirstTicketNumTxt.Location = new System.Drawing.Point(375, 400);
            this.FirstTicketNumTxt.Name = "FirstTicketNumTxt";
            this.FirstTicketNumTxt.Size = new System.Drawing.Size(295, 38);
            this.FirstTicketNumTxt.TabIndex = 7;
            // 
            // StartTimeTxt
            // 
            this.StartTimeTxt.Location = new System.Drawing.Point(375, 230);
            this.StartTimeTxt.Name = "StartTimeTxt";
            this.StartTimeTxt.Size = new System.Drawing.Size(295, 38);
            this.StartTimeTxt.TabIndex = 8;
            // 
            // GuestsPerWindowTxt
            // 
            this.GuestsPerWindowTxt.Location = new System.Drawing.Point(375, 139);
            this.GuestsPerWindowTxt.Name = "GuestsPerWindowTxt";
            this.GuestsPerWindowTxt.Size = new System.Drawing.Size(295, 38);
            this.GuestsPerWindowTxt.TabIndex = 9;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(375, 505);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(295, 48);
            this.OkBtn.TabIndex = 10;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 604);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.GuestsPerWindowTxt);
            this.Controls.Add(this.StartTimeTxt);
            this.Controls.Add(this.FirstTicketNumTxt);
            this.Controls.Add(this.EndTimeTxt);
            this.Controls.Add(this.MinutesPerWindowTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinutesPerWindowTxt;
        private System.Windows.Forms.TextBox EndTimeTxt;
        private System.Windows.Forms.TextBox FirstTicketNumTxt;
        private System.Windows.Forms.TextBox StartTimeTxt;
        private System.Windows.Forms.TextBox GuestsPerWindowTxt;
        private System.Windows.Forms.Button OkBtn;
    }
}