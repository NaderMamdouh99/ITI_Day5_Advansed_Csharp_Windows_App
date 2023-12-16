namespace WindowsFormsApp1
{
    partial class Convert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert));
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.Value_Cot = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.Result_Cot = new System.Windows.Forms.Label();
            this.Chooes_Unit = new System.Windows.Forms.Label();
            this.Convert_to = new System.Windows.Forms.Button();
            this.Kilo_Convert = new System.Windows.Forms.RadioButton();
            this.Mile_Convert = new System.Windows.Forms.RadioButton();
            this.Meter_Convert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(116, 93);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(164, 25);
            this.txt_Value.TabIndex = 0;
            // 
            // Value_Cot
            // 
            this.Value_Cot.AutoSize = true;
            this.Value_Cot.Location = new System.Drawing.Point(32, 96);
            this.Value_Cot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Value_Cot.Name = "Value_Cot";
            this.Value_Cot.Size = new System.Drawing.Size(50, 18);
            this.Value_Cot.TabIndex = 1;
            this.Value_Cot.Text = "Value";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(116, 169);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(164, 25);
            this.txt_Result.TabIndex = 2;
            // 
            // Result_Cot
            // 
            this.Result_Cot.AutoSize = true;
            this.Result_Cot.Location = new System.Drawing.Point(32, 172);
            this.Result_Cot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Result_Cot.Name = "Result_Cot";
            this.Result_Cot.Size = new System.Drawing.Size(55, 18);
            this.Result_Cot.TabIndex = 3;
            this.Result_Cot.Text = "Result";
            // 
            // Chooes_Unit
            // 
            this.Chooes_Unit.AutoSize = true;
            this.Chooes_Unit.Image = ((System.Drawing.Image)(resources.GetObject("Chooes_Unit.Image")));
            this.Chooes_Unit.Location = new System.Drawing.Point(421, 52);
            this.Chooes_Unit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Chooes_Unit.Name = "Chooes_Unit";
            this.Chooes_Unit.Size = new System.Drawing.Size(98, 18);
            this.Chooes_Unit.TabIndex = 4;
            this.Chooes_Unit.Text = "Choose Unit";
            // 
            // Convert_to
            // 
            this.Convert_to.Location = new System.Drawing.Point(252, 223);
            this.Convert_to.Name = "Convert_to";
            this.Convert_to.Size = new System.Drawing.Size(75, 32);
            this.Convert_to.TabIndex = 8;
            this.Convert_to.Text = "Convert";
            this.Convert_to.UseVisualStyleBackColor = true;
            this.Convert_to.Click += new System.EventHandler(this.Convert_to_Click);
            // 
            // Kilo_Convert
            // 
            this.Kilo_Convert.AutoSize = true;
            this.Kilo_Convert.Location = new System.Drawing.Point(402, 96);
            this.Kilo_Convert.Name = "Kilo_Convert";
            this.Kilo_Convert.Size = new System.Drawing.Size(167, 22);
            this.Kilo_Convert.TabIndex = 9;
            this.Kilo_Convert.TabStop = true;
            this.Kilo_Convert.Text = "Meter to Kilometer";
            this.Kilo_Convert.UseVisualStyleBackColor = true;
            // 
            // Mile_Convert
            // 
            this.Mile_Convert.AutoSize = true;
            this.Mile_Convert.Location = new System.Drawing.Point(403, 124);
            this.Mile_Convert.Name = "Mile_Convert";
            this.Mile_Convert.Size = new System.Drawing.Size(128, 22);
            this.Mile_Convert.TabIndex = 10;
            this.Mile_Convert.TabStop = true;
            this.Mile_Convert.Text = "Meter to Mile";
            this.Mile_Convert.UseVisualStyleBackColor = true;
            // 
            // Meter_Convert
            // 
            this.Meter_Convert.AutoSize = true;
            this.Meter_Convert.Location = new System.Drawing.Point(403, 152);
            this.Meter_Convert.Name = "Meter_Convert";
            this.Meter_Convert.Size = new System.Drawing.Size(128, 22);
            this.Meter_Convert.TabIndex = 11;
            this.Meter_Convert.TabStop = true;
            this.Meter_Convert.Text = "Mile to Meter";
            this.Meter_Convert.UseVisualStyleBackColor = true;
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(575, 375);
            this.Controls.Add(this.Meter_Convert);
            this.Controls.Add(this.Mile_Convert);
            this.Controls.Add(this.Kilo_Convert);
            this.Controls.Add(this.Convert_to);
            this.Controls.Add(this.Chooes_Unit);
            this.Controls.Add(this.Result_Cot);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.Value_Cot);
            this.Controls.Add(this.txt_Value);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Convert";
            this.Text = "Convert";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label Value_Cot;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label Result_Cot;
        private System.Windows.Forms.Label Chooes_Unit;
        private System.Windows.Forms.Button Convert_to;
        private System.Windows.Forms.RadioButton Kilo_Convert;
        private System.Windows.Forms.RadioButton Mile_Convert;
        private System.Windows.Forms.RadioButton Meter_Convert;
    }
}