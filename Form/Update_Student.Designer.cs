
namespace ICT710_Assig3_School_Manager
{
    partial class Update_Student
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
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.addressTXT = new System.Windows.Forms.TextBox();
            this.sidTXT = new System.Windows.Forms.TextBox();
            this.dobLBL = new System.Windows.Forms.Label();
            this.addressLBL = new System.Windows.Forms.Label();
            this.sidLBL = new System.Windows.Forms.Label();
            this.cNLBL = new System.Windows.Forms.Label();
            this.cNameTXT = new System.Windows.Forms.TextBox();
            this.cMLBL = new System.Windows.Forms.Label();
            this.cMarkTXT = new System.Windows.Forms.TextBox();
            this.deleteCBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.courseSelectCB = new System.Windows.Forms.ComboBox();
            this.addCourseBTN = new System.Windows.Forms.Button();
            this.updateCourseBTN = new System.Windows.Forms.Button();
            this.cSLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Location = new System.Drawing.Point(12, 9);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(42, 15);
            this.nameLBL.TabIndex = 12;
            this.nameLBL.Text = "Name:";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(12, 27);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(200, 23);
            this.nameTXT.TabIndex = 0;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(12, 246);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 23);
            this.dob.TabIndex = 3;
            // 
            // addressTXT
            // 
            this.addressTXT.Location = new System.Drawing.Point(12, 173);
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.Size = new System.Drawing.Size(200, 23);
            this.addressTXT.TabIndex = 2;
            // 
            // sidTXT
            // 
            this.sidTXT.Location = new System.Drawing.Point(12, 100);
            this.sidTXT.Name = "sidTXT";
            this.sidTXT.Size = new System.Drawing.Size(200, 23);
            this.sidTXT.TabIndex = 1;
            // 
            // dobLBL
            // 
            this.dobLBL.AutoSize = true;
            this.dobLBL.Location = new System.Drawing.Point(12, 228);
            this.dobLBL.Name = "dobLBL";
            this.dobLBL.Size = new System.Drawing.Size(54, 15);
            this.dobLBL.TabIndex = 15;
            this.dobLBL.Text = "Birthday:";
            // 
            // addressLBL
            // 
            this.addressLBL.AutoSize = true;
            this.addressLBL.Location = new System.Drawing.Point(12, 155);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(52, 15);
            this.addressLBL.TabIndex = 14;
            this.addressLBL.Text = "Address:";
            // 
            // sidLBL
            // 
            this.sidLBL.AutoSize = true;
            this.sidLBL.Location = new System.Drawing.Point(12, 82);
            this.sidLBL.Name = "sidLBL";
            this.sidLBL.Size = new System.Drawing.Size(65, 15);
            this.sidLBL.TabIndex = 13;
            this.sidLBL.Text = "Student ID:";
            // 
            // cNLBL
            // 
            this.cNLBL.AutoSize = true;
            this.cNLBL.Location = new System.Drawing.Point(263, 82);
            this.cNLBL.Name = "cNLBL";
            this.cNLBL.Size = new System.Drawing.Size(82, 15);
            this.cNLBL.TabIndex = 16;
            this.cNLBL.Text = "Course Name:";
            // 
            // cNameTXT
            // 
            this.cNameTXT.Location = new System.Drawing.Point(263, 100);
            this.cNameTXT.MaximumSize = new System.Drawing.Size(200, 23);
            this.cNameTXT.MinimumSize = new System.Drawing.Size(200, 23);
            this.cNameTXT.Name = "cNameTXT";
            this.cNameTXT.Size = new System.Drawing.Size(200, 23);
            this.cNameTXT.TabIndex = 5;
            // 
            // cMLBL
            // 
            this.cMLBL.AutoSize = true;
            this.cMLBL.Location = new System.Drawing.Point(263, 155);
            this.cMLBL.Name = "cMLBL";
            this.cMLBL.Size = new System.Drawing.Size(77, 15);
            this.cMLBL.TabIndex = 17;
            this.cMLBL.Text = "Course Mark:";
            // 
            // cMarkTXT
            // 
            this.cMarkTXT.Location = new System.Drawing.Point(263, 173);
            this.cMarkTXT.Name = "cMarkTXT";
            this.cMarkTXT.Size = new System.Drawing.Size(200, 23);
            this.cMarkTXT.TabIndex = 6;
            // 
            // deleteCBTN
            // 
            this.deleteCBTN.Enabled = false;
            this.deleteCBTN.Location = new System.Drawing.Point(263, 248);
            this.deleteCBTN.Name = "deleteCBTN";
            this.deleteCBTN.Size = new System.Drawing.Size(97, 23);
            this.deleteCBTN.TabIndex = 9;
            this.deleteCBTN.Text = "Delete Course";
            this.deleteCBTN.UseVisualStyleBackColor = true;
            this.deleteCBTN.Click += new System.EventHandler(this.deleteCBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(12, 319);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(97, 23);
            this.updateBTN.TabIndex = 10;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(115, 319);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(97, 23);
            this.cancelBTN.TabIndex = 11;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // courseSelectCB
            // 
            this.courseSelectCB.FormattingEnabled = true;
            this.courseSelectCB.Location = new System.Drawing.Point(263, 27);
            this.courseSelectCB.Name = "courseSelectCB";
            this.courseSelectCB.Size = new System.Drawing.Size(200, 23);
            this.courseSelectCB.TabIndex = 4;
            this.courseSelectCB.SelectedIndexChanged += new System.EventHandler(this.courseSelectCB_SelectedIndexChanged);
            // 
            // addCourseBTN
            // 
            this.addCourseBTN.Location = new System.Drawing.Point(263, 202);
            this.addCourseBTN.Name = "addCourseBTN";
            this.addCourseBTN.Size = new System.Drawing.Size(97, 23);
            this.addCourseBTN.TabIndex = 7;
            this.addCourseBTN.Text = "Add Course";
            this.addCourseBTN.UseVisualStyleBackColor = true;
            this.addCourseBTN.Click += new System.EventHandler(this.addCourseBTN_Click);
            // 
            // updateCourseBTN
            // 
            this.updateCourseBTN.Location = new System.Drawing.Point(366, 202);
            this.updateCourseBTN.Name = "updateCourseBTN";
            this.updateCourseBTN.Size = new System.Drawing.Size(97, 23);
            this.updateCourseBTN.TabIndex = 8;
            this.updateCourseBTN.Text = "Update Course";
            this.updateCourseBTN.UseVisualStyleBackColor = true;
            this.updateCourseBTN.Click += new System.EventHandler(this.updateCourseBTN_Click);
            // 
            // cSLBL
            // 
            this.cSLBL.AutoSize = true;
            this.cSLBL.Location = new System.Drawing.Point(263, 9);
            this.cSLBL.Name = "cSLBL";
            this.cSLBL.Size = new System.Drawing.Size(81, 15);
            this.cSLBL.TabIndex = 18;
            this.cSLBL.Text = "Course Select:";
            // 
            // Update_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 351);
            this.Controls.Add(this.cSLBL);
            this.Controls.Add(this.updateCourseBTN);
            this.Controls.Add(this.addCourseBTN);
            this.Controls.Add(this.courseSelectCB);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteCBTN);
            this.Controls.Add(this.cMarkTXT);
            this.Controls.Add(this.cMLBL);
            this.Controls.Add(this.cNameTXT);
            this.Controls.Add(this.cNLBL);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.addressTXT);
            this.Controls.Add(this.sidTXT);
            this.Controls.Add(this.dobLBL);
            this.Controls.Add(this.addressLBL);
            this.Controls.Add(this.sidLBL);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.nameLBL);
            this.Name = "Update_Student";
            this.Text = "Update Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label dobLBL;
        private System.Windows.Forms.Label addressLBL;
        private System.Windows.Forms.Label sidLBL;
        private System.Windows.Forms.Label cNLBL;
        private System.Windows.Forms.Label cMLBL;
        private System.Windows.Forms.Button deleteCBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button cancelBTN;
        public System.Windows.Forms.TextBox nameTXT;
        public System.Windows.Forms.DateTimePicker dob;
        public System.Windows.Forms.TextBox addressTXT;
        public System.Windows.Forms.TextBox sidTXT;
        public System.Windows.Forms.TextBox cNameTXT;
        public System.Windows.Forms.TextBox cMarkTXT;
        private System.Windows.Forms.ComboBox courseSelectCB;
        private System.Windows.Forms.Button addCourseBTN;
        private System.Windows.Forms.Button updateCourseBTN;
        private System.Windows.Forms.Label cSLBL;
    }
}