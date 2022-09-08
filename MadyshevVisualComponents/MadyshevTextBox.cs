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
        public event EventHandler CheckedChanged;
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
                if (!Regex.IsMatch(textBox.Text, @"((\d+)(\,+)(\d+))$"))
                {
                    throw new Exception("invalid format");
                }
                return Convert.ToDouble(textBox.Text);
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
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Enabled = !checkBox.Checked;
            CheckedChanged?.Invoke(sender, e);
        }
    }
}
