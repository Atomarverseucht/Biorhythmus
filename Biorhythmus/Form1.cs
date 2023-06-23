using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Media;
using System.Collections.Generic;

namespace Biorhythmus
{
    public partial class Kondition : Form
    {
        public Kondition()
        {
            InitializeComponent();
        }
        //Objekt für Klasse Biorhythmus
        Biorhythmus bio = new Biorhythmus();

        //Variablen
        bool mode = true;
        int weiss = 240;
        int schwarz = 50;

        //Sternzeichenmethode
        public string sucheSternzeichen(int geburtstag, int geburtsmonat)
        {
            //Liste "Sternzeichen" erstellen
            List<String> sternzeichen = new List<String>();
            sternzeichen.Add("Steinbock");
            sternzeichen.Add("Wassermann");
            sternzeichen.Add("Fisch");
            sternzeichen.Add("Widder");
            sternzeichen.Add("Stier");
            sternzeichen.Add("Zwilling");
            sternzeichen.Add("Krebs");
            sternzeichen.Add("Löwe");
            sternzeichen.Add("Jungfrau");
            sternzeichen.Add("Waage");
            sternzeichen.Add("Skorpion");
            sternzeichen.Add("Schütze");
            sternzeichen.Add("Steinbock");

            //Vergleichsliste erstellen, welche benötigt wird um zu wissen welcher Tag Stichtag im jeweiligen Monat ist
            List<int> vergleichstag = new List<int>();
            vergleichstag.Add(0); //Monat 0 existiert nicht und der Wert ist somit egal
            vergleichstag.Add(21);
            vergleichstag.Add(20);
            vergleichstag.Add(21);
            vergleichstag.Add(21);
            vergleichstag.Add(21);
            vergleichstag.Add(22);
            vergleichstag.Add(23);
            vergleichstag.Add(24);
            vergleichstag.Add(24);
            vergleichstag.Add(24);
            vergleichstag.Add(23);
            vergleichstag.Add(22);

            //Sternzeichen abrufen
            if (geburtstag>=vergleichstag[geburtsmonat])
            {
                return sternzeichen[geburtsmonat];
            }
            else
            {
                return sternzeichen[geburtsmonat - 1];
            }

        }
        
        private void BtDark_Click(object sender, EventArgs e)
        {
            Darkmode();
        }

        public void Darkmode()
        {
            if (mode == false)                                                              // Darkmode
            {

                //Label
                this.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                label1.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                label4.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbAusgabe.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbDatum.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbKondition.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                lbUhr.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                label2.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                label2.BackColor = Color.FromArgb(schwarz,schwarz, schwarz);
                //Button
                btVerarbeitung.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                btVerarbeitung.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                btEmail.BackColor = Color.FromArgb(schwarz,schwarz,schwarz);
                btEmail.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                //Richtextbox
                rtbTabelle.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                rtbTabelle.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                //Textbox
                tbEmail.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                tbEmail.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);
                //Panel
                pnDiagramm.ForeColor = Color.FromArgb(weiss, weiss, weiss);
                pnDiagramm.BackColor = Color.FromArgb(schwarz, schwarz, schwarz);

                //Technik hinter "btDark"
                mode = true;
                btDark.Text = "Lightmode";
            }
            else                                                                            // Lightmode
            {
                //Label
                this.BackColor = Color.FromArgb(weiss, weiss, weiss);
                label1.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                label4.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbAusgabe.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbDatum.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbKondition.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                lbUhr.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                label2.BackColor = Color.FromArgb(weiss, weiss, weiss);
                label2.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                //Button
                btVerarbeitung.BackColor = Color.FromArgb(weiss, weiss, weiss);
                btVerarbeitung.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                btEmail.BackColor = Color.FromArgb(weiss, weiss, weiss);
                btEmail.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                //Panel
                pnDiagramm.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                pnDiagramm.BackColor = Color.FromArgb(weiss, weiss, weiss);
                //Richtextbox
                rtbTabelle.BackColor = Color.FromArgb(weiss, weiss, weiss);
                rtbTabelle.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);
                //Textbox
                tbEmail.BackColor = Color.FromArgb(weiss, weiss, weiss);
                tbEmail.ForeColor = Color.FromArgb(schwarz, schwarz, schwarz);

