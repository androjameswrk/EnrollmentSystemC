namespace EnrollmentSystemProject
{
    partial class ListSubjectForm
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
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.cbYearLevel = new System.Windows.Forms.ComboBox();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProgram
            // 
            this.cbProgram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(662, 97);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(186, 23);
            this.cbProgram.TabIndex = 0;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Location = new System.Drawing.Point(10, 142);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowTemplate.Height = 25;
            this.SubjectDataGridView.Size = new System.Drawing.Size(527, 296);
            this.SubjectDataGridView.TabIndex = 2;
            this.SubjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectDataGridView_CellClick);
            this.SubjectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectDataGridView_CellContentClick);
            // 
            // cbYearLevel
            // 
            this.cbYearLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbYearLevel.FormattingEnabled = true;
            this.cbYearLevel.Location = new System.Drawing.Point(662, 51);
            this.cbYearLevel.Name = "cbYearLevel";
            this.cbYearLevel.Size = new System.Drawing.Size(186, 23);
            this.cbYearLevel.TabIndex = 5;
            // 
            // cbTerm
            // 
            this.cbTerm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(662, 11);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(186, 23);
            this.cbTerm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(594, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(582, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Term:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(567, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(567, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Course Code:";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubject.Location = new System.Drawing.Point(567, 229);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(281, 23);
            this.txtSubject.TabIndex = 14;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.Location = new System.Drawing.Point(567, 289);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(281, 23);
            this.txtCode.TabIndex = 15;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = global::EnrollmentSystemProject.Properties.Resources.MAK_College_Davao__3_;
            this.btnAddSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSubject.Location = new System.Drawing.Point(567, 390);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(133, 48);
            this.btnAddSubject.TabIndex = 16;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackgroundImage = global::EnrollmentSystemProject.Properties.Resources.MAK_College_Davao__3_;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteSubject.Location = new System.Drawing.Point(714, 390);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(134, 48);
            this.btnDeleteSubject.TabIndex = 17;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(567, 171);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(281, 23);
            this.txtID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(567, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnrollmentSystemProject.Properties.Resources.MAK_College_Davao__4_;
            this.pictureBox1.Location = new System.Drawing.Point(63, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EnrollmentSystemProject.Properties.Resources.MAK_College_Davao__2_2;
            this.pictureBox2.Location = new System.Drawing.Point(158, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // txtUnits
            // 
            this.txtUnits.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUnits.Location = new System.Drawing.Point(567, 345);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(281, 23);
            this.txtUnits.TabIndex = 109;
            this.txtUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnits_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(567, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "Units:";
            // 
            // ListSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.cbYearLevel);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.cbProgram);
            this.Name = "ListSubjectForm";
            this.Text = "ListSubjectForm";
            this.Load += new System.EventHandler(this.ListSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbProgram;
        private ComboBox cbYearLevel;
        private ComboBox cbTerm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSubject;
        private TextBox txtCode;
        private Button btnAddSubject;
        private Button btnDeleteSubject;
        private TextBox txtID;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public DataGridView SubjectDataGridView;
        private TextBox txtUnits;
        private Label label7;
    }
}