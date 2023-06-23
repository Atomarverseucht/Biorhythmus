namespace Biorhythmus
{
    partial class Kondition
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
            this.components = new System.ComponentModel.Container();
            this.dtpGeburtstag = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.btVerarbeitung = new System.Windows.Forms.Button();
            this.lbAusgabe = new System.Windows.Forms.Label();
            this.lbKondition = new System.Windows.Forms.Label();
            this.pnDiagramm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbTabelle = new System.Windows.Forms.RichTextBox();
            this.btDark = new System.Windows.Forms.Button();
            this.lbUhr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbSprache = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpGeburtstag
            // 
            this.dtpGeburtstag.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpGeburtstag.Location = new System.Drawing.Point(107, 69);
            this.dtpGeburtstag.MaxDate = new System.DateTime(2814, 12, 31, 0, 0, 0, 0);
            this.dtpGeburtstag.Name = "dtpGeburtstag";
            this.dtpGeburtstag.Size = new System.Drawing.Size(200, 20);
            this.dtpGeburtstag.TabIndex = 0;
            this.dtpGeburtstag.ValueChanged += new System.EventHandler(this.DtpGeburtstag_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geburtsdatum:";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(28, 108);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(54, 13);
            this.lbDatum.TabIndex = 2;
            this.lbDatum.Text = "Datum: xy";
            // 
            // btVerarbeitung
            // 
            this.btVerarbeitung.Location = new System.Drawing.Point(6, 142);
            this.btVerarbeitung.Name = "btVerarbeitung";
            this.btVerarbeitung.Size = new System.Drawing.Size(403, 23);
            this.btVerarbeitung.TabIndex = 3;
            this.btVerarbeitung.Text = "verarbeite";
            this.btVerarbeitung.UseVisualStyleBackColor = true;
            this.btVerarbeitung.Click += new System.EventHandler(this.btVerarbeitung_Click);
            // 
            // lbAusgabe
            // 
            this.lbAusgabe.AutoSize = true;
            this.lbAusgabe.Location = new System.Drawing.Point(66, 196);
            this.lbAusgabe.Name = "lbAusgabe";
            this.lbAusgabe.Size = new System.Drawing.Size(36, 13);
            this.lbAusgabe.TabIndex = 4;
            this.lbAusgabe.Text = "noice!";
            // 
            // lbKondition
            // 
            this.lbKondition.AutoSize = true;
            this.lbKondition.Location = new System.Drawing.Point(66, 250);
            this.lbKondition.Name = "lbKondition";
            this.lbKondition.Size = new System.Drawing.Size(35, 13);
            this.lbKondition.TabIndex = 5;
            this.lbKondition.Text = "label3";
            // 
            // pnDiagramm
            // 
            this.pnDiagramm.Location = new System.Drawing.Point(453, 294);
            this.pnDiagramm.Name = "pnDiagramm";
            this.pnDiagramm.Size = new System.Drawing.Size(288, 174);
            this.pnDiagramm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teste deine Kondition";
            // 
            // rtbTabelle
            // 
            this.rtbTabelle.Location = new System.Drawing.Point(441, 69);
            this.rtbTabelle.Name = "rtbTabelle";
            this.rtbTabelle.ReadOnly = true;
            this.rtbTabelle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTabelle.Size = new System.Drawing.Size(330, 194);
            this.rtbTabelle.TabIndex = 8;
            this.rtbTabelle.Text = "";
            // 
            // btDark
            // 
            this.btDark.Location = new System.Drawing.Point(6, 518);
            this.btDark.Name = "btDark";
            this.btDark.Size = new System.Drawing.Size(75, 23);
            this.btDark.TabIndex = 9;
            this.btDark.Text = "Darkmode";
            this.btDark.UseVisualStyleBackColor = true;
            this.btDark.Click += new System.EventHandler(this.BtDark_Click);
            // 
            // lbUhr
            // 
            this.lbUhr.AutoSize = true;
            this.lbUhr.Location = new System.Drawing.Point(352, 108);
            this.lbUhr.Name = "lbUhr";
            this.lbUhr.Size = new System.Drawing.Size(34, 13);
            this.lbUhr.TabIndex = 10;
            this.lbUhr.Text = "At:om";
            this.lbUhr.Click += new System.EventHandler(this.lbUhr_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btEmail
            // 
            this.btEmail.Location = new System.Drawing.Point(145, 507);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(277, 23);
            this.btEmail.TabIndex = 11;
            this.btEmail.Text = "Email versenden";
            this.btEmail.UseVisualStyleBackColor = true;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email eingeben:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(230, 481);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(192, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // cbSprache
            // 
            this.cbSprache.FormattingEnabled = true;
            this.cbSprache.Items.AddRange(new object[] {
            "Deutsch",
            "Englisch"});
            this.cbSprache.Location = new System.Drawing.Point(739, 518);
            this.cbSprache.Name = "cbSprache";
            this.cbSprache.Size = new System.Drawing.Size(121, 21);
            this.cbSprache.TabIndex = 14;
            this.cbSprache.SelectedIndexChanged += new System.EventHandler(this.cbSprache_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sprache:";
            // 
            // Kondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSprache);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.lbUhr);
            this.Controls.Add(this.btDark);
            this.Controls.Add(this.rtbTabelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnDiagramm);
            this.Controls.Add(this.lbKondition);
            this.Controls.Add(this.lbAusgabe);
            this.Controls.Add(this.btVerarbeitung);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpGeburtstag);
            this.Name = "Kondition";
            this.Text = "Biorhythmus";
            this.Load += new System.EventHandler(this.Kondition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGeburtstag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Button btVerarbeitung;
        private System.Windows.Forms.Label lbAusgabe;
        private System.Windows.Forms.Label lbKondition;
        private System.Windows.Forms.Panel pnDiagramm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTabelle;
        private System.Windows.Forms.Button btDark;
        private System.Windows.Forms.Label lbUhr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbSprache;
        private System.Windows.Forms.Label label3;
    }
}
