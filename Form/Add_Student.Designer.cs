
namespace ICT710_Assig3_School_Manager
{
    partial class Add_Student
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
            this.nameLBL = new System.Windows.Forms.Label();
            this.sidLBL = new System.Windows.Forms.Label();
            this.addressLBL = new System.Windows.Forms.Label();
            this.dobLBL = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.sidTXT = new System.Windows.Forms.TextBox();
            this.addressTXT = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.addBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Location = new System.Drawing.Point(12, 9);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(42, 15);
            this.nameLBL.TabIndex = 6;
            this.nameLBL.Text = "Name:";
            // 
            // sidLBL
            // 
            this.sidLBL.AutoSize = true;
            this.sidLBL.Location = new System.Drawing.Point(12, 38);
            this.sidLBL.Name = "sidLBL";
            this.sidLBL.Size = new System.Drawing.Size(65, 15);
            this.sidLBL.TabIndex = 7;
            this.sidLBL.Text = "Student ID:";
            // 
            // addressLBL
            // 
            this.addressLBL.AutoSize = true;
            this.addressLBL.Location = new System.Drawing.Point(12, 67);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(52, 15);
            this.addressLBL.TabIndex = 8;
            this.addressLBL.Text = "Address:";
            // 
            // dobLBL
            // 
            this.dobLBL.AutoSize = true;
            this.dobLBL.Location = new System.Drawing.Point(12, 99);
            this.dobLBL.Name = "dobLBL";
            this.dobLBL.Size = new System.Drawing.Size(54, 15);
            this.dobLBL.TabIndex = 9;
            this.dobLBL.Text = "Birthday:";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(87, 6);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(200, 23);
            this.nameTXT.TabIndex = 0;
            // 
            // sidTXT
            // 
            this.sidTXT.Location = new System.Drawing.Point(87, 35);
            this.sidTXT.Name = "sidTXT";
            this.sidTXT.Size = new System.Drawing.Size(200, 23);
            this.sidTXT.TabIndex = 1;
            // 
            // addressTXT
            // 
            this.addressTXT.Location = new System.Drawing.Point(87, 64);
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.Size = new System.Drawing.Size(200, 23);
            this.addressTXT.TabIndex = 2;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(87, 93);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 23);
            this.dob.TabIndex = 3;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(12, 122);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 4;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(93, 122);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 5;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 155);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.addressTXT);
            this.Controls.Add(this.sidTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.dobLBL);
            this.Controls.Add(this.addressLBL);
            this.Controls.Add(this.sidLBL);
            this.Controls.Add(this.nameLBL);
            this.Name = "Add_Student";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label sidLBL;
        private System.Windows.Forms.Label addressLBL;
        private System.Windows.Forms.Label dobLBL;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button cancelBTN;
        public System.Windows.Forms.TextBox nameTXT;
        public System.Windows.Forms.TextBox sidTXT;
        public System.Windows.Forms.TextBox addressTXT;
        public System.Windows.Forms.DateTimePicker dob;
    }
}