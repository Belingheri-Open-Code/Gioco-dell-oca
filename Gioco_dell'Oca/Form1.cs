using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gioco_dell_Oca
{
    public partial class Form1 : Form
    {
        public int ToccaAd = 1;
        public Pedina giocatore1= new Pedina();
        public Pedina giocatore2 = new Pedina();
        Button gioc1 = new Button();
        Button gioc2 = new Button();
        cas_spec[] prova = new cas_spec[63];
        Label punteggioDadi = new Label();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            punteggioDadi.AutoSize = true;
            punteggioDadi.Location = new System.Drawing.Point(920, 411);
            punteggioDadi.Name = "punteggioDadi";
            punteggioDadi.Size = new System.Drawing.Size(35, 13);
            punteggioDadi.TabIndex = 1;
            punteggioDadi.Text = "";
            punteggioDadi.Visible = true;
            punteggioDadi.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(punteggioDadi);
            gioc1.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioc1.Location = new System.Drawing.Point(200, 12);
            gioc1.Name = "button_gioc1";
            gioc1.Size = new System.Drawing.Size(38, 25);
            gioc1.TabIndex = 0;
            gioc1.BackColor = System.Drawing.Color.Blue;
            gioc1.UseVisualStyleBackColor = false;
            gioc1.Show();
            this.Controls.Add(gioc1);
            gioc2.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioc2.Location = new System.Drawing.Point(200, 12 + 25);
            gioc2.Name = "button_gioc2";
            gioc2.Size = new System.Drawing.Size(38, 25);
            gioc2.TabIndex = 0;
            gioc2.BackColor = System.Drawing.Color.Red;
            gioc2.UseVisualStyleBackColor = false;
            this.Controls.Add(gioc2);
            /* 0=normale;
             * 1=bonus oca;
             * 2=ponte;
             * 3=nido;
             * 4=prigione;
             * 5=labirinto;
             * 6=scheletro;
             * 7=sveglia;
             * 8=mago;
             */
            int riga=12,colonna=200;
            int trig, tcolo;
            int[] funzone = new int[63+1];
            for (int i = 1; i < 63+1; i++)
            {
                Button temp = new Button();
                temp.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                temp.Location = new System.Drawing.Point(colonna, riga);
                trig = riga;
                tcolo = colonna;
                temp.Name = "button_" + i.ToString();
                temp.Size = new System.Drawing.Size(114, 74);
                temp.TabIndex = 0;
                temp.Text = i.ToString();
                temp.BackColor = System.Drawing.SystemColors.Info;
                temp.UseVisualStyleBackColor = false;
                this.Controls.Add(temp);

                if ((i < 15)||(i < 61 && i > 47 ))
                    colonna += temp.Width + 1;
                else if ((i < 25 && i > 14)||(i < 64 && i > 60))
                    riga += temp.Height + 1;
                else if (i < 40 && i > 24)
                    colonna -= temp.Width - 1;
                else if (i < 48 && i > 39)
                    riga -= temp.Height - 1;
                if ((i % 9 == 0 &&i!=63) || i == 5 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50 || i == 59)
                {
                    prova[i - 1] = new Oca();
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                    funzone[i - 1] = 1;
                }
                else if (i  == 37)
                {
                    prova[i - 1] = new Ponte();
                    funzone[i - 1] = 2;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i == 16)
                {
                    prova[i - 1] = new Casa();
                    funzone[i - 1] = 3;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i == 24)
                {
                    prova[i - 1] = new Prigione();
                    funzone[i - 1] = 4;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i  == 61)
                {
                    prova[i - 1] = new Labirinto();
                    funzone[i - 1] = 5;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i == 34 )
                {
                    prova[i - 1] = new Scheletro();
                    funzone[i - 1] = 6;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i == 57)
                {
                    prova[i - 1] = new Sveglia();
                    funzone[i - 1] = 7;
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                }
                else if (i == 7)
                {
                    prova[i - 1] = new Mago();
                    temp.Image = Image.FromFile(prova[i - 1].Indirizzo_Immagine);
                    temp.ImageAlign = ContentAlignment.MiddleRight;
                    temp.TextAlign = ContentAlignment.MiddleLeft;
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Text = "";
                    funzone[i - 1] = 8;
                }
                else
                {
                    prova[i - 1] = new cas_spec();
                    funzone[i - 1] = 0;
                }
                prova[i - 1].NumeroCasella = i;

                prova[i - 1].colonna = tcolo ;
                prova[i - 1].riga = trig ;
            }
            Button dadi = new Button();
            dadi.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dadi.Location = new System.Drawing.Point(920, 324);
            dadi.Name = "button_Dadi";
            dadi.Size = new System.Drawing.Size(130, 87);
            dadi.TabIndex = 0;
            dadi.BackColor = System.Drawing.SystemColors.Info;
            dadi.UseVisualStyleBackColor = false;
            dadi.Image = Image.FromFile("./dado.jpg");
            dadi.ImageAlign = ContentAlignment.MiddleRight;
            dadi.TextAlign = ContentAlignment.MiddleLeft;
            dadi.FlatStyle = FlatStyle.Flat;
            dadi.Click += new System.EventHandler(this.lancioDadi);
            this.Controls.Add(dadi);
            
            Start_button.Location = new System.Drawing.Point(12, 12);
        }
        public void lancioDadi(object sender, EventArgs e)
        {
            Random genera = new Random();
            int numeroRandom = genera.Next(1, 12);
            //MessageBox.Show("N: "+numeroRandom.ToString()+"\ncas corr: "+giocatore1.CasellaCorrente.ToString());
            avanza(numeroRandom);
            punteggioDadi.Text = numeroRandom.ToString();
            //MessageBox.Show(numeroRandom.ToString());
            //avanza(6);
        }
        public void avanza(int n)
        {
            
            if (ToccaAd == 1)
            {
                ToccaAd = 0;
                if (giocatore1.attesa == 0)
                {
                    giocatore1.CasellaCorrente += n;
                    gioc1.Location = new System.Drawing.Point(prova[giocatore1.CasellaCorrente - 1].colonna, prova[giocatore1.CasellaCorrente - 1].riga);
                    if (prova[giocatore1.CasellaCorrente - 1].Messaggio!="")
                        MessageBox.Show(prova[giocatore1.CasellaCorrente - 1].Messaggio,"Giocatore 1");
                    int temp=prova[giocatore1.CasellaCorrente - 1].azione(giocatore1.CasellaCorrente, n);
                    if (temp == 300 || temp == 100)
                    {
                        giocatore1.attesa = temp/100;
                    }
                    else
                    {
                        giocatore1.CasellaCorrente += temp;
                        gioc1.Location = new System.Drawing.Point(prova[giocatore1.CasellaCorrente - 1].colonna, prova[giocatore1.CasellaCorrente - 1].riga);
                        if (giocatore1.CasellaCorrente == 63)
                        {
                            MessageBox.Show("Giocatore 1","\nHAI VINTO");
                            gioc1.Location = new System.Drawing.Point(prova[0].colonna, prova[0].riga);
                            giocatore1.CasellaCorrente = 1;
                            gioc2.Location = new System.Drawing.Point(prova[0].colonna, prova[0].riga + 25);
                            giocatore2.CasellaCorrente = 1;
                        }
                    }
                }
                else
                    giocatore1.attesa--;
            }
            else
            {
                ToccaAd = 1;
                if (giocatore2.attesa == 0)
                {
                    giocatore2.CasellaCorrente += n;
                    gioc2.Location = new System.Drawing.Point(prova[giocatore2.CasellaCorrente - 1].colonna, prova[giocatore2.CasellaCorrente - 1].riga + 25);
                    if (prova[giocatore2.CasellaCorrente - 1].Messaggio!="")
                        MessageBox.Show(prova[giocatore2.CasellaCorrente - 1].Messaggio, "Giocatore 2");
                    int temp=prova[giocatore2.CasellaCorrente - 1].azione(giocatore2.CasellaCorrente, n);
                    if ( temp== 300||temp==100)
                    {
                        giocatore2.attesa = temp/100;
                    }
                    else
                    {
                        giocatore2.CasellaCorrente += temp;
                        gioc2.Location = new System.Drawing.Point(prova[giocatore2.CasellaCorrente - 1].colonna, prova[giocatore2.CasellaCorrente - 1].riga + 25);
                        if (giocatore2.CasellaCorrente == 63)
                        {
                            MessageBox.Show("Giocatore 2", "\nHAI VINTO");
                            gioc1.Location = new System.Drawing.Point(prova[0].colonna, prova[0].riga);
                            giocatore1.CasellaCorrente = 1;
                            gioc2.Location = new System.Drawing.Point(prova[0].colonna, prova[0].riga + 25);
                            giocatore2.CasellaCorrente = 1;
                        }
                    }
                }
                else
                    giocatore2.attesa--;
            }
        }
    }
}
