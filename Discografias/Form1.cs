using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discografias
{
    public partial class Form1 : Form
    {
        private List<String> albums = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string dir = textBox1.Text;
                String[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
                foreach (String file in files)
                {
                    var cancion = TagLib.File.Create(file);
                    string artista = cancion.Tag.JoinedAlbumArtists;
                    if (!artistas.Items.Contains(artista))
                    {
                        artistas.Items.Add(artista);
                    }
                }
            }
            catch (Exception ew)
            {
                System.Console.WriteLine(ew.Message);
            }
        }
    }
}
