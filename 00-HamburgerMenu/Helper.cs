using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_HamburgerMenu
{
    static class Helper
    {
        public static void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is ComboBox) ((ComboBox)item).SelectedIndex = 0;
                else if (item is TextBox) ((TextBox)item).Text = "";
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name == "rbKucuk") rb.Checked = true;
                    else rb.Checked = false;
                }
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                else if (item is CheckBox) ((CheckBox)item).Checked = false;
                else if (item is GroupBox) Temizle(((GroupBox)item).Controls);
                else if (item is FlowLayoutPanel) Temizle(((FlowLayoutPanel)item).Controls);
            }
        }
    }
}
