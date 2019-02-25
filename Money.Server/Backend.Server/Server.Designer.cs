namespace Backend.Server
{
    partial class Server
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
            this.MonitorTabControl = new System.Windows.Forms.TabControl();
            this.InTabPage = new System.Windows.Forms.TabPage();
            this.XmlLabel = new System.Windows.Forms.Label();
            this.DesLabel = new System.Windows.Forms.Label();
            this.ConsoleXml = new System.Windows.Forms.TextBox();
            this.Console3Des = new System.Windows.Forms.TextBox();
            this.OutTabPage = new System.Windows.Forms.TabPage();
            this.OnOffButton = new System.Windows.Forms.Button();
            this.MonitorTabControl.SuspendLayout();
            this.InTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonitorTabControl
            // 
            this.MonitorTabControl.Controls.Add(this.InTabPage);
            this.MonitorTabControl.Controls.Add(this.OutTabPage);
            this.MonitorTabControl.Location = new System.Drawing.Point(160, 15);
            this.MonitorTabControl.Name = "MonitorTabControl";
            this.MonitorTabControl.SelectedIndex = 0;
            this.MonitorTabControl.Size = new System.Drawing.Size(410, 380);
            this.MonitorTabControl.TabIndex = 10;
            // 
            // InTabPage
            // 
            this.InTabPage.Controls.Add(this.XmlLabel);
            this.InTabPage.Controls.Add(this.DesLabel);
            this.InTabPage.Controls.Add(this.ConsoleXml);
            this.InTabPage.Controls.Add(this.Console3Des);
            this.InTabPage.Location = new System.Drawing.Point(4, 22);
            this.InTabPage.Name = "InTabPage";
            this.InTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InTabPage.Size = new System.Drawing.Size(402, 354);
            this.InTabPage.TabIndex = 0;
            this.InTabPage.Text = "IN";
            this.InTabPage.UseVisualStyleBackColor = true;
            // 
            // XmlLabel
            // 
            this.XmlLabel.AutoSize = true;
            this.XmlLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlLabel.Location = new System.Drawing.Point(202, 3);
            this.XmlLabel.Name = "XmlLabel";
            this.XmlLabel.Size = new System.Drawing.Size(49, 26);
            this.XmlLabel.TabIndex = 1;
            this.XmlLabel.Text = "XML";
            // 
            // DesLabel
            // 
            this.DesLabel.AutoSize = true;
            this.DesLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLabel.Location = new System.Drawing.Point(6, 3);
            this.DesLabel.Name = "DesLabel";
            this.DesLabel.Size = new System.Drawing.Size(55, 26);
            this.DesLabel.TabIndex = 1;
            this.DesLabel.Text = "3DES";
            // 
            // ConsoleXml
            // 
            this.ConsoleXml.Enabled = false;
            this.ConsoleXml.Location = new System.Drawing.Point(204, 22);
            this.ConsoleXml.Multiline = true;
            this.ConsoleXml.Name = "ConsoleXml";
            this.ConsoleXml.Size = new System.Drawing.Size(190, 255);
            this.ConsoleXml.TabIndex = 0;
            // 
            // Console3Des
            // 
            this.Console3Des.Enabled = false;
            this.Console3Des.Location = new System.Drawing.Point(6, 22);
            this.Console3Des.Multiline = true;
            this.Console3Des.Name = "Console3Des";
            this.Console3Des.Size = new System.Drawing.Size(190, 254);
            this.Console3Des.TabIndex = 0;
            // 
            // OutTabPage
            // 
            this.OutTabPage.Location = new System.Drawing.Point(4, 22);
            this.OutTabPage.Name = "OutTabPage";
            this.OutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OutTabPage.Size = new System.Drawing.Size(402, 354);
            this.OutTabPage.TabIndex = 1;
            this.OutTabPage.Text = "OUT";
            this.OutTabPage.UseVisualStyleBackColor = true;
            // 
            // OnOffButton
            // 
            this.OnOffButton.BackColor = System.Drawing.Color.Gray;
            this.OnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnOffButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffButton.Location = new System.Drawing.Point(506, 397);
            this.OnOffButton.Name = "OnOffButton";
            this.OnOffButton.Size = new System.Drawing.Size(60, 60);
            this.OnOffButton.TabIndex = 11;
            this.OnOffButton.UseVisualStyleBackColor = false;
            this.OnOffButton.Click += new System.EventHandler(this.OnOffButton_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.OnOffButton);
            this.Controls.Add(this.MonitorTabControl);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.MonitorTabControl.ResumeLayout(false);
            this.InTabPage.ResumeLayout(false);
            this.InTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MonitorTabControl;
        private System.Windows.Forms.TabPage InTabPage;
        private System.Windows.Forms.Label XmlLabel;
        private System.Windows.Forms.Label DesLabel;
        private System.Windows.Forms.TextBox ConsoleXml;
        private System.Windows.Forms.TextBox Console3Des;
        private System.Windows.Forms.TabPage OutTabPage;
        private System.Windows.Forms.Button OnOffButton;
    }
}