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
                var id = Guid.NewGuid(); 
                MemoryCard karta = new MemoryCard(id, item, ustawienia.PlikLogo);
                MemoryCard karta2 = new MemoryCard(id, item, ustawienia.PlikLogo);
                cards.Add(karta);
                cards.Add(karta2);
            }

            Random random = new Random();

            for(int i = 0; i < ustawienia.Wiersze; i++)
            {
                for(int j = 0; j < ustawienia.Kolumny; j++)
                {
                    var wylosowanyIndex = random.Next(0, cards.Count);
                    var wylosowanaKarta = cards[wylosowanyIndex];

                    wylosowanaKarta.Height = ustawienia.Bok;
                    wylosowanaKarta.Width = ustawienia.Bok;
                    int margines = 2;
                    wylosowanaKarta.Location = new Point((j * ustawienia.Bok) + (margines * j), (i * ustawienia.Bok) + (margines * i));

                    wylosowanaKarta.Odkryj();
                    panelKart.Controls.Add(wylosowanaKarta);

                    cards.Remove(wylosowanaKarta);
                }
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