                //Technik hinter "btDark"
                mode = false;
                btDark.Text = "Darkmode";

            }
        }


        public void Uhr()
        {
            string output;
            bio.setDatumAufHeute();

            //verhindert das 8:03:07, als 8:3:7 angezeigt wird
            if (bio.getMinute() >= 10)
            {
                output = text[5] + Convert.ToString(bio.getStunde()) + ":" + Convert.ToString(bio.getMinute());
            }
            else
            {
                output = text[5] + Convert.ToString(bio.getStunde()) + ":0" + Convert.ToString(bio.getMinute());
            }
            if (bio.getSekunde() >= 10)
            {
                lbUhr.Text = output + ":" + Convert.ToString(bio.getSekunde());
            }
            else
            {
                lbUhr.Text = output + ":0" + Convert.ToString(bio.getSekunde());
            }
        }

        private void DtpGeburtstag_ValueChanged(object sender, EventArgs e) //Der eigentliche konditionsrechner wird ausgeführt (Anzeige)
        {

            lbAusgabe.Text = text[9] + bio.berechneTagesdifferenz(dtpGeburtstag.Value.Day, dtpGeburtstag.Value.Month, dtpGeburtstag.Value.Year) + text[10];
            lbDatum.Text = text[4] + bio.getTag() + "." + bio.getMonat() + "." + bio.getJahr()+"\t\t Dein Sternzeichen ist: "+sucheSternzeichen(dtpGeburtstag.Value.Day, dtpGeburtstag.Value.Month);

            zeichneKonditionPrognose_60Tage(pnDiagramm.CreateGraphics());
            lbKondition.Text = text[6] + Math.Round(bio.berechneKonditionKoerperlich(0), 2) + "%" + "\n"+text[7] + Math.Round(bio.berechneKonditionGeistig(0), 2) + "%" + "\n"+text[8] + Math.Round(bio.berechneKonditionPsychisch(0), 2) + "%";
            rtbTabelle.Text = bio.erzeugeKonditionPrognose_14Tage();
        }

        //Methode für Panel
        public void zeichneKonditionPrognose_60Tage(Graphics g)
        {
            int koerperlich_1, geistig_1, psychisch_1; int koerperlich_2, geistig_2, psychisch_2;
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Pen penGreen = new Pen(Color.Green);
            Pen penBlack = new Pen(Color.Black);
            Pen penWhite = new Pen(Color.White);

            // Dark-/Lightmode
            if (mode == false)
            {

                SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(weiss, weiss, weiss));
                g.FillRectangle(whiteBrush, 0, 0, 240, 127);
                g.DrawLine(penBlack, 0, 110, 240, 110);
                g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.Black), 2, 124);
                g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.Black), 115, 124);
                g.DrawString("60 Tage" +
                    "", new Font("Arial", 12), new SolidBrush(Color.Black), 212, 124);
            }
            else
            {
                SolidBrush blackBrush = new SolidBrush(Color.FromArgb(schwarz, schwarz, schwarz));
                g.FillRectangle(blackBrush, 0, 0, 240, 127);
                g.DrawLine(penWhite, 0, 110, 240, 110);
                g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.White), 2, 124);
                g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.White), 115, 124);
                g.DrawString("60 Tage", new Font("Arial", 12), new SolidBrush(Color.White), 212, 124);
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


        //führt Uhr aus
        private void timer1_Tick(object sender, EventArgs e)
        {
            Uhr();
        }

        //wird ausgeführt wenn Form "Kondition" geladen wurde
        private void Kondition_Load(object sender, EventArgs e)
        {
            Darkmode();
            bio.setDatumAufHeute();
            lbDatum.Text = "Datum: " + bio.getTag() + "." + bio.getMonat() + "." + bio.getJahr();
            Sprache();
        }

       
        //Emailfeature
        private void btEmail_Click(object sender, EventArgs e)
        {
            //SMTP
            SmtpClient pclient = new SmtpClient();
            pclient.Host = "smtp.gmail.com";
            pclient.Port = 587;
            pclient.EnableSsl = true;
            pclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            pclient.UseDefaultCredentials = false;
            pclient.Credentials = new NetworkCredential()
            {
                //Zugangsdaten für den Bot-Account
                UserName = "projekt.bio.mail@gmail.com",
                Password = "a1s2d3f4."
            };
            //eigentliche Email
            MailAddress FromEmail = new MailAddress("projekt.bio.mail@gmail.com", "Informatik Projekt");
            MailAddress ToEmail = new MailAddress(tbEmail.Text, "Jemand");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Ihre Kondition",
                Body = "Kondition für den Geburtstag: "+ dtpGeburtstag.Value.Day+"."+ dtpGeburtstag.Value.Month+"."+ dtpGeburtstag.Value.Year+":\n\nKörperlich: " + Math.Round(bio.berechneKonditionKoerperlich(0), 2) + "%" + "\n Geistig: " + Math.Round(bio.berechneKonditionGeistig(0), 2) + "%" + "\n Psychisch: " + Math.Round(bio.berechneKonditionPsychisch(0), 2) + "%" +
                "\n\n nächste 14 Tage:\n"+ bio.erzeugeKonditionPrognose_14Tage() + "\n\n\n\n Botnachricht gesendet von einem C# Biorhythmus Projekt!"
            };
            Message.To.Add(ToEmail);
            try
            {
                //Email versenden
                pclient.Send(Message);

                //Rückmeldung
                MessageBox.Show("email erfolgreich gesendet", "Fertig");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Etwas ist falsch!\n", "Fehler!");
            }
        }
        //Rickroll durch Hyperlink
        private void btVerarbeitung_Click(object sender, EventArgs e)
        {
        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=a3Z7zEc7AXQ");
       

        }

        //Among Us Sound Effect
        private void lbUhr_Click(object sender, EventArgs e)
        {
SoundPlayer sound = new SoundPlayer("Among Us sus.wav");
            sound.PlaySync();
        }

            //Sprachlisten
            List<string> text = new List<string>();
            List<string> deutsch = new List<string>();
            List<string> english = new List<string>();
        private void cbSprache_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sprache();
        }
        public void Sprache()
        {
            text.Clear();
            deutsch.Clear();
            english.Clear();
            deutsch.Add("Geburtsdatum:");
            deutsch.Add("Email-Adresse:");
            deutsch.Add("Sprache:");
            deutsch.Add("Teste deine Kondition!");
            deutsch.Add("Datum:");
            deutsch.Add("Uhrzeit: ");
            deutsch.Add("Körperlich: ");
            deutsch.Add("Geistig: ");
            deutsch.Add("Psychisch: ");
            deutsch.Add("Du hast vor ");
            deutsch.Add(" Tagen das licht der Welt erblickt!");

            english.Add("Date of Birth:");
            english.Add("Email adres:");
            english.Add("Language:");
            english.Add("Test your condition!");
            english.Add("Date:");
            english.Add("Clock time: ");
            english.Add("Physically: ");
            english.Add("mentally: ");
            english.Add("psychically: ");
            english.Add("You saw the light of day ");
            english.Add(" days ago");

            switch (cbSprache.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 11; i++)
                    {
                        text.Add(deutsch[i]);
                    }
                    break;
                case 1:
                    for (int i = 0; i < 11; i++)
                    {
                        text.Add(english[i]);
                    }
                    break;
                default:
                    for (int i = 0; i < 11; i++)
                    {
                        text.Add(deutsch[i]);
                    }
                    break;

            }


            label1.Text = text[0];
            label2.Text = text[1];
            label3.Text = text[2];
            label4.Text = text[3];
            
        }
        
    } 
}
