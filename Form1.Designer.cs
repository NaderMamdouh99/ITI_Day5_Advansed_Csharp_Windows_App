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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Username_Log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_Log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Male_Log = new System.Windows.Forms.RadioButton();
            this.Female_Log = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Football_choes = new System.Windows.Forms.CheckBox();
            this.Tennis_choes = new System.Windows.Forms.CheckBox();
            this.Swimming_choes = new System.Windows.Forms.CheckBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.Valid_Log = new System.Windows.Forms.Label();
            this.Characters_Least = new System.Windows.Forms.Label();
            this.Email_Least = new System.Windows.Forms.Label();
            this.Hoppy_Least = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Log
            // 
            this.Username_Log.Location = new System.Drawing.Point(135, 16);
            this.Username_Log.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Username_Log.Name = "Username_Log";
            this.Username_Log.Size = new System.Drawing.Size(164, 25);
            this.Username_Log.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // Email_Log
            // 
            this.Email_Log.Location = new System.Drawing.Point(135, 77);
            this.Email_Log.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Email_Log.Name = "Email_Log";
            this.Email_Log.Size = new System.Drawing.Size(164, 25);
            this.Email_Log.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // Male_Log
            // 
            this.Male_Log.AutoSize = true;
            this.Male_Log.Location = new System.Drawing.Point(153, 178);
            this.Male_Log.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Male_Log.Name = "Male_Log";
            this.Male_Log.Size = new System.Drawing.Size(62, 22);
            this.Male_Log.TabIndex = 5;
            this.Male_Log.TabStop = true;
            this.Male_Log.Text = "Male";
            this.Male_Log.UseVisualStyleBackColor = true;
            // 
            // Female_Log
            // 
            this.Female_Log.AutoSize = true;
            this.Female_Log.Location = new System.Drawing.Point(323, 178);
            this.Female_Log.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Female_Log.Name = "Female_Log";
            this.Female_Log.Size = new System.Drawing.Size(80, 22);
            this.Female_Log.TabIndex = 6;
            this.Female_Log.TabStop = true;
            this.Female_Log.Text = "FeMale";
            this.Female_Log.UseVisualStyleBackColor = true;
            this.Female_Log.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoppies :";
            // 
            // Football_choes
            // 
            this.Football_choes.AutoSize = true;
            this.Football_choes.Location = new System.Drawing.Point(126, 267);
            this.Football_choes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Football_choes.Name = "Football_choes";
            this.Football_choes.Size = new System.Drawing.Size(89, 22);
            this.Football_choes.TabIndex = 8;
            this.Football_choes.Text = "Football";
            this.Football_choes.UseVisualStyleBackColor = true;
            // 
            // Tennis_choes
            // 
            this.Tennis_choes.AutoSize = true;
            this.Tennis_choes.Location = new System.Drawing.Point(225, 267);
            this.Tennis_choes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Tennis_choes.Name = "Tennis_choes";
            this.Tennis_choes.Size = new System.Drawing.Size(78, 22);
            this.Tennis_choes.TabIndex = 9;
            this.Tennis_choes.Text = "Tennis";
            this.Tennis_choes.UseVisualStyleBackColor = true;
            // 
            // Swimming_choes
            // 
            this.Swimming_choes.AutoSize = true;
            this.Swimming_choes.Location = new System.Drawing.Point(313, 267);
            this.Swimming_choes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Swimming_choes.Name = "Swimming_choes";
            this.Swimming_choes.Size = new System.Drawing.Size(103, 22);
            this.Swimming_choes.TabIndex = 10;
            this.Swimming_choes.Text = "Swimming";
            this.Swimming_choes.UseVisualStyleBackColor = true;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(232, 346);
            this.btn_reg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(125, 32);
            this.btn_reg.TabIndex = 11;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // Valid_Log
            // 
            this.Valid_Log.AutoSize = true;
            this.Valid_Log.ForeColor = System.Drawing.Color.Green;
            this.Valid_Log.Location = new System.Drawing.Point(148, 382);
            this.Valid_Log.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Valid_Log.Name = "Valid_Log";
            this.Valid_Log.Size = new System.Drawing.Size(307, 18);
            this.Valid_Log.TabIndex = 12;
            this.Valid_Log.Text = "Than Yoy , Your registeration is Valid ";
            // 
            // Characters_Least
            // 
            this.Characters_Least.AutoSize = true;
            this.Characters_Least.ForeColor = System.Drawing.Color.Red;
            this.Characters_Least.Location = new System.Drawing.Point(307, 19);
            this.Characters_Least.Name = "Characters_Least";
            this.Characters_Least.Size = new System.Drawing.Size(318, 18);
            this.Characters_Least.TabIndex = 13;
            this.Characters_Least.Text = "Name Must Contain at Least 5 Characters";
            // 
            // Email_Least
            // 
            this.Email_Least.AutoSize = true;
            this.Email_Least.ForeColor = System.Drawing.Color.Red;
            this.Email_Least.Location = new System.Drawing.Point(320, 81);
            this.Email_Least.Name = "Email_Least";
            this.Email_Least.Size = new System.Drawing.Size(181, 18);
            this.Email_Least.TabIndex = 14;
            this.Email_Least.Text = "Email Must Contain @";
            // 
            // Hoppy_Least
            // 
            this.Hoppy_Least.AutoSize = true;
            this.Hoppy_Least.ForeColor = System.Drawing.Color.Red;
            this.Hoppy_Least.Location = new System.Drawing.Point(434, 268);
            this.Hoppy_Least.Name = "Hoppy_Least";
            this.Hoppy_Least.Size = new System.Drawing.Size(201, 18);
            this.Hoppy_Least.TabIndex = 15;
            this.Hoppy_Least.Text = "Choes at Least one Hoppy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 412);
            this.Controls.Add(this.Hoppy_Least);
            this.Controls.Add(this.Email_Least);
            this.Controls.Add(this.Characters_Least);
            this.Controls.Add(this.Valid_Log);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.Swimming_choes);
            this.Controls.Add(this.Tennis_choes);
            this.Controls.Add(this.Football_choes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Female_Log);
            this.Controls.Add(this.Male_Log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username_Log);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Male_Log;
        private System.Windows.Forms.RadioButton Female_Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Football_choes;
        private System.Windows.Forms.CheckBox Tennis_choes;
        private System.Windows.Forms.CheckBox Swimming_choes;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label Valid_Log;
        private System.Windows.Forms.Label Characters_Least;
        private System.Windows.Forms.Label Email_Least;
        private System.Windows.Forms.Label Hoppy_Least;
    }
}

