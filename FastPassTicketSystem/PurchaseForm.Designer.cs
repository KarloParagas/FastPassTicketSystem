namespace FastPassTicketSystem
{
    partial class PurchaseForm
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
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PurchaseTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(110, 18);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(127, 20);
            this.FirstNameTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(110, 51);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(127, 20);
            this.LastNameTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number:";
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.Location = new System.Drawing.Point(110, 111);
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(127, 20);
            this.PhoneNumberTxt.TabIndex = 3;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(110, 81);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(127, 20);
            this.EmailTxt.TabIndex = 2;
            // 
            // PurchaseTicket
            // 
            this.PurchaseTicket.Location = new System.Drawing.Point(125, 151);
            this.PurchaseTicket.Name = "PurchaseTicket";
            this.PurchaseTicket.Size = new System.Drawing.Size(97, 23);
            this.PurchaseTicket.TabIndex = 4;
            this.PurchaseTicket.Text = "Purchase Ticket";
            this.PurchaseTicket.UseVisualStyleBackColor = true;
            this.PurchaseTicket.Click += new System.EventHandler(this.PurchaseTicket_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 193);
            this.Controls.Add(this.PurchaseTicket);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PhoneNumberTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseForm";
            this.Text = "Purchase Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumberTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Button PurchaseTicket;
    }
}