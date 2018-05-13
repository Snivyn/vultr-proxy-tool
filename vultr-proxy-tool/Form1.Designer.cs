namespace vultr_proxy_tool
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
            this.lblVultrAPIKey = new System.Windows.Forms.Label();
            this.rdbMiami = new System.Windows.Forms.RadioButton();
            this.rdbDallas = new System.Windows.Forms.RadioButton();
            this.rdbSeattle = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.rdbSingapore = new System.Windows.Forms.RadioButton();
            this.rdbTokyo = new System.Windows.Forms.RadioButton();
            this.rdbSydney = new System.Windows.Forms.RadioButton();
            this.rdbFrance = new System.Windows.Forms.RadioButton();
            this.rdbUK = new System.Windows.Forms.RadioButton();
            this.rdbAmsterdam = new System.Windows.Forms.RadioButton();
            this.rdbNY = new System.Windows.Forms.RadioButton();
            this.rdbSiliconValley = new System.Windows.Forms.RadioButton();
            this.rdbGermany = new System.Windows.Forms.RadioButton();
            this.rdbAtlanta = new System.Windows.Forms.RadioButton();
            this.rdbChicago = new System.Windows.Forms.RadioButton();
            this.rdbLA = new System.Windows.Forms.RadioButton();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateProxies = new System.Windows.Forms.Button();
            this.btnLoadProxies = new System.Windows.Forms.Button();
            this.lnkDocs = new System.Windows.Forms.LinkLabel();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVultrAPIKey
            // 
            this.lblVultrAPIKey.AutoSize = true;
            this.lblVultrAPIKey.Location = new System.Drawing.Point(12, 71);
            this.lblVultrAPIKey.Name = "lblVultrAPIKey";
            this.lblVultrAPIKey.Size = new System.Drawing.Size(69, 13);
            this.lblVultrAPIKey.TabIndex = 1;
            this.lblVultrAPIKey.Text = "Vultr API Key";
            // 
            // rdbMiami
            // 
            this.rdbMiami.AutoSize = true;
            this.rdbMiami.Location = new System.Drawing.Point(23, 30);
            this.rdbMiami.Name = "rdbMiami";
            this.rdbMiami.Size = new System.Drawing.Size(52, 17);
            this.rdbMiami.TabIndex = 3;
            this.rdbMiami.TabStop = true;
            this.rdbMiami.Tag = "39";
            this.rdbMiami.Text = "Miami";
            this.rdbMiami.UseVisualStyleBackColor = true;
            // 
            // rdbDallas
            // 
            this.rdbDallas.AutoSize = true;
            this.rdbDallas.Location = new System.Drawing.Point(23, 53);
            this.rdbDallas.Name = "rdbDallas";
            this.rdbDallas.Size = new System.Drawing.Size(54, 17);
            this.rdbDallas.TabIndex = 4;
            this.rdbDallas.TabStop = true;
            this.rdbDallas.Tag = "3";
            this.rdbDallas.Text = "Dallas";
            this.rdbDallas.UseVisualStyleBackColor = true;
            // 
            // rdbSeattle
            // 
            this.rdbSeattle.AutoSize = true;
            this.rdbSeattle.Location = new System.Drawing.Point(23, 76);
            this.rdbSeattle.Name = "rdbSeattle";
            this.rdbSeattle.Size = new System.Drawing.Size(58, 17);
            this.rdbSeattle.TabIndex = 5;
            this.rdbSeattle.TabStop = true;
            this.rdbSeattle.Tag = "4";
            this.rdbSeattle.Text = "Seattle";
            this.rdbSeattle.UseVisualStyleBackColor = true;
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.rdbSingapore);
            this.grpLocation.Controls.Add(this.rdbTokyo);
            this.grpLocation.Controls.Add(this.rdbSydney);
            this.grpLocation.Controls.Add(this.rdbFrance);
            this.grpLocation.Controls.Add(this.rdbUK);
            this.grpLocation.Controls.Add(this.rdbAmsterdam);
            this.grpLocation.Controls.Add(this.rdbNY);
            this.grpLocation.Controls.Add(this.rdbSiliconValley);
            this.grpLocation.Controls.Add(this.rdbGermany);
            this.grpLocation.Controls.Add(this.rdbAtlanta);
            this.grpLocation.Controls.Add(this.rdbChicago);
            this.grpLocation.Controls.Add(this.rdbLA);
            this.grpLocation.Controls.Add(this.rdbMiami);
            this.grpLocation.Controls.Add(this.rdbDallas);
            this.grpLocation.Controls.Add(this.rdbSeattle);
            this.grpLocation.Location = new System.Drawing.Point(12, 100);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(590, 114);
            this.grpLocation.TabIndex = 8;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // rdbSingapore
            // 
            this.rdbSingapore.AutoSize = true;
            this.rdbSingapore.Location = new System.Drawing.Point(474, 30);
            this.rdbSingapore.Name = "rdbSingapore";
            this.rdbSingapore.Size = new System.Drawing.Size(73, 17);
            this.rdbSingapore.TabIndex = 15;
            this.rdbSingapore.TabStop = true;
            this.rdbSingapore.Tag = "40";
            this.rdbSingapore.Text = "Signapore";
            this.rdbSingapore.UseVisualStyleBackColor = true;
            // 
            // rdbTokyo
            // 
            this.rdbTokyo.AutoSize = true;
            this.rdbTokyo.Location = new System.Drawing.Point(474, 53);
            this.rdbTokyo.Name = "rdbTokyo";
            this.rdbTokyo.Size = new System.Drawing.Size(55, 17);
            this.rdbTokyo.TabIndex = 16;
            this.rdbTokyo.TabStop = true;
            this.rdbTokyo.Tag = "25";
            this.rdbTokyo.Text = "Tokyo";
            this.rdbTokyo.UseVisualStyleBackColor = true;
            // 
            // rdbSydney
            // 
            this.rdbSydney.AutoSize = true;
            this.rdbSydney.Location = new System.Drawing.Point(474, 76);
            this.rdbSydney.Name = "rdbSydney";
            this.rdbSydney.Size = new System.Drawing.Size(60, 17);
            this.rdbSydney.TabIndex = 17;
            this.rdbSydney.TabStop = true;
            this.rdbSydney.Tag = "19";
            this.rdbSydney.Text = "Sydney";
            this.rdbSydney.UseVisualStyleBackColor = true;
            // 
            // rdbFrance
            // 
            this.rdbFrance.AutoSize = true;
            this.rdbFrance.Location = new System.Drawing.Point(359, 30);
            this.rdbFrance.Name = "rdbFrance";
            this.rdbFrance.Size = new System.Drawing.Size(58, 17);
            this.rdbFrance.TabIndex = 12;
            this.rdbFrance.TabStop = true;
            this.rdbFrance.Tag = "24";
            this.rdbFrance.Text = "France";
            this.rdbFrance.UseVisualStyleBackColor = true;
            // 
            // rdbUK
            // 
            this.rdbUK.AutoSize = true;
            this.rdbUK.Location = new System.Drawing.Point(359, 53);
            this.rdbUK.Name = "rdbUK";
            this.rdbUK.Size = new System.Drawing.Size(100, 17);
            this.rdbUK.TabIndex = 13;
            this.rdbUK.TabStop = true;
            this.rdbUK.Tag = "8";
            this.rdbUK.Text = "United Kingdom";
            this.rdbUK.UseVisualStyleBackColor = true;
            // 
            // rdbAmsterdam
            // 
            this.rdbAmsterdam.AutoSize = true;
            this.rdbAmsterdam.Location = new System.Drawing.Point(359, 76);
            this.rdbAmsterdam.Name = "rdbAmsterdam";
            this.rdbAmsterdam.Size = new System.Drawing.Size(77, 17);
            this.rdbAmsterdam.TabIndex = 14;
            this.rdbAmsterdam.TabStop = true;
            this.rdbAmsterdam.Tag = "7";
            this.rdbAmsterdam.Text = "Amsterdam";
            this.rdbAmsterdam.UseVisualStyleBackColor = true;
            // 
            // rdbNY
            // 
            this.rdbNY.AutoSize = true;
            this.rdbNY.Location = new System.Drawing.Point(246, 30);
            this.rdbNY.Name = "rdbNY";
            this.rdbNY.Size = new System.Drawing.Size(72, 17);
            this.rdbNY.TabIndex = 9;
            this.rdbNY.TabStop = true;
            this.rdbNY.Tag = "1";
            this.rdbNY.Text = "New York";
            this.rdbNY.UseVisualStyleBackColor = true;
            // 
            // rdbSiliconValley
            // 
            this.rdbSiliconValley.AutoSize = true;
            this.rdbSiliconValley.Location = new System.Drawing.Point(246, 53);
            this.rdbSiliconValley.Name = "rdbSiliconValley";
            this.rdbSiliconValley.Size = new System.Drawing.Size(87, 17);
            this.rdbSiliconValley.TabIndex = 10;
            this.rdbSiliconValley.TabStop = true;
            this.rdbSiliconValley.Tag = "12";
            this.rdbSiliconValley.Text = "Silicon Valley";
            this.rdbSiliconValley.UseVisualStyleBackColor = true;
            // 
            // rdbGermany
            // 
            this.rdbGermany.AutoSize = true;
            this.rdbGermany.Location = new System.Drawing.Point(246, 76);
            this.rdbGermany.Name = "rdbGermany";
            this.rdbGermany.Size = new System.Drawing.Size(67, 17);
            this.rdbGermany.TabIndex = 11;
            this.rdbGermany.TabStop = true;
            this.rdbGermany.Tag = "9";
            this.rdbGermany.Text = "Germany";
            this.rdbGermany.UseVisualStyleBackColor = true;
            // 
            // rdbAtlanta
            // 
            this.rdbAtlanta.AutoSize = true;
            this.rdbAtlanta.Location = new System.Drawing.Point(134, 30);
            this.rdbAtlanta.Name = "rdbAtlanta";
            this.rdbAtlanta.Size = new System.Drawing.Size(58, 17);
            this.rdbAtlanta.TabIndex = 6;
            this.rdbAtlanta.TabStop = true;
            this.rdbAtlanta.Tag = "6";
            this.rdbAtlanta.Text = "Atlanta";
            this.rdbAtlanta.UseVisualStyleBackColor = true;
            // 
            // rdbChicago
            // 
            this.rdbChicago.AutoSize = true;
            this.rdbChicago.Location = new System.Drawing.Point(134, 53);
            this.rdbChicago.Name = "rdbChicago";
            this.rdbChicago.Size = new System.Drawing.Size(64, 17);
            this.rdbChicago.TabIndex = 7;
            this.rdbChicago.TabStop = true;
            this.rdbChicago.Tag = "2";
            this.rdbChicago.Text = "Chicago";
            this.rdbChicago.UseVisualStyleBackColor = true;
            // 
            // rdbLA
            // 
            this.rdbLA.AutoSize = true;
            this.rdbLA.Location = new System.Drawing.Point(134, 76);
            this.rdbLA.Name = "rdbLA";
            this.rdbLA.Size = new System.Drawing.Size(83, 17);
            this.rdbLA.TabIndex = 8;
            this.rdbLA.TabStop = true;
            this.rdbLA.Tag = "5";
            this.rdbLA.Text = "Los Angeles";
            this.rdbLA.UseVisualStyleBackColor = true;
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(87, 68);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(515, 20);
            this.txtAPIKey.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Std Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vultr Proxy Tool";
            // 
            // btnCreateProxies
            // 
            this.btnCreateProxies.Location = new System.Drawing.Point(12, 471);
            this.btnCreateProxies.Name = "btnCreateProxies";
            this.btnCreateProxies.Size = new System.Drawing.Size(302, 33);
            this.btnCreateProxies.TabIndex = 12;
            this.btnCreateProxies.Text = "Create Proxies";
            this.btnCreateProxies.UseVisualStyleBackColor = true;
            this.btnCreateProxies.Click += new System.EventHandler(this.btnCreateProxies_Click);
            // 
            // btnLoadProxies
            // 
            this.btnLoadProxies.Location = new System.Drawing.Point(320, 471);
            this.btnLoadProxies.Name = "btnLoadProxies";
            this.btnLoadProxies.Size = new System.Drawing.Size(282, 33);
            this.btnLoadProxies.TabIndex = 16;
            this.btnLoadProxies.Text = "Load Proxies";
            this.btnLoadProxies.UseVisualStyleBackColor = true;
            this.btnLoadProxies.Click += new System.EventHandler(this.btnLoadProxies_Click);
            // 
            // lnkDocs
            // 
            this.lnkDocs.AutoSize = true;
            this.lnkDocs.Location = new System.Drawing.Point(9, 510);
            this.lnkDocs.Name = "lnkDocs";
            this.lnkDocs.Size = new System.Drawing.Size(32, 13);
            this.lnkDocs.TabIndex = 17;
            this.lnkDocs.TabStop = true;
            this.lnkDocs.Text = "Docs";
            this.lnkDocs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDocs_LinkClicked);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLog.Location = new System.Drawing.Point(12, 220);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(590, 245);
            this.rtxtLog.TabIndex = 18;
            this.rtxtLog.Text = resources.GetString("rtxtLog.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 532);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.lnkDocs);
            this.Controls.Add(this.btnLoadProxies);
            this.Controls.Add(this.btnCreateProxies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.lblVultrAPIKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vultr Proxy Tool";
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVultrAPIKey;
        private System.Windows.Forms.RadioButton rdbMiami;
        private System.Windows.Forms.RadioButton rdbDallas;
        private System.Windows.Forms.RadioButton rdbSeattle;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.RadioButton rdbSingapore;
        private System.Windows.Forms.RadioButton rdbTokyo;
        private System.Windows.Forms.RadioButton rdbSydney;
        private System.Windows.Forms.RadioButton rdbFrance;
        private System.Windows.Forms.RadioButton rdbUK;
        private System.Windows.Forms.RadioButton rdbAmsterdam;
        private System.Windows.Forms.RadioButton rdbNY;
        private System.Windows.Forms.RadioButton rdbSiliconValley;
        private System.Windows.Forms.RadioButton rdbGermany;
        private System.Windows.Forms.RadioButton rdbAtlanta;
        private System.Windows.Forms.RadioButton rdbChicago;
        private System.Windows.Forms.RadioButton rdbLA;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateProxies;
        private System.Windows.Forms.Button btnLoadProxies;
        private System.Windows.Forms.LinkLabel lnkDocs;
        private System.Windows.Forms.RichTextBox rtxtLog;
    }
}

