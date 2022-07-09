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
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("https://link.storjshare.io/jxu7x3q2w22ls6lq7x3diqrozlka/publicresources%2FQuotesRandom.txt?download=1", "quotes.txt");
            Client.DownloadFile("https://link.storjshare.io/jwiechv4ycd2ysoxiufzfmdfldya/publicresources%2Fbackgrounds%2F1.jpg?download=1", "1.jpg");
            Client.DownloadFile("https://link.storjshare.io/jvref5prl4mb4johwa4xik6i2f4q/publicresources%2Fbackgrounds%2F2.jpg?download=1", "2.jpg");
            Client.DownloadFile("https://link.storjshare.io/jvge35wr2r4pc2kgtaiaiizjd25q/publicresources%2Fbackgrounds%2F3.jpg?download=1", "3.jpg");
            Client.DownloadFile("https://link.storjshare.io/jxhcai4ktnczukynsezlkufzdcdq/publicresources%2Fbackgrounds%2F4.jpg?download=1", "4.jpg");
            Client.DownloadFile("https://link.storjshare.io/jvdp6neovneonhu2pc6zu32de6qq/publicresources%2Fbackgrounds%2F5.jpg?download=1", "5.jpg");
            Client.DownloadFile("https://link.storjshare.io/jvfvq3nhdta2rgc5vduk3x3nvdsq/publicresources%2Fbackgrounds%2F6.jpg?download=1", "6.jpg");
            Client.DownloadFile("https://link.storjshare.io/jvncubbznwmej5zhxwz2lpezgwwa/publicresources%2Fbackgrounds%2F7.jpg?download=1", "7.jpg");

            //Initialise quotes string array
            string[] quotes = new string[new System.IO.FileInfo("quotes.txt").Length];

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

            foreach (var element in quotes)
            {
                var split = element.Split('~');
                /* Usage:
                 * split[0] is for the quote text
                 * split[1] is for the quotes author
                 */
            }

            //Search for required quote by cycling through them all
            bool found = false;
            int i = 0;
            do
            {
                if (quotes[i])
            } while (found == false);
        }
    }
}
