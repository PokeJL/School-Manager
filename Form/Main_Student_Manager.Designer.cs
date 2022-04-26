
namespace ICT710_Assig3_School_Manager
{
    partial class Main_Student_Manager
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
            this.addStudentBTN = new System.Windows.Forms.Button();
            this.updateStudentBTN = new System.Windows.Forms.Button();
            this.loadBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.infoViewerTXB = new System.Windows.Forms.TextBox();
            this.studentSelectCB = new System.Windows.Forms.ComboBox();
            this.viewerLBL = new System.Windows.Forms.Label();
            this.selectLBL = new System.Windows.Forms.Label();
            this.deleteAllStudentsBTN = new System.Windows.Forms.Button();
            this.deleteStudentBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // addStudentBTN
            // 
            this.addStudentBTN.Location = new System.Drawing.Point(12, 42);
            this.addStudentBTN.Name = "addStudentBTN";
            this.addStudentBTN.Size = new System.Drawing.Size(97, 23);
            this.addStudentBTN.TabIndex = 0;
            this.addStudentBTN.Text = "&Add Student";
            this.addStudentBTN.UseVisualStyleBackColor = true;
            this.addStudentBTN.Click += new System.EventHandler(this.addStudentBTN_Click);
            // 
            // updateStudentBTN
            // 
            this.updateStudentBTN.Enabled = false;
            this.updateStudentBTN.Location = new System.Drawing.Point(12, 71);
            this.updateStudentBTN.Name = "updateStudentBTN";
            this.updateStudentBTN.Size = new System.Drawing.Size(97, 23);
            this.updateStudentBTN.TabIndex = 2;
            this.updateStudentBTN.Text = "&Update Student";
            this.updateStudentBTN.UseVisualStyleBackColor = true;
            this.updateStudentBTN.Click += new System.EventHandler(this.updateStudentBTN_Click);
            // 
            // loadBTN
            // 
            this.loadBTN.Location = new System.Drawing.Point(12, 216);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(97, 23);
            this.loadBTN.TabIndex = 6;
            this.loadBTN.Text = "&Load";
            this.loadBTN.UseVisualStyleBackColor = true;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Enabled = false;
            this.saveBTN.Location = new System.Drawing.Point(12, 245);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(97, 23);
            this.saveBTN.TabIndex = 7;
            this.saveBTN.Text = "&Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(12, 303);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(97, 23);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "&Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // infoViewerTXB
            // 
            this.infoViewerTXB.Location = new System.Drawing.Point(134, 41);
            this.infoViewerTXB.Multiline = true;
            this.infoViewerTXB.Name = "infoViewerTXB";
            this.infoViewerTXB.ReadOnly = true;
            this.infoViewerTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoViewerTXB.Size = new System.Drawing.Size(310, 373);
            this.infoViewerTXB.TabIndex = 3;
            this.infoViewerTXB.Text = "Student Information...";
            // 
            // studentSelectCB
            // 
            this.studentSelectCB.FormattingEnabled = true;
            this.studentSelectCB.Location = new System.Drawing.Point(450, 42);
            this.studentSelectCB.Name = "studentSelectCB";
            this.studentSelectCB.Size = new System.Drawing.Size(160, 23);
            this.studentSelectCB.TabIndex = 1;
            this.studentSelectCB.SelectedIndexChanged += new System.EventHandler(this.studentSelectCB_SelectedIndexChanged);
            // 
            // viewerLBL
            // 
            this.viewerLBL.AutoSize = true;
            this.viewerLBL.Location = new System.Drawing.Point(134, 16);
            this.viewerLBL.Name = "viewerLBL";
            this.viewerLBL.Size = new System.Drawing.Size(89, 15);
            this.viewerLBL.TabIndex = 9;
            this.viewerLBL.Text = "Student Viewer:";
            // 
            // selectLBL
            // 
            this.selectLBL.AutoSize = true;
            this.selectLBL.Location = new System.Drawing.Point(450, 16);
            this.selectLBL.Name = "selectLBL";
            this.selectLBL.Size = new System.Drawing.Size(85, 15);
            this.selectLBL.TabIndex = 10;
            this.selectLBL.Text = "Select Student:";
            // 
            // deleteAllStudentsBTN
            // 
            this.deleteAllStudentsBTN.Enabled = false;
            this.deleteAllStudentsBTN.Location = new System.Drawing.Point(12, 158);
            this.deleteAllStudentsBTN.Name = "deleteAllStudentsBTN";
            this.deleteAllStudentsBTN.Size = new System.Drawing.Size(97, 23);
            this.deleteAllStudentsBTN.TabIndex = 5;
            this.deleteAllStudentsBTN.Text = "Delete All";
            this.deleteAllStudentsBTN.UseVisualStyleBackColor = true;
            this.deleteAllStudentsBTN.Click += new System.EventHandler(this.deleteAllStudentsBTN_Click);
            // 
            // deleteStudentBTN
            // 
            this.deleteStudentBTN.Enabled = false;
            this.deleteStudentBTN.Location = new System.Drawing.Point(12, 129);
            this.deleteStudentBTN.Name = "deleteStudentBTN";
            this.deleteStudentBTN.Size = new System.Drawing.Size(97, 23);
            this.deleteStudentBTN.TabIndex = 4;
            this.deleteStudentBTN.Text = "&Delete Student";
            this.deleteStudentBTN.UseVisualStyleBackColor = true;
            this.deleteStudentBTN.Click += new System.EventHandler(this.deleteStudentBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main_Student_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBTN;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.deleteStudentBTN);
            this.Controls.Add(this.deleteAllStudentsBTN);
            this.Controls.Add(this.selectLBL);
            this.Controls.Add(this.viewerLBL);
            this.Controls.Add(this.studentSelectCB);
            this.Controls.Add(this.infoViewerTXB);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.loadBTN);
            this.Controls.Add(this.updateStudentBTN);
            this.Controls.Add(this.addStudentBTN);
            this.MaximumSize = new System.Drawing.Size(635, 489);
            this.MinimumSize = new System.Drawing.Size(635, 489);
            this.Name = "Main_Student_Manager";
            this.Text = "Main Student Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentBTN;
        private System.Windows.Forms.Button updateStudentBTN;
        private System.Windows.Forms.Button loadBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox infoViewerTXB;
        private System.Windows.Forms.ComboBox studentSelectCB;
        private System.Windows.Forms.Label viewerLBL;
        private System.Windows.Forms.Label selectLBL;
        private System.Windows.Forms.Button deleteAllStudentsBTN;
        private System.Windows.Forms.Button deleteStudentBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

