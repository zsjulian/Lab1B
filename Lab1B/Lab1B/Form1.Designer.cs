namespace Lab1B
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRevA = new System.Windows.Forms.TextBox();
            this.txtRevB = new System.Windows.Forms.TextBox();
            this.txtRevC = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tickets Sold:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(156, 26);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter the number of tickets sold\r\n for each class of seats";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 151);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Class A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class C:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(63, 144);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(100, 20);
            this.txtClassA.TabIndex = 5;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(63, 181);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(100, 20);
            this.txtClassB.TabIndex = 6;
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(63, 227);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(100, 20);
            this.txtClassC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Revenue Generated:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            // 
            // txtRevA
            // 
            this.txtRevA.Location = new System.Drawing.Point(463, 151);
            this.txtRevA.Name = "txtRevA";
            this.txtRevA.ReadOnly = true;
            this.txtRevA.Size = new System.Drawing.Size(100, 20);
            this.txtRevA.TabIndex = 13;
            // 
            // txtRevB
            // 
            this.txtRevB.Location = new System.Drawing.Point(463, 188);
            this.txtRevB.Name = "txtRevB";
            this.txtRevB.ReadOnly = true;
            this.txtRevB.Size = new System.Drawing.Size(100, 20);
            this.txtRevB.TabIndex = 14;
            // 
            // txtRevC
            // 
            this.txtRevC.Location = new System.Drawing.Point(463, 234);
            this.txtRevC.Name = "txtRevC";
            this.txtRevC.ReadOnly = true;
            this.txtRevC.Size = new System.Drawing.Size(100, 20);
            this.txtRevC.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(463, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(179, 353);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 63);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate Revenue:";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 63);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 63);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRevC);
            this.Controls.Add(this.txtRevB);
            this.Controls.Add(this.txtRevA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassC);
            this.Controls.Add(this.txtClassB);
            this.Controls.Add(this.txtClassA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Stadium Seating ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRevA;
        private System.Windows.Forms.TextBox txtRevB;
        private System.Windows.Forms.TextBox txtRevC;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

