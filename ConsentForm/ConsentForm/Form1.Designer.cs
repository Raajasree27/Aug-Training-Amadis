namespace ConsentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.activity = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButtonDesign = new System.Windows.Forms.RadioButton();
            this.radioButtonDebugging = new System.Windows.Forms.RadioButton();
            this.radioButtonPhotography = new System.Windows.Forms.RadioButton();
            this.checkBoxConsent = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consent Form ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thulir Skill Contest";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(231, 168);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(231, 218);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(41, 16);
            this.mail.TabIndex = 3;
            this.mail.Text = "Email";
            // 
            // activity
            // 
            this.activity.AutoSize = true;
            this.activity.Location = new System.Drawing.Point(234, 268);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(41, 16);
            this.activity.TabIndex = 4;
            this.activity.Text = "Event";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(332, 161);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(245, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(332, 218);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(245, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // radioButtonDesign
            // 
            this.radioButtonDesign.AutoSize = true;
            this.radioButtonDesign.Location = new System.Drawing.Point(329, 268);
            this.radioButtonDesign.Name = "radioButtonDesign";
            this.radioButtonDesign.Size = new System.Drawing.Size(71, 20);
            this.radioButtonDesign.TabIndex = 7;
            this.radioButtonDesign.TabStop = true;
            this.radioButtonDesign.Text = "Design";
            this.radioButtonDesign.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebugging
            // 
            this.radioButtonDebugging.AutoSize = true;
            this.radioButtonDebugging.Location = new System.Drawing.Point(329, 306);
            this.radioButtonDebugging.Name = "radioButtonDebugging";
            this.radioButtonDebugging.Size = new System.Drawing.Size(95, 20);
            this.radioButtonDebugging.TabIndex = 8;
            this.radioButtonDebugging.TabStop = true;
            this.radioButtonDebugging.Text = "Debugging";
            this.radioButtonDebugging.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhotography
            // 
            this.radioButtonPhotography.AutoSize = true;
            this.radioButtonPhotography.Location = new System.Drawing.Point(329, 341);
            this.radioButtonPhotography.Name = "radioButtonPhotography";
            this.radioButtonPhotography.Size = new System.Drawing.Size(105, 20);
            this.radioButtonPhotography.TabIndex = 9;
            this.radioButtonPhotography.TabStop = true;
            this.radioButtonPhotography.Text = "Photography";
            this.radioButtonPhotography.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsent
            // 
            this.checkBoxConsent.AutoSize = true;
            this.checkBoxConsent.Location = new System.Drawing.Point(181, 379);
            this.checkBoxConsent.Name = "checkBoxConsent";
            this.checkBoxConsent.Size = new System.Drawing.Size(446, 52);
            this.checkBoxConsent.TabIndex = 10;
            this.checkBoxConsent.Text = "I hereby declare that I have read and understood the contest \r\nparticipation poli" +
    "cy.  I give consent for the contest organizers to use my \r\ninformation for repor" +
    "ting and documentation purposes.";
            this.checkBoxConsent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxConsent.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(279, 448);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(178, 39);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxConsent);
            this.Controls.Add(this.radioButtonPhotography);
            this.Controls.Add(this.radioButtonDebugging);
            this.Controls.Add(this.radioButtonDesign);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.activity);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label activity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.RadioButton radioButtonDesign;
        private System.Windows.Forms.RadioButton radioButtonDebugging;
        private System.Windows.Forms.RadioButton radioButtonPhotography;
        private System.Windows.Forms.CheckBox checkBoxConsent;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

