using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Biorhythmus
{
    public partial class Kondition : Form
    {
        public Kondition()
        {
            InitializeComponent();
        }
      
        bool mode = true;
        Biorhythmus bio = new Biorhythmus();
            int weiss = 240;
            int schwarz = 50;
        private void BtDark_Click(object sender, EventArgs e)
        {
            Darkmode();         
        }

        public void Darkmode()
        {
            if (mode == false)
            {


                this.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                label1.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                label4.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbAusgabe.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbDatum.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbKondition.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                btVerarbeitung.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                btVerarbeitung.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                dtpGeburtstag.CalendarForeColor = Color.FromArgb(weiss, weiss, weiss);
                dtpGeburtstag.CalendarTitleBackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                pnDiagramm.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                pnDiagramm.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                rtbTabelle.BackColor = Color.FromArgb(schwarz,schwarz,schwarz);
                rtbTabelle.ForeColor = Color.FromArgb(weiss,weiss,weiss);
                lbUhr.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                mode = true;
                btDark.Text = "Lightmode";
            }
            else
            {
                
                this.BackColor = Color.FromArgb(weiss, weiss, weiss);
                label1.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                label4.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbAusgabe.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbDatum.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbKondition.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                btVerarbeitung.BackColor = Color.FromArgb(weiss, weiss, weiss);
                btVerarbeitung.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                dtpGeburtstag.CalendarForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                dtpGeburtstag.CalendarTitleBackColor = Color.FromArgb(weiss, weiss, weiss);
                pnDiagramm.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                pnDiagramm.BackColor = Color.FromArgb(weiss, weiss, weiss);
                rtbTabelle.BackColor = Color.FromArgb(weiss, weiss, weiss);
                rtbTabelle.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbUhr.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                mode = false;
                btDark.Text = "Darkmode";

            }
        }
      

            public void Uhr()
            {
            string output;
                bio.setDatumAufHeute();
            if (bio.getMinute() >= 10)
            {
                output = "Uhrzeit: " + Convert.ToString(bio.getStunde()) + ":" + Convert.ToString(bio.getMinute());
            }
            else
            {
                output = "Uhrzeit: " + Convert.ToString(bio.getStunde()) + ":0" + Convert.ToString(bio.getMinute());
            }
            if(bio.getSekunde() >= 10) 
            {
                lbUhr.Text=output + ":" + Convert.ToString(bio.getSekunde());
            }
            else
            {
               lbUhr.Text = output + ":0" + Convert.ToString(bio.getSekunde());
            }
            }

        private void DtpGeburtstag_ValueChanged(object sender, EventArgs e)
        {

            lbAusgabe.Text = "Du hast vor " + bio.berechneTagesdifferenz(dtpGeburtstag.Value.Day, dtpGeburtstag.Value.Month, dtpGeburtstag.Value.Year) + " Tagen das Licht der Welt erblickt.";
            lbDatum.Text = "Datum: " + bio.getTag() + "." + bio.getMonat() + "." + bio.getJahr();

            zeichneKonditionPrognose_60Tage(pnDiagramm.CreateGraphics());
            lbKondition.Text = "Körperlich: " + Math.Round(bio.berechneKonditionKoerperlich(0), 2) + "%" + "\n Geistig: " + Math.Round(bio.berechneKonditionGeistig(0), 2) + "%" + "\n Psychisch: " + Math.Round(bio.berechneKonditionPsychisch(0), 2) + "%";
            rtbTabelle.Text = bio.erzeugeKonditionPrognose_14Tage();
            
        }
        public void zeichneKonditionPrognose_60Tage(Graphics g)
        {
            int koerperlich_1, geistig_1, psychisch_1; int koerperlich_2, geistig_2, psychisch_2;
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Pen penGreen = new Pen(Color.Green);
            Pen penBlack = new Pen(Color.Black);
            Pen penWhite = new Pen(Color.White);
            if (mode == false)
            {

                SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(weiss,weiss,weiss));
                g.FillRectangle(whiteBrush, 0, 0, 240, 127);
                g.DrawLine(penBlack, 0, 110, 240, 110);
                g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.Black), 2, 124);
                g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.Black), 115, 124);
                g.DrawString("Tage", new Font("Arial", 12), new SolidBrush(Color.Black), 212, 124);
            }
            else
            {
                SolidBrush blackBrush = new SolidBrush(Color.FromArgb(schwarz,schwarz,schwarz));
                g.FillRectangle(blackBrush, 0, 0, 240, 127);
                g.DrawLine(penWhite, 0, 110, 240, 110);
                g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.White), 2, 124);
                g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.White), 115, 124);
                g.DrawString("Tage", new Font("Arial", 12), new SolidBrush(Color.White), 212, 124);
            }
            for (int t = 0; t <= 59; t++)
            {
                koerperlich_1 = (int)(110 - bio.berechneKonditionKoerperlich(t));
                geistig_1 = (int)(110 - bio.berechneKonditionGeistig(t)); psychisch_1 = (int)(110 - bio.berechneKonditionPsychisch(t));
                koerperlich_2 = (int)(110 - bio.berechneKonditionKoerperlich(t + 1));
                geistig_2 = (int)(110 - bio.berechneKonditionGeistig(t + 1));
                psychisch_2 = (int)(110 - bio.berechneKonditionPsychisch(t + 1));
                g.DrawLine(penBlue, 4 * t, koerperlich_1, 4 * (t + 1), koerperlich_2);
                g.DrawLine(penRed, 4 * t, geistig_1, 4 * (t + 1), geistig_2);
                g.DrawLine(penGreen, 4 * t, psychisch_1, 4 * (t + 1), psychisch_2);
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Uhr();
        }

        private void Kondition_Load(object sender, EventArgs e)
        {
            Darkmode();
           
        }
        
    }
}
