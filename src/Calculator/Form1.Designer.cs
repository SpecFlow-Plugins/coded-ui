namespace Calculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.eLeft = new System.Windows.Forms.TextBox();
            this.eRight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // eLeft
            // 
            this.eLeft.Location = new System.Drawing.Point(13, 44);
            this.eLeft.Name = "eLeft";
            this.eLeft.Size = new System.Drawing.Size(100, 20);
            this.eLeft.TabIndex = 2;
            this.eLeft.Text = "0";
            this.eLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eRight
            // 
            this.eRight.Location = new System.Drawing.Point(12, 70);
            this.eRight.Name = "eRight";
            this.eRight.Size = new System.Drawing.Size(100, 20);
            this.eRight.TabIndex = 3;
            this.eRight.Text = "0";
            this.eRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(150, 60);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(13, 13);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 147);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eRight);
            this.Controls.Add(this.eLeft);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox eLeft;
        private System.Windows.Forms.TextBox eRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResult;
    }
}

