namespace ConcertCollector
{
    partial class ConcertCollector
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertCollector));
            this.tabControl_MainWindow = new System.Windows.Forms.TabControl();
            this.tabPage_EventManagement = new System.Windows.Forms.TabPage();
            this.button_EventManagement_DeleteBand = new System.Windows.Forms.Button();
            this.button_EventManagement_AddBand = new System.Windows.Forms.Button();
            this.label_EventManagement_Bands = new System.Windows.Forms.Label();
            this.listBox_EventManagement_Bands = new System.Windows.Forms.ListBox();
            this.textBox_EventManagement_Cost = new System.Windows.Forms.TextBox();
            this.label_EventManagement_Cost = new System.Windows.Forms.Label();
            this.label_EventManagement_Location = new System.Windows.Forms.Label();
            this.textBox_EventManagement_Location = new System.Windows.Forms.TextBox();
            this.label_EventManagement_DateTo = new System.Windows.Forms.Label();
            this.label_EventManagement_DateFrom = new System.Windows.Forms.Label();
            this.label_EventManagement_NameExtra = new System.Windows.Forms.Label();
            this.label_EventManagement_Name = new System.Windows.Forms.Label();
            this.dateTimePicker_EventManagement_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EventManagement_From = new System.Windows.Forms.DateTimePicker();
            this.textBox_EventManagement_NameExtra = new System.Windows.Forms.TextBox();
            this.textBox_EventManagement_Name = new System.Windows.Forms.TextBox();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.tabPage_Statistics = new System.Windows.Forms.TabPage();
            this.tabControl_MainWindow.SuspendLayout();
            this.tabPage_EventManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_MainWindow
            // 
            this.tabControl_MainWindow.Controls.Add(this.tabPage_EventManagement);
            this.tabControl_MainWindow.Controls.Add(this.tabPage_Search);
            this.tabControl_MainWindow.Controls.Add(this.tabPage_Statistics);
            resources.ApplyResources(this.tabControl_MainWindow, "tabControl_MainWindow");
            this.tabControl_MainWindow.Name = "tabControl_MainWindow";
            this.tabControl_MainWindow.SelectedIndex = 0;
            // 
            // tabPage_EventManagement
            // 
            this.tabPage_EventManagement.Controls.Add(this.button_EventManagement_DeleteBand);
            this.tabPage_EventManagement.Controls.Add(this.button_EventManagement_AddBand);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_Bands);
            this.tabPage_EventManagement.Controls.Add(this.listBox_EventManagement_Bands);
            this.tabPage_EventManagement.Controls.Add(this.textBox_EventManagement_Cost);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_Cost);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_Location);
            this.tabPage_EventManagement.Controls.Add(this.textBox_EventManagement_Location);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_DateTo);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_DateFrom);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_NameExtra);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_Name);
            this.tabPage_EventManagement.Controls.Add(this.dateTimePicker_EventManagement_To);
            this.tabPage_EventManagement.Controls.Add(this.dateTimePicker_EventManagement_From);
            this.tabPage_EventManagement.Controls.Add(this.textBox_EventManagement_NameExtra);
            this.tabPage_EventManagement.Controls.Add(this.textBox_EventManagement_Name);
            resources.ApplyResources(this.tabPage_EventManagement, "tabPage_EventManagement");
            this.tabPage_EventManagement.Name = "tabPage_EventManagement";
            this.tabPage_EventManagement.UseVisualStyleBackColor = true;
            this.tabPage_EventManagement.Click += new System.EventHandler(this.tabPage_EventManagement_Click);
            // 
            // button_EventManagement_DeleteBand
            // 
            resources.ApplyResources(this.button_EventManagement_DeleteBand, "button_EventManagement_DeleteBand");
            this.button_EventManagement_DeleteBand.Name = "button_EventManagement_DeleteBand";
            this.button_EventManagement_DeleteBand.UseVisualStyleBackColor = true;
            // 
            // button_EventManagement_AddBand
            // 
            resources.ApplyResources(this.button_EventManagement_AddBand, "button_EventManagement_AddBand");
            this.button_EventManagement_AddBand.Name = "button_EventManagement_AddBand";
            this.button_EventManagement_AddBand.UseVisualStyleBackColor = true;
            this.button_EventManagement_AddBand.Click += new System.EventHandler(this.button_EventManagement_AddBand_Click);
            // 
            // label_EventManagement_Bands
            // 
            resources.ApplyResources(this.label_EventManagement_Bands, "label_EventManagement_Bands");
            this.label_EventManagement_Bands.Name = "label_EventManagement_Bands";
            this.label_EventManagement_Bands.Click += new System.EventHandler(this.label_EventManagement_Bands_Click);
            // 
            // listBox_EventManagement_Bands
            // 
            this.listBox_EventManagement_Bands.FormattingEnabled = true;
            resources.ApplyResources(this.listBox_EventManagement_Bands, "listBox_EventManagement_Bands");
            this.listBox_EventManagement_Bands.Name = "listBox_EventManagement_Bands";
            this.listBox_EventManagement_Bands.SelectedIndexChanged += new System.EventHandler(this.listBox_EventManagement_Bands_SelectedIndexChanged);
            // 
            // textBox_EventManagement_Cost
            // 
            resources.ApplyResources(this.textBox_EventManagement_Cost, "textBox_EventManagement_Cost");
            this.textBox_EventManagement_Cost.Name = "textBox_EventManagement_Cost";
            this.textBox_EventManagement_Cost.TextChanged += new System.EventHandler(this.textBox_EventManagement_Cost_TextChanged);
            // 
            // label_EventManagement_Cost
            // 
            resources.ApplyResources(this.label_EventManagement_Cost, "label_EventManagement_Cost");
            this.label_EventManagement_Cost.Name = "label_EventManagement_Cost";
            this.label_EventManagement_Cost.Click += new System.EventHandler(this.label_EventManagement_Cost_Click);
            // 
            // label_EventManagement_Location
            // 
            resources.ApplyResources(this.label_EventManagement_Location, "label_EventManagement_Location");
            this.label_EventManagement_Location.Name = "label_EventManagement_Location";
            this.label_EventManagement_Location.Click += new System.EventHandler(this.label_EventManagement_Location_Click);
            // 
            // textBox_EventManagement_Location
            // 
            resources.ApplyResources(this.textBox_EventManagement_Location, "textBox_EventManagement_Location");
            this.textBox_EventManagement_Location.Name = "textBox_EventManagement_Location";
            this.textBox_EventManagement_Location.TextChanged += new System.EventHandler(this.textBox_EventManagement_Location_TextChanged);
            // 
            // label_EventManagement_DateTo
            // 
            resources.ApplyResources(this.label_EventManagement_DateTo, "label_EventManagement_DateTo");
            this.label_EventManagement_DateTo.Name = "label_EventManagement_DateTo";
            // 
            // label_EventManagement_DateFrom
            // 
            resources.ApplyResources(this.label_EventManagement_DateFrom, "label_EventManagement_DateFrom");
            this.label_EventManagement_DateFrom.Name = "label_EventManagement_DateFrom";
            this.label_EventManagement_DateFrom.Click += new System.EventHandler(this.label_EventManagement_DateFrom_Click);
            // 
            // label_EventManagement_NameExtra
            // 
            resources.ApplyResources(this.label_EventManagement_NameExtra, "label_EventManagement_NameExtra");
            this.label_EventManagement_NameExtra.Name = "label_EventManagement_NameExtra";
            this.label_EventManagement_NameExtra.Click += new System.EventHandler(this.label_Event_NameExtra_Click);
            // 
            // label_EventManagement_Name
            // 
            resources.ApplyResources(this.label_EventManagement_Name, "label_EventManagement_Name");
            this.label_EventManagement_Name.Name = "label_EventManagement_Name";
            this.label_EventManagement_Name.Click += new System.EventHandler(this.label_EventManagement_Name_Click);
            // 
            // dateTimePicker_EventManagement_To
            // 
            resources.ApplyResources(this.dateTimePicker_EventManagement_To, "dateTimePicker_EventManagement_To");
            this.dateTimePicker_EventManagement_To.Name = "dateTimePicker_EventManagement_To";
            this.dateTimePicker_EventManagement_To.ValueChanged += new System.EventHandler(this.dateTimePicker_EventManagement_To_ValueChanged);
            // 
            // dateTimePicker_EventManagement_From
            // 
            resources.ApplyResources(this.dateTimePicker_EventManagement_From, "dateTimePicker_EventManagement_From");
            this.dateTimePicker_EventManagement_From.Name = "dateTimePicker_EventManagement_From";
            this.dateTimePicker_EventManagement_From.ValueChanged += new System.EventHandler(this.dateTimePicker_EventManagement_From_ValueChanged);
            // 
            // textBox_EventManagement_NameExtra
            // 
            resources.ApplyResources(this.textBox_EventManagement_NameExtra, "textBox_EventManagement_NameExtra");
            this.textBox_EventManagement_NameExtra.Name = "textBox_EventManagement_NameExtra";
            this.textBox_EventManagement_NameExtra.TextChanged += new System.EventHandler(this.textBox_EventManagement_NameExtra_TextChanged);
            // 
            // textBox_EventManagement_Name
            // 
            resources.ApplyResources(this.textBox_EventManagement_Name, "textBox_EventManagement_Name");
            this.textBox_EventManagement_Name.Name = "textBox_EventManagement_Name";
            this.textBox_EventManagement_Name.TextChanged += new System.EventHandler(this.textBox_EventManagement_Name_TextChanged);
            // 
            // tabPage_Search
            // 
            resources.ApplyResources(this.tabPage_Search, "tabPage_Search");
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.UseVisualStyleBackColor = true;
            this.tabPage_Search.Click += new System.EventHandler(this.tabPage_Search_Click);
            // 
            // tabPage_Statistics
            // 
            resources.ApplyResources(this.tabPage_Statistics, "tabPage_Statistics");
            this.tabPage_Statistics.Name = "tabPage_Statistics";
            this.tabPage_Statistics.UseVisualStyleBackColor = true;
            this.tabPage_Statistics.Click += new System.EventHandler(this.tabPage_Statistics_Click);
            // 
            // ConcertCollector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_MainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConcertCollector";
            this.Load += new System.EventHandler(this.ConcertCollector_Load);
            this.tabControl_MainWindow.ResumeLayout(false);
            this.tabPage_EventManagement.ResumeLayout(false);
            this.tabPage_EventManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_MainWindow;
        private System.Windows.Forms.TabPage tabPage_EventManagement;
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_Statistics;
        private System.Windows.Forms.Label label_EventManagement_NameExtra;
        private System.Windows.Forms.Label label_EventManagement_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EventManagement_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EventManagement_From;
        private System.Windows.Forms.TextBox textBox_EventManagement_NameExtra;
        private System.Windows.Forms.TextBox textBox_EventManagement_Name;
        private System.Windows.Forms.Label label_EventManagement_DateTo;
        private System.Windows.Forms.Label label_EventManagement_DateFrom;
        private System.Windows.Forms.TextBox textBox_EventManagement_Location;
        private System.Windows.Forms.Label label_EventManagement_Location;
        private System.Windows.Forms.TextBox textBox_EventManagement_Cost;
        private System.Windows.Forms.Label label_EventManagement_Cost;
        private System.Windows.Forms.ListBox listBox_EventManagement_Bands;
        private System.Windows.Forms.Label label_EventManagement_Bands;
        private System.Windows.Forms.Button button_EventManagement_AddBand;
        private System.Windows.Forms.Button button_EventManagement_DeleteBand;
    }
}

