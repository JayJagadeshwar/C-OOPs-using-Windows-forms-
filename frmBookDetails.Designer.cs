namespace Jay_7_OOPS_windows_forms
{
    partial class frmBookDetails
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
            this.t = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBookDetails = new System.Windows.Forms.ComboBox();
            this.txtNoofBooks = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmdSave_Click = new System.Windows.Forms.Button();
            this.cmdSearch_Click = new System.Windows.Forms.Button();
            this.cmdDelete_Click = new System.Windows.Forms.Button();
            this.cmdUpdate_Click = new System.Windows.Forms.Button();
            this.cmdBookMaster_Click = new System.Windows.Forms.Button();
            this.dgBookDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookDetails";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Books";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(133, 86);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(111, 24);
            this.t.TabIndex = 2;
            this.t.Text = "Book Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total is";
            // 
            // comBookDetails
            // 
            this.comBookDetails.FormattingEnabled = true;
            this.comBookDetails.Location = new System.Drawing.Point(290, 9);
            this.comBookDetails.Name = "comBookDetails";
            this.comBookDetails.Size = new System.Drawing.Size(365, 21);
            this.comBookDetails.TabIndex = 4;
            // 
            // txtNoofBooks
            // 
            this.txtNoofBooks.Location = new System.Drawing.Point(290, 51);
            this.txtNoofBooks.Name = "txtNoofBooks";
            this.txtNoofBooks.Size = new System.Drawing.Size(365, 20);
            this.txtNoofBooks.TabIndex = 5;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(290, 91);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(365, 20);
            this.txtBookPrice.TabIndex = 6;
            this.txtBookPrice.Leave += new System.EventHandler(this.TxtBookPrice_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(290, 131);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(365, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // cmdSave_Click
            // 
            this.cmdSave_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave_Click.Location = new System.Drawing.Point(12, 185);
            this.cmdSave_Click.Name = "cmdSave_Click";
            this.cmdSave_Click.Size = new System.Drawing.Size(107, 40);
            this.cmdSave_Click.TabIndex = 8;
            this.cmdSave_Click.Text = "Save";
            this.cmdSave_Click.UseVisualStyleBackColor = true;
            this.cmdSave_Click.Click += new System.EventHandler(this.CmdSave_Click_Click);
            // 
            // cmdSearch_Click
            // 
            this.cmdSearch_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch_Click.Location = new System.Drawing.Point(149, 185);
            this.cmdSearch_Click.Name = "cmdSearch_Click";
            this.cmdSearch_Click.Size = new System.Drawing.Size(107, 40);
            this.cmdSearch_Click.TabIndex = 9;
            this.cmdSearch_Click.Text = "Search";
            this.cmdSearch_Click.UseVisualStyleBackColor = true;
            this.cmdSearch_Click.Click += new System.EventHandler(this.CmdSearch_Click_Click);
            // 
            // cmdDelete_Click
            // 
            this.cmdDelete_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete_Click.Location = new System.Drawing.Point(317, 185);
            this.cmdDelete_Click.Name = "cmdDelete_Click";
            this.cmdDelete_Click.Size = new System.Drawing.Size(107, 40);
            this.cmdDelete_Click.TabIndex = 10;
            this.cmdDelete_Click.Text = "Delete";
            this.cmdDelete_Click.UseVisualStyleBackColor = true;
            this.cmdDelete_Click.Click += new System.EventHandler(this.CmdDelete_Click_Click);
            // 
            // cmdUpdate_Click
            // 
            this.cmdUpdate_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate_Click.Location = new System.Drawing.Point(464, 185);
            this.cmdUpdate_Click.Name = "cmdUpdate_Click";
            this.cmdUpdate_Click.Size = new System.Drawing.Size(107, 40);
            this.cmdUpdate_Click.TabIndex = 11;
            this.cmdUpdate_Click.Text = "Update";
            this.cmdUpdate_Click.UseVisualStyleBackColor = true;
            this.cmdUpdate_Click.Click += new System.EventHandler(this.CmdUpdate_Click_Click);
            // 
            // cmdBookMaster_Click
            // 
            this.cmdBookMaster_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBookMaster_Click.Location = new System.Drawing.Point(613, 175);
            this.cmdBookMaster_Click.Name = "cmdBookMaster_Click";
            this.cmdBookMaster_Click.Size = new System.Drawing.Size(175, 60);
            this.cmdBookMaster_Click.TabIndex = 12;
            this.cmdBookMaster_Click.Text = "Calling Book Master";
            this.cmdBookMaster_Click.UseVisualStyleBackColor = true;
            this.cmdBookMaster_Click.Click += new System.EventHandler(this.CmdBookMaster_Click_Click);
            // 
            // dgBookDetails
            // 
            this.dgBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookDetails.Location = new System.Drawing.Point(74, 253);
            this.dgBookDetails.Name = "dgBookDetails";
            this.dgBookDetails.Size = new System.Drawing.Size(656, 169);
            this.dgBookDetails.TabIndex = 13;
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBookDetails);
            this.Controls.Add(this.cmdBookMaster_Click);
            this.Controls.Add(this.cmdUpdate_Click);
            this.Controls.Add(this.cmdDelete_Click);
            this.Controls.Add(this.cmdSearch_Click);
            this.Controls.Add(this.cmdSave_Click);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtNoofBooks);
            this.Controls.Add(this.comBookDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBookDetails";
            this.Text = "frmBookDetails";
            this.Load += new System.EventHandler(this.FrmBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBookDetails;
        private System.Windows.Forms.TextBox txtNoofBooks;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button cmdSave_Click;
        private System.Windows.Forms.Button cmdSearch_Click;
        private System.Windows.Forms.Button cmdDelete_Click;
        private System.Windows.Forms.Button cmdUpdate_Click;
        private System.Windows.Forms.Button cmdBookMaster_Click;
        private System.Windows.Forms.DataGridView dgBookDetails;
    }
}