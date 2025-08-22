namespace WindowsFormsApp1
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Location = new System.Drawing.Point(301, 64);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(358, 31);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Tag = "";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(302, 133);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(358, 37);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(24);
            this.label1.MaximumSize = new System.Drawing.Size(0, 100);
            this.label1.MinimumSize = new System.Drawing.Size(100, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(100, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(24);
            this.label2.MaximumSize = new System.Drawing.Size(0, 100);
            this.label2.MinimumSize = new System.Drawing.Size(100, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12);
            this.label2.Size = new System.Drawing.Size(100, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonSubmit.Location = new System.Drawing.Point(248, 214);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(116, 46);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit\r\n";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

