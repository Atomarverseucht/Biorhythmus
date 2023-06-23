namespace Biorhythmus
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNutzername = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.tbPasswortbestaetigung = new System.Windows.Forms.TextBox();
            this.cbPasswort = new System.Windows.Forms.CheckBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbNutzername
            // 
            resources.ApplyResources(this.tbNutzername, "tbNutzername");
            this.tbNutzername.Name = "tbNutzername";
            // 
            // tbPasswort
            // 
            resources.ApplyResources(this.tbPasswort, "tbPasswort");
            this.tbPasswort.Name = "tbPasswort";
            // 
            // tbPasswortbestaetigung
            // 
            resources.ApplyResources(this.tbPasswortbestaetigung, "tbPasswortbestaetigung");
            this.tbPasswortbestaetigung.Name = "tbPasswortbestaetigung";
            // 
            // cbPasswort
            // 
            resources.ApplyResources(this.cbPasswort, "cbPasswort");
            this.cbPasswort.Name = "cbPasswort";
            this.cbPasswort.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            resources.ApplyResources(this.btRegister, "btRegister");
            this.btRegister.Name = "btRegister";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.Name = "btLogin";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.cbPasswort);
            this.Controls.Add(this.tbPasswortbestaetigung);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbNutzername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tbPasswortbestaetigung;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.TextBox tbNutzername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.CheckBox cbPasswort;
    }
}