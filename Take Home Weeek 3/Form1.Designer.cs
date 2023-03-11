namespace Take_Home_Weeek_3
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phoneNum = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.butt_submit = new System.Windows.Forms.Button();
            this.butt_clear = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(62, 107);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(62, 150);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(46, 20);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "Age:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(62, 197);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(58, 20);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            // 
            // label_phoneNum
            // 
            this.label_phoneNum.AutoSize = true;
            this.label_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNum.Location = new System.Drawing.Point(62, 254);
            this.label_phoneNum.Name = "label_phoneNum";
            this.label_phoneNum.Size = new System.Drawing.Size(132, 20);
            this.label_phoneNum.TabIndex = 3;
            this.label_phoneNum.Text = "Phone Number:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(229, 109);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(229, 152);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 20);
            this.textBox_age.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(229, 199);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Location = new System.Drawing.Point(229, 254);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.Size = new System.Drawing.Size(100, 20);
            this.textBox_phoneNum.TabIndex = 7;
            // 
            // butt_submit
            // 
            this.butt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_submit.Location = new System.Drawing.Point(238, 322);
            this.butt_submit.Name = "butt_submit";
            this.butt_submit.Size = new System.Drawing.Size(75, 23);
            this.butt_submit.TabIndex = 8;
            this.butt_submit.Text = "SUBMIT";
            this.butt_submit.UseVisualStyleBackColor = true;
            this.butt_submit.Click += new System.EventHandler(this.butt_submit_Click);
            // 
            // butt_clear
            // 
            this.butt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_clear.Location = new System.Drawing.Point(91, 322);
            this.butt_clear.Name = "butt_clear";
            this.butt_clear.Size = new System.Drawing.Size(75, 23);
            this.butt_clear.TabIndex = 9;
            this.butt_clear.Text = "CLEAR";
            this.butt_clear.UseVisualStyleBackColor = true;
            this.butt_clear.Click += new System.EventHandler(this.butt_clear_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(109, 47);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(178, 25);
            this.label_welcome.TabIndex = 10;
            this.label_welcome.Text = "Hello, welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.butt_clear);
            this.Controls.Add(this.butt_submit);
            this.Controls.Add(this.textBox_phoneNum);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phoneNum);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phoneNum;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.Button butt_submit;
        private System.Windows.Forms.Button butt_clear;
        private System.Windows.Forms.Label label_welcome;
    }
}

