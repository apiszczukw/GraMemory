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

        public MemoryCard(Guid iD, Image front, Image back)
        {
            ID = iD;
            Front = front;
            Back = back;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
