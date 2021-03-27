using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMemory
{
    class GameSettings
    {
        public int CzasGry;
        public int CzasPodgladu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int AktualnePunkty;

        public string PlikLogo = $"{AppDomain.CurrentDomain.BaseDirectory}\\Obrazki\\logo.jpg";
        public string FolderObrazki = $"{AppDomain.CurrentDomain.BaseDirectory}\\Obrazki\\Karty";

        public GameSettings()
        {
            UstawienieStartowe();
        }

        private void UstawienieStartowe()
        {
            CzasPodgladu = 5;
            CzasGry = 60;
            MaxPunkty = 0;
            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            AktualnePunkty = 0;
        }
    }
}
