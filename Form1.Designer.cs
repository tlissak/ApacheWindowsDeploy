namespace ApacheWindowsDeploy
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbApachePath = new System.Windows.Forms.TextBox();
            this.btnBrowseApache = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePhp = new System.Windows.Forms.Button();
            this.tbPhpPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInstanceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbApachePath
            // 
            this.tbApachePath.Location = new System.Drawing.Point(9, 25);
            this.tbApachePath.Name = "tbApachePath";
            this.tbApachePath.Size = new System.Drawing.Size(275, 20);
            this.tbApachePath.TabIndex = 0;
            // 
            // btnBrowseApache
            // 
            this.btnBrowseApache.Location = new System.Drawing.Point(286, 25);
            this.btnBrowseApache.Name = "btnBrowseApache";
            this.btnBrowseApache.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseApache.TabIndex = 1;
            this.btnBrowseApache.Text = "Browse";
            this.btnBrowseApache.UseVisualStyleBackColor = true;
            this.btnBrowseApache.Click += new System.EventHandler(this.btnBrowseApache_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.Location = new System.Drawing.Point(286, 113);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(75, 20);
            this.btnDeploy.TabIndex = 2;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apache24 Path";
            // 
            // btnBrowsePhp
            // 
            this.btnBrowsePhp.Location = new System.Drawing.Point(286, 68);
            this.btnBrowsePhp.Name = "btnBrowsePhp";
            this.btnBrowsePhp.Size = new System.Drawing.Size(75, 20);
            this.btnBrowsePhp.TabIndex = 13;
            this.btnBrowsePhp.Text = "Browse";
            this.btnBrowsePhp.UseVisualStyleBackColor = true;
            this.btnBrowsePhp.Click += new System.EventHandler(this.btnBrowsePhp_Click);
            // 
            // tbPhpPath
            // 
            this.tbPhpPath.Location = new System.Drawing.Point(9, 68);
            this.tbPhpPath.Name = "tbPhpPath";
            this.tbPhpPath.Size = new System.Drawing.Size(275, 20);
            this.tbPhpPath.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PHP Path";
            // 
            // tbInstanceName
            // 
            this.tbInstanceName.Location = new System.Drawing.Point(12, 113);
            this.tbInstanceName.Name = "tbInstanceName";
            this.tbInstanceName.Size = new System.Drawing.Size(272, 20);
            this.tbInstanceName.TabIndex = 16;
            this.tbInstanceName.Text = "Apache";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instance Name";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 152);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(350, 79);
            this.tbLog.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 243);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbInstanceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowsePhp);
            this.Controls.Add(this.tbPhpPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.btnBrowseApache);
            this.Controls.Add(this.tbApachePath);
            this.Name = "Form1";
            this.Text = "Install Apache Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbApachePath;
        private System.Windows.Forms.Button btnBrowseApache;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsePhp;
        private System.Windows.Forms.TextBox tbPhpPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInstanceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLog;
    }
}

