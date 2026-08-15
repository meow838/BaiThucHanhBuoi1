namespace BaiThucHanhBuoi1
{
    partial class MainForm
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
            this.tentxt = new System.Windows.Forms.TextBox();
            this.xl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.xlsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn :";
            // 
            // tentxt
            // 
            this.tentxt.Location = new System.Drawing.Point(187, 71);
            this.tentxt.Name = "tentxt";
            this.tentxt.Size = new System.Drawing.Size(206, 20);
            this.tentxt.TabIndex = 1;
            this.tentxt.TextChanged += new System.EventHandler(this.tentxt_TextChanged);
            // 
            // xl
            // 
            this.xl.Location = new System.Drawing.Point(187, 103);
            this.xl.Name = "xl";
            this.xl.Size = new System.Drawing.Size(75, 23);
            this.xl.TabIndex = 2;
            this.xl.Text = "Xử lý";
            this.xl.UseVisualStyleBackColor = true;
            this.xl.Click += new System.EventHandler(this.xl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đã nhập  :";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(187, 132);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(206, 20);
            this.txtSaoChep.TabIndex = 4;
           
            // xlsc
            // 
            this.xlsc.Location = new System.Drawing.Point(318, 103);
            this.xlsc.Name = "xlsc";
            this.xlsc.Size = new System.Drawing.Size(75, 23);
            this.xlsc.TabIndex = 5;
            this.xlsc.Text = "Sao chép";
            this.xlsc.UseVisualStyleBackColor = true;
            this.xlsc.Click += new System.EventHandler(this.xlsc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xlsc);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xl);
            this.Controls.Add(this.tentxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tentxt;
        private System.Windows.Forms.Button xl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button xlsc;
    }
}

