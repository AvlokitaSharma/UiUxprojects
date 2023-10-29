namespace Avlokita_Sharma_PictureBox
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
            this.Normal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picAutoSize = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.picStretch = new System.Windows.Forms.PictureBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dIgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretch)).BeginInit();
            this.SuspendLayout();
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(58, 35);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(80, 25);
            this.Normal.TabIndex = 0;
            this.Normal.Text = "Normal";
            this.Normal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Center Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auto Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stretch Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zoom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // picNormal
            // 
            this.picNormal.Location = new System.Drawing.Point(63, 64);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(166, 219);
            this.picNormal.TabIndex = 5;
            this.picNormal.TabStop = false;
            // 
            // picZoom
            // 
            this.picZoom.Location = new System.Drawing.Point(353, 440);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(166, 219);
            this.picZoom.TabIndex = 6;
            this.picZoom.TabStop = false;
            // 
            // picAutoSize
            // 
            this.picAutoSize.Location = new System.Drawing.Point(1103, 64);
            this.picAutoSize.Name = "picAutoSize";
            this.picAutoSize.Size = new System.Drawing.Size(414, 484);
            this.picAutoSize.TabIndex = 7;
            this.picAutoSize.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.Location = new System.Drawing.Point(637, 82);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(363, 303);
            this.picCenter.TabIndex = 8;
            this.picCenter.TabStop = false;
            // 
            // picStretch
            // 
            this.picStretch.Location = new System.Drawing.Point(63, 373);
            this.picStretch.Name = "picStretch";
            this.picStretch.Size = new System.Drawing.Size(166, 219);
            this.picStretch.TabIndex = 9;
            this.picStretch.TabStop = false;
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(622, 517);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(166, 31);
            this.txtSize.TabIndex = 10;
            this.txtSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelect.Location = new System.Drawing.Point(0, 665);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(1578, 59);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dIgOpen
            // 
            this.dIgOpen.FileName = "openFileDialog1";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 724);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.picStretch);
            this.Controls.Add(this.picCenter);
            this.Controls.Add(this.picAutoSize);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.picNormal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Normal);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Normal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.PictureBox picAutoSize;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.PictureBox picStretch;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog dIgOpen;
    }
}

