using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicaretDesktopAdmin.Control
{
    public class PageElementControl
    {
/////////////////Form Açma Kontrolü Sadece///////////////
        Form? _form;
        public Button RjButton(string text, string name, int w, int h, Color color, int x, int y, Form form = null)
        {
            RJButton button = new RJButton();
            button.Text = text;
            button.Name = name;
            button.Width = w;
            button.Height = h;
            button.Location = new Point(x, y);
            button.Enabled = true;
            button.BackColor = color;
            button.Click += RjButtonClick;
            _form = form;
            return button;
        }
        private void RjButtonClick(object sender, EventArgs e)
        {
            if (_form != null)
                PageControl.OpenPage(_form);
        }
    }
}