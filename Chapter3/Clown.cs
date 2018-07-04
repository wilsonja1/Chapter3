using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3
{
    class Clown
    {
        public string Name;
        public int Height;

        public void TalkAbout()
        {
            MessageBox.Show("My Name is " + Name + "and I am " + Height + "inches tall.");
        }

        public static void testi()
        {
            MessageBox.Show("Is this right?");
        }
    }
}
