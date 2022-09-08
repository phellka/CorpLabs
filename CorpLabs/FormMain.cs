using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpLabs.models;
using MadyshevVisualComponents.models;

namespace CorpLabs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            madyshevListBox.AddItem("1");
            madyshevListBox.AddItem("Two");
            madyshevListBox.AddItem("3");
            madyshevListBox.AddItem("4");
            madyshevListBox.AddItem("Five");
            madyshevListBox.AddItem("6");

            madyshevDataGridView.AddColumns(new List<TableData>() {
                new TableData() { Header = "Age", PropertyName = "Age", Visible = true, Width = 50},
                new TableData() { Header = "Name", PropertyName = "Name", Visible = true, Width = 100},
                new TableData() { Header = "Surname", PropertyName = "Surname", Visible = true, Width = 200},
                new TableData() { Header = "Id", PropertyName = "Id", Visible = true, Width = 20 } });
            madyshevDataGridView.AddRow(new Human() { Id = 1, Age = 15, Name = "Pavel", Surname = "Pavlov" });
            madyshevDataGridView.AddRow(new Human() { Id = 2, Age = 24, Name = "Artem", Surname = "Artemov" });
            madyshevDataGridView.AddRow(new Human() { Id = 3, Age = 38, Name = "Ivan", Surname = "Ivanov" });
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            madyshevListBox.ClearItems();
        }

        private void buttonGetSelected_Click(object sender, EventArgs e)
        {
            string select = madyshevListBox.ListBoxValue;
            MessageBox.Show(select, "selected item");
        }

        private void buttonSetSelected_Click(object sender, EventArgs e)
        {
            madyshevListBox.ListBoxValue = textBoxSelectedItem.Text;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                double? value = madyshevTextBox.TextBoxValue;
                MessageBox.Show(value?.ToString(), "value");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearGrid_Click(object sender, EventArgs e)
        {
            madyshevDataGridView.ClearRows();
        }

        private void buttonGetSelectedIndexGrid_Click(object sender, EventArgs e)
        {
            MessageBox.Show(madyshevDataGridView.DataGridSelectedRow.ToString(), "selected item");
        }

        private void buttonSetSelectedIndexGrid_Click(object sender, EventArgs e)
        {
            madyshevDataGridView.DataGridSelectedRow = ((int)numericUpDownSelectedIndexGrid.Value);
        }

        private void buttonGriSelectedObjectGrid_Click(object sender, EventArgs e)
        {
            MessageBox.Show(madyshevDataGridView.GetSelectedObjectIntoRow<Human>().ToString(), "Selected object");
        }
    }
}
