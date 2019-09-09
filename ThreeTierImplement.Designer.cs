namespace Jay_7_OOPS_windows_forms
{
    partial class ThreeTierImplement
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdSave_Click = new System.Windows.Forms.Button();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "StudentId ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maths";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Science";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Scocial ";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(178, 15);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(183, 20);
            this.txtStudentId.TabIndex = 14;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(178, 51);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(183, 20);
            this.txtStudentName.TabIndex = 15;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(178, 93);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(183, 20);
            this.txtMaths.TabIndex = 16;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(178, 135);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(183, 20);
            this.txtScience.TabIndex = 17;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(178, 178);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(183, 20);
            this.txtSocial.TabIndex = 18;
            this.txtSocial.Leave += new System.EventHandler(this.TxtSocial_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(547, 111);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(183, 20);
            this.txtGrade.TabIndex = 26;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(547, 69);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(183, 20);
            this.txtResult.TabIndex = 25;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(547, 33);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(183, 20);
            this.txtAverage.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Average";
            // 
            // cmdSave_Click
            // 
            this.cmdSave_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave_Click.Location = new System.Drawing.Point(414, 153);
            this.cmdSave_Click.Name = "cmdSave_Click";
            this.cmdSave_Click.Size = new System.Drawing.Size(107, 40);
            this.cmdSave_Click.TabIndex = 27;
            this.cmdSave_Click.Text = "Save";
            this.cmdSave_Click.UseVisualStyleBackColor = true;
            this.cmdSave_Click.Click += new System.EventHandler(this.CmdSave_Click_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(591, 153);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(107, 40);
            this.cmdSearch.TabIndex = 28;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(414, 219);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(107, 40);
            this.cmdUpdate.TabIndex = 29;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(591, 219);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(107, 40);
            this.cmdDelete.TabIndex = 30;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(52, 269);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.Size = new System.Drawing.Size(656, 169);
            this.dgStudent.TabIndex = 31;
            // 
            // ThreeTierImplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cmdSave_Click);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThreeTierImplement";
            this.Text = "ThreeTierImplement";
            this.Load += new System.EventHandler(this.ThreeTierImplement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdSave_Click;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.DataGridView dgStudent;
    }
}