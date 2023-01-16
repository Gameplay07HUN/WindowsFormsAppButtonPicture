using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppButtonPicture
{
    public partial class Form1 : Form
    {
        int sorokSzama = 30;
        int oszlopokSzema = 60;
        int imageSize = 300;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzema; j++)
                {
                    PictureBox picture = new PictureBox();
                    picture.SetBounds(j * imageSize, i * imageSize, imageSize, imageSize);
                    picture.Text = (i * oszlopokSzema + j).ToString();
                    picture.Click += (o, ev) =>
                    {
                        PictureBox kep = (PictureBox)o;
                        kep.Image =(Properties.Resources.bottom_gear);
                        kep.SizeMode=PictureBoxSizeMode.StretchImage;
                    };
                    KepCuccPanel.Controls.Add(picture);
                }
            }
        }
    }
}
