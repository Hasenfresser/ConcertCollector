namespace ConcertCollector.Layouts
{
    partial class AddBand
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
            this.label_AddBand_Name = new System.Windows.Forms.Label();
            this.label_AddBand_Info = new System.Windows.Forms.Label();
            this.label_AddBand_NameExtra = new System.Windows.Forms.Label();
            this.textBox_AddBand_Name = new System.Windows.Forms.TextBox();
            this.textBox_AddBand_NameExtra = new System.Windows.Forms.TextBox();
            this.textBox_AddBand_Info = new System.Windows.Forms.TextBox();
            this.button_AddBand_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AddBand_Name
            // 
            this.label_AddBand_Name.AutoSize = true;
            this.label_AddBand_Name.Location = new System.Drawing.Point(12, 16);
            this.label_AddBand_Name.Name = "label_AddBand_Name";
            this.label_AddBand_Name.Size = new System.Drawing.Size(38, 13);
            this.label_AddBand_Name.TabIndex = 0;
            this.label_AddBand_Name.Text = "Name:";
            this.label_AddBand_Name.Click += new System.EventHandler(this.label_AddBand_Name_Click);
            // 
            // label_AddBand_Info
            // 
            this.label_AddBand_Info.AutoSize = true;
            this.label_AddBand_Info.Location = new System.Drawing.Point(12, 70);
            this.label_AddBand_Info.Name = "label_AddBand_Info";
            this.label_AddBand_Info.Size = new System.Drawing.Size(74, 13);
            this.label_AddBand_Info.TabIndex = 1;
            this.label_AddBand_Info.Text = "Informationen:";
            this.label_AddBand_Info.Click += new System.EventHandler(this.label_AddBand_Info_Click);
            // 
            // label_AddBand_NameExtra
            // 
            this.label_AddBand_NameExtra.AutoSize = true;
            this.label_AddBand_NameExtra.Location = new System.Drawing.Point(12, 43);
            this.label_AddBand_NameExtra.Name = "label_AddBand_NameExtra";
            this.label_AddBand_NameExtra.Size = new System.Drawing.Size(79, 13);
            this.label_AddBand_NameExtra.TabIndex = 2;
            this.label_AddBand_NameExtra.Text = "Name (Zusatz):";
            this.label_AddBand_NameExtra.Click += new System.EventHandler(this.label_AddBand_NameExtra_Click);
            // 
            // textBox_AddBand_Name
            // 
            this.textBox_AddBand_Name.Location = new System.Drawing.Point(89, 13);
            this.textBox_AddBand_Name.Name = "textBox_AddBand_Name";
            this.textBox_AddBand_Name.Size = new System.Drawing.Size(184, 20);
            this.textBox_AddBand_Name.TabIndex = 3;
            this.textBox_AddBand_Name.TextChanged += new System.EventHandler(this.textBox_AddBand_Name_TextChanged);
            // 
            // textBox_AddBand_NameExtra
            // 
            this.textBox_AddBand_NameExtra.Location = new System.Drawing.Point(89, 40);
            this.textBox_AddBand_NameExtra.Name = "textBox_AddBand_NameExtra";
            this.textBox_AddBand_NameExtra.Size = new System.Drawing.Size(184, 20);
            this.textBox_AddBand_NameExtra.TabIndex = 4;
            this.textBox_AddBand_NameExtra.TextChanged += new System.EventHandler(this.textBox_AddBand_NameExtra_TextChanged);
            // 
            // textBox_AddBand_Info
            // 
            this.textBox_AddBand_Info.Location = new System.Drawing.Point(89, 67);
            this.textBox_AddBand_Info.Multiline = true;
            this.textBox_AddBand_Info.Name = "textBox_AddBand_Info";
            this.textBox_AddBand_Info.Size = new System.Drawing.Size(184, 61);
            this.textBox_AddBand_Info.TabIndex = 5;
            this.textBox_AddBand_Info.TextChanged += new System.EventHandler(this.textBox_AddBand_Info_TextChanged);
            // 
            // button_AddBand_Add
            // 
            this.button_AddBand_Add.Location = new System.Drawing.Point(13, 105);
            this.button_AddBand_Add.Name = "button_AddBand_Add";
            this.button_AddBand_Add.Size = new System.Drawing.Size(70, 23);
            this.button_AddBand_Add.TabIndex = 6;
            this.button_AddBand_Add.Text = "Hinzufügen";
            this.button_AddBand_Add.UseVisualStyleBackColor = true;
            this.button_AddBand_Add.Click += new System.EventHandler(this.button_AddBand_Add_Click);
            // 
            // AddBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 140);
            this.Controls.Add(this.button_AddBand_Add);
            this.Controls.Add(this.textBox_AddBand_Info);
            this.Controls.Add(this.textBox_AddBand_NameExtra);
            this.Controls.Add(this.textBox_AddBand_Name);
            this.Controls.Add(this.label_AddBand_NameExtra);
            this.Controls.Add(this.label_AddBand_Info);
            this.Controls.Add(this.label_AddBand_Name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBand";
            this.Text = "Band hinzufügen";
            this.Load += new System.EventHandler(this.AddBand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddBand_Name;
        private System.Windows.Forms.Label label_AddBand_Info;
        private System.Windows.Forms.Label label_AddBand_NameExtra;
        private System.Windows.Forms.TextBox textBox_AddBand_Name;
        private System.Windows.Forms.TextBox textBox_AddBand_NameExtra;
        private System.Windows.Forms.TextBox textBox_AddBand_Info;
        private System.Windows.Forms.Button button_AddBand_Add;
    }
}