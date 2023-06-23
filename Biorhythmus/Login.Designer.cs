namespace Biorhythmus
{
    partial class Login
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
            this.btRegister = new System.Windows.Forms.Button();
            this.btAnmeldung = new System.Windows.Forms.Button();
            this.cbPasswort = new System.Windows.Forms.CheckBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.tbNutzername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.White;
            this.btRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btRegister.Location = new System.Drawing.Point(43, 323);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(193, 23);
            this.btRegister.TabIndex = 19;
            this.btRegister.Text = "Noch kein Konto?";
            this.btRegister.UseVisualStyleBackColor = false;
            // 
            // btAnmeldung
            // 
            this.btAnmeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAnmeldung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAnmeldung.Location = new System.Drawing.Point(43, 276);
            this.btAnmeldung.Name = "btAnmeldung";
            this.btAnmeldung.Size = new System.Drawing.Size(193, 41);
            this.btAnmeldung.TabIndex = 18;
            this.btAnmeldung.Text = "Login";
            this.btAnmeldung.UseVisualStyleBackColor = true;
            this.btAnmeldung.Click += new System.EventHandler(this.btAnmeldung_Click);
            // 
            // cbPasswort
            // 
            this.cbPasswort.AutoSize = true;
            this.cbPasswort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbPasswort.Location = new System.Drawing.Point(137, 233);
            this.cbPasswort.Name = "cbPasswort";
            this.cbPasswort.Size = new System.Drawing.Size(97, 17);
            this.cbPasswort.TabIndex = 17;
            this.cbPasswort.Text = "zeige Passwort";
            this.cbPasswort.UseVisualStyleBackColor = true;
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(43, 199);
            this.tbPasswort.Multiline = true;
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(193, 28);
            this.tbPasswort.TabIndex = 15;
            // 
            // tbNutzername
            // 
            this.tbNutzername.Location = new System.Drawing.Point(42, 136);
            this.tbNutzername.Multiline = true;
            this.tbNutzername.Name = "tbNutzername";
            this.tbNutzername.Size = new System.Drawing.Size(192, 28);
            this.tbNutzername.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(36, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(39, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Passwort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nutzername:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btAnmeldung);
            this.Controls.Add(this.cbPasswort);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbNutzername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btAnmeldung;
        private System.Windows.Forms.CheckBox cbPasswort;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.TextBox tbNutzername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}