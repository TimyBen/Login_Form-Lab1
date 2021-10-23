
namespace Lab_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(223, 58);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(139, 32);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(257, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(383, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed By Benedict.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ibtxt
            // 
            this.ibtxt.AutoSize = true;
            this.ibtxt.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtxt.Location = new System.Drawing.Point(135, 145);
            this.ibtxt.Name = "ibtxt";
            this.ibtxt.Size = new System.Drawing.Size(162, 22);
            this.ibtxt.TabIndex = 4;
            this.ibtxt.Text = "To_Be_Updated";
            this.ibtxt.Visible = false;
            this.ibtxt.Click += new System.EventHandler(this.ibtxt_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.ibtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Frist App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ibtxt;
    }
}

