using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace MadyshevVisualComponents
{
    public partial class MadyshevListBox : UserControl
    {
        private event EventHandler selectedIndexChanged;
        public string ListBoxValue
        {
            set
            {
                if (listBox.Items.Contains(value))
                {
                    listBox.Text = value;
                }
            }
            get
            {
                return listBox.Text;
            }
        }
        public MadyshevListBox()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += new System.EventHandler(this.SelectIndexChanged);
            listBox.SelectedIndexChanged += (sender, e) => selectedIndexChanged?.Invoke(sender, e);
        }
        public void AddItem(string item)
        {
            listBox.Items.Add(item);
        }
        public void ClearItems()
        {
            listBox.Items.Clear();
            listBox.ResetText();
        }
        private void SelectIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            base.OnSizeChanged(e);
        }
        public event EventHandler SelectedIndexChanged
        {
            add { selectedIndexChanged += value;  }
            remove { selectedIndexChanged -= value;  }
        }
    }
}
