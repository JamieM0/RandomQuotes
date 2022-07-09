using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RandomQuotes
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
            if (!File.Exists("quotes.txt"))
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460088414351411/QuotesRandom.txt", "quotes.txt");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460268245139466/1.jpg", "1.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460268530343936/2.jpg", "2.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460268773625866/3.jpg", "3.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460269046251560/4.jpg", "4.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460269314674738/5.jpg", "5.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460269570535565/6.jpg", "6.jpg");
                Client.DownloadFile("https://cdn.discordapp.com/attachments/995459834184999053/995460269817987222/7.jpg", "7.jpg");


            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //Initialise quotes string array
            string[] quotes = new string[File.ReadAllLines("quotes.txt").Count()];

            //Read in quotes from file
            using (StreamReader sr = new StreamReader("quotes.txt"))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    quotes[i] = sr.ReadLine();
                    i++;
                }
            }

            //Select 2 random numbers
            Random rnd = new Random();
            int rnd1 = rnd.Next(1, quotes.Length);
            int rnd2 = rnd.Next(1, 7);

            //Set background image of form
            this.BackgroundImage = Image.FromFile("" + rnd2 + ".jpg");

            string QuoteAndAuthor = quotes[rnd1];
            lbQuote.Text = QuoteAndAuthor.Split('~')[0];
            lbAuthor.Text = QuoteAndAuthor.Split('~')[1];
        }
    }
}
