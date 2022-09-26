namespace Times_Table_num1_and_num2_equals
{
    partial class Form1
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
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.OperatorList = new System.Windows.Forms.ComboBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(172, 220);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 23);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(282, 220);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 23);
            this.txtAnswer.TabIndex = 1;
            // 
            // OperatorList
            // 
            this.OperatorList.FormattingEnabled = true;
            this.OperatorList.Items.AddRange(new object[] {
            "+",
            "-",
            "X",
            "/"});
            this.OperatorList.Location = new System.Drawing.Point(141, 77);
            this.OperatorList.Name = "OperatorList";
            this.OperatorList.Size = new System.Drawing.Size(121, 23);
            this.OperatorList.TabIndex = 2;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(25, 31);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 23);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(282, 129);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 23);
            this.txtNum2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 290);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.OperatorList);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnEquals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEquals;
        private TextBox txtAnswer;
        private ComboBox OperatorList;
        private TextBox txtNum1;
        private TextBox txtNum2;
    }
}