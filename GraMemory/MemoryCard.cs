using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMemory
{
    class MemoryCard : Label
    {
        public Guid ID;
        public Image Front;
        public Image Back;

        public MemoryCard(Guid iD, string front, string back)
        {
            ID = iD;
            Front = Image.FromFile(front);
            Back = Image.FromFile(back);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Zakryj()
        {
            BackgroundImage = Back;
            Enabled = true;
        }

        public void Odkryj()
        {
            BackgroundImage = Front;
            Enabled = false;
        }

        public void Usun()
        {
            BackgroundImage = null;
            Enabled = false;
        }
    }
}
