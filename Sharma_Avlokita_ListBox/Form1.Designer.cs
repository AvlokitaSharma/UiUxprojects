namespace Sharma_Avlokita_ListBox
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstLeft.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 25;
            this.lstLeft.Location = new System.Drawing.Point(61, 12);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLeft.Size = new System.Drawing.Size(276, 479);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 25;
            this.lstRight.Location = new System.Drawing.Point(471, 12);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(276, 479);
            this.lstRight.TabIndex = 1;
            this.lstRight.DoubleClick += new System.EventHandler(this.lstRight_DoubleClick);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Gold;
            this.btnMove.Location = new System.Drawing.Point(295, 537);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(219, 58);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move Selected Items";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(797, 639);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmMainForm_CausesValidationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnMove;
    }
}

