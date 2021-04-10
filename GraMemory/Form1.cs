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

namespace GraMemory
{
    public partial class Form1 : Form
    {
        GameSettings ustawienia = new GameSettings();

        public Form1()
        {
            InitializeComponent();

            UstawKontrolki();
            UstawKarty();
        }

        private void UstawKarty()
        {
            string[] cardsFront = Directory.GetFiles(ustawienia.FolderObrazki);
            ustawienia.MaxPunkty = cardsFront.Length;

            var cards = new List<MemoryCard>();
            foreach (var item in cardsFront)
            {
                MemoryCard karta = new MemoryCard(Guid.NewGuid(), item, ustawienia.PlikLogo);
            }
        }

        void UstawKontrolki()
        {
            panelKart.Width = ustawienia.Kolumny * ustawienia.Bok;
            panelKart.Height = ustawienia.Wiersze * ustawienia.Bok;

            this.Width = panelKart.Width + 50;
            this.Height = panelKart.Height + 105;

            labelWartoscCzas.Text = ustawienia.CzasGry.ToString();
            labelWartoscPunkty.Text = ustawienia.AktualnePunkty.ToString();
            labelStartInfo.Text = "Początek gry za " + ustawienia.CzasPodgladu;
        }
    }
}
