using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadyshevVisualComponents
{
    public partial class MadyshevTextBox : UserControl
    {
        private event EventHandler checkedChanged;
        public double? TextBoxValue
        {
            get
            {
                if (checkBox.Checked)
                {
                    return null;
                }
                if (textBox.Text == "")
                {
                    throw new Exception("value not entered");
                }
                Double res = 0;
                if (Double.TryParse(textBox.Text, out res))
                {
                    return res;
                }
                else
                {
                    throw new Exception("invalid format");
                }
            }
            set
            {
                if (!checkBox.Checked)
                {
                    textBox.Text = value.ToString();
                }
            }
        }
        public MadyshevTextBox()
        {
            InitializeComponent();
            checkBox.CheckedChanged += (sender, e) => checkedChanged?.Invoke(sender, e);
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Enabled = !checkBox.Checked;
        }
        public event EventHandler CheckedChanged
        {
            add { checkedChanged += value; }
            remove { checkedChanged -= value; }
        }
    }
}
