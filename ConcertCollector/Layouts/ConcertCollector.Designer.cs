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
            this.label_EventManagement_AllEvents = new System.Windows.Forms.Label();
            this.listView_EventManagement_AllEvents = new System.Windows.Forms.ListView();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.tabPage_Statistics = new System.Windows.Forms.TabPage();
            this.label_EventManagement = new System.Windows.Forms.Label();
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
            this.tabPage_EventManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement);
            this.tabPage_EventManagement.Controls.Add(this.label_EventManagement_AllEvents);
            this.tabPage_EventManagement.Controls.Add(this.listView_EventManagement_AllEvents);
            resources.ApplyResources(this.tabPage_EventManagement, "tabPage_EventManagement");
            this.tabPage_EventManagement.Name = "tabPage_EventManagement";
            this.tabPage_EventManagement.Click += new System.EventHandler(this.tabPage_EventManagement_Click);
            // 
            // label_EventManagement_AllEvents
            // 
            resources.ApplyResources(this.label_EventManagement_AllEvents, "label_EventManagement_AllEvents");
            this.label_EventManagement_AllEvents.Name = "label_EventManagement_AllEvents";
            // 
            // listView_EventManagement_AllEvents
            // 
            resources.ApplyResources(this.listView_EventManagement_AllEvents, "listView_EventManagement_AllEvents");
            this.listView_EventManagement_AllEvents.Name = "listView_EventManagement_AllEvents";
            this.listView_EventManagement_AllEvents.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_Search
            // 
            this.tabPage_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.tabPage_Search, "tabPage_Search");
            this.tabPage_Search.Name = "tabPage_Search";
            // 
            // tabPage_Statistics
            // 
            this.tabPage_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.tabPage_Statistics, "tabPage_Statistics");
            this.tabPage_Statistics.Name = "tabPage_Statistics";
            // 
            // label_EventManagement
            // 
            resources.ApplyResources(this.label_EventManagement, "label_EventManagement");
            this.label_EventManagement.Name = "label_EventManagement";
            // 
            // ConcertCollector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
        private System.Windows.Forms.Label label_EventManagement_AllEvents;
        private System.Windows.Forms.ListView listView_EventManagement_AllEvents;
        private System.Windows.Forms.Label label_EventManagement;
    }
}

