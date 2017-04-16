using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideesouper.ViewController
{
    public class ControlDefaultText
    {
        public Control control { get; set; }
        public string texte { get; set; }

        public ControlDefaultText(Control control, string texte)
        {
            this.control = control;
            this.texte = texte;
        }
    }
}
