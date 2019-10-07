using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Aknakereso.Properties;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aknakereso
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        static Color[] szinek =
        {
            Color.Black,
            Color.Blue,
            Color.Green,
            Color.Red,
            Color.DarkBlue,
            Color.Brown,
            Color.Turquoise,
            Color.Purple,
            Color.DarkGray
        };

        bool elso = true;
        public int palyaX;
        public int palyaY;

        AknButton[,] palya;

        public FrmMain()
        {
            InitializeComponent();

            var meretAblak = new FrmMeret(this);
            meretAblak.ShowDialog();
            SetPalya();
        }

        private void SetPalya()
        {
            palya = new AknButton[palyaX, palyaY];

            for (int s = 0; s < palya.GetLength(0); s++)
            {
                for (int o = 0; o < palya.GetLength(1); o++)
                {
                    palya[s, o] = new AknButton();
                    palya[s, o].SetBounds(o * 50, s * 50, 50, 50);
                    palya[s, o].Akna = rnd.Next(100) < 25;
                    palya[s, o].MouseUp += AknClick;

                    palya[s, o].ImageAlign = ContentAlignment.MiddleCenter;
                    palya[s, o].BackgroundImageLayout = ImageLayout.Stretch;

                    palya[s, o].Font = new Font("Comic Sans MS", 16F, FontStyle.Italic);

                    palya[s, o].X = s;
                    palya[s, o].Y = o;

                    this.Controls.Add(palya[s, o]);
                }
            }
        }

        private void AknClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (sender as AknButton).BackgroundImage = Resources.flag;
            }
            else
            {
                if (elso && (sender as AknButton).Akna)
                {
                    int x, y;

                    do
                    {
                        x = rnd.Next(palyaX);
                        y = rnd.Next(palyaY);
                    } while (!palya[x, y].Akna);

                    palya[x, y].Akna = true;
                    (sender as AknButton).Akna = false;
                }
                elso = false;

                (sender as AknButton).BackColor = Color.White;
                (sender as AknButton).Flag = true;

                if ((sender as AknButton).Akna)
                {
                    (sender as AknButton).BackgroundImage = Resources.mine;
                }
                else
                {
                    int korbeDb = Vizsgal(sender as AknButton, e);

                    if (korbeDb != 0)
                    {
                        (sender as AknButton).Text = korbeDb + "";
                    }
                }
            }
        }

        
        private int Vizsgal(AknButton btn, MouseEventArgs e)
        {
            int dbAkn = 0;
            var kattintani = new List<AknButton>();

            for (int s = btn.X - 1; s <= btn.X + 1; s++)
            {
                for (int o = btn.Y - 1; o <= btn.Y + 1; o++)
                {
                    if (o >= 0 && s >= 0 && s < palyaX && o < palyaY)
                    {
                        if (palya[s, o].Akna) dbAkn++;
                        else if (!palya[s, o].Flag)
                        {
                            kattintani.Add(palya[s, o]);
                        }
                    }
                }
            }

            if (dbAkn == 0)
            {
                foreach (var b in kattintani)
                {
                    AknClick(b, e);
                }
            }

            btn.ForeColor = szinek[dbAkn];

            return dbAkn;
        }
    }
}
