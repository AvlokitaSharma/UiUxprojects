namespace Avlokita_Sharma_OddNumbers
{
    partial class frmMainForm
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
            this.txtTargetSum = new System.Windows.Forms.TextBox();
            this.txtNumberOfintegers = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnSumIntegers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTargetSum
            // 
            this.txtTargetSum.BackColor = System.Drawing.Color.MistyRose;
            this.txtTargetSum.Location = new System.Drawing.Point(50, 83);
            this.txtTargetSum.Name = "txtTargetSum";
            this.txtTargetSum.Size = new System.Drawing.Size(147, 20);
            this.txtTargetSum.TabIndex = 0;
            this.txtTargetSum.TextChanged += new System.EventHandler(this.txtTargetSum_TextChanged);
            // 
            // txtNumberOfintegers
            // 
            this.txtNumberOfintegers.BackColor = System.Drawing.Color.MistyRose;
            this.txtNumberOfintegers.Enabled = false;
            this.txtNumberOfintegers.Location = new System.Drawing.Point(50, 227);
            this.txtNumberOfintegers.Name = "txtNumberOfintegers";
            this.txtNumberOfintegers.Size = new System.Drawing.Size(147, 20);
            this.txtNumberOfintegers.TabIndex = 1;
            this.txtNumberOfintegers.TextChanged += new System.EventHandler(this.txtNumberOfintegers_TextChanged);
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.MistyRose;
            this.txtSum.Enabled = false;
            this.txtSum.Location = new System.Drawing.Point(50, 371);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(147, 20);
            this.txtSum.TabIndex = 2;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // btnSumIntegers
            // 
            this.btnSumIntegers.BackColor = System.Drawing.Color.Salmon;
            this.btnSumIntegers.Location = new System.Drawing.Point(484, 218);
            this.btnSumIntegers.Name = "btnSumIntegers";
            this.btnSumIntegers.Size = new System.Drawing.Size(156, 29);
            this.btnSumIntegers.TabIndex = 3;
            this.btnSumIntegers.Text = "to Sum Integers";
            this.btnSumIntegers.UseVisualStyleBackColor = false;
            this.btnSumIntegers.Click += new System.EventHandler(this.btnSumIntegers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Sum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Integers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumIntegers);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtNumberOfintegers);
            this.Controls.Add(this.txtTargetSum);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avlokita_Sharma_OddNumbers";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetSum;
        private System.Windows.Forms.TextBox txtNumberOfintegers;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnSumIntegers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

