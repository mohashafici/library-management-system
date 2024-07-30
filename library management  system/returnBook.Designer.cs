namespace library_management_system
{
    partial class returnBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTReturn = new System.Windows.Forms.DateTimePicker();
            this.txtBorrowId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBookCondition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRETURN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Borrowing ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "DateReturn";
            // 
            // DTReturn
            // 
            this.DTReturn.Location = new System.Drawing.Point(213, 197);
            this.DTReturn.Name = "DTReturn";
            this.DTReturn.Size = new System.Drawing.Size(200, 20);
            this.DTReturn.TabIndex = 25;
            // 
            // txtBorrowId
            // 
            this.txtBorrowId.Location = new System.Drawing.Point(222, 106);
            this.txtBorrowId.Name = "txtBorrowId";
            this.txtBorrowId.Size = new System.Drawing.Size(126, 20);
            this.txtBorrowId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "RETURN BOOK FORM";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "RETURN BOOK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Book Condition";
            // 
            // cmBookCondition
            // 
            this.cmBookCondition.FormattingEnabled = true;
            this.cmBookCondition.Items.AddRange(new object[] {
            "Good",
            "Fair",
            "Damaged"});
            this.cmBookCondition.Location = new System.Drawing.Point(222, 150);
            this.cmBookCondition.Name = "cmBookCondition";
            this.cmBookCondition.Size = new System.Drawing.Size(121, 21);
            this.cmBookCondition.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Return ID";
            // 
            // txtRETURN
            // 
            this.txtRETURN.Location = new System.Drawing.Point(222, 80);
            this.txtRETURN.Name = "txtRETURN";
            this.txtRETURN.Size = new System.Drawing.Size(126, 20);
            this.txtRETURN.TabIndex = 31;
            // 
            // returnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(585, 323);
            this.Controls.Add(this.txtRETURN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmBookCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTReturn);
            this.Controls.Add(this.txtBorrowId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "returnBook";
            this.Text = "returnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTReturn;
        private System.Windows.Forms.TextBox txtBorrowId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBookCondition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRETURN;
    }
}