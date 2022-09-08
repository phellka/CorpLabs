using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MadyshevVisualComponents.models;

namespace MadyshevVisualComponents
{
    public partial class MadyshevDataGridView : UserControl
    {
        public int DataGridSelectedRow
        {
            set
            {
                if (value >= 0 && value < dataGridView.Rows.Count)
                {
                    dataGridView.Rows[value].Selected = true;
                }
            }
            get
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    return dataGridView.SelectedRows[0].Index;
                }
                else
                {
                    return -1;
                }
            }
        }
        public MadyshevDataGridView()
        {
            InitializeComponent();
        }

        public void AddColumns(List<TableData> tableData)
        {
            for (int i = 0; i < tableData.Count; ++i)
            {
                int index = dataGridView.Columns.Add(tableData[i].PropertyName, tableData[i].Header);
                dataGridView.Columns[index].Visible = tableData[i].Visible;
                dataGridView.Columns[index].Width = tableData[i].Width;
            }
        }
        public void ClearRows()
        {
            dataGridView.Rows.Clear();
        }
        public void AddRow<T>(T objectMy)
        {
            int count = dataGridView.Columns.Count;
            string[] objValues = new string[count];
            var type = typeof(T);
            for (int j = 0; j < dataGridView.Columns.Count; ++j)
            {
                var tt = dataGridView.Columns[j];
                var propInfo = type.GetProperty(dataGridView.Columns[j].Name);
                objValues[j] = propInfo.GetValue(objectMy).ToString();
            }
            int rowId = dataGridView.Rows.Add();
            var row = dataGridView.Rows[rowId];
            for (int i = 0; i < count; i++)
            {
                row.Cells[i].Value = objValues[i];
            }
        }
        public T GetSelectedObjectIntoRow<T>()
        {
            if (dataGridView.SelectedRows.Count < 1)
            {
                throw new Exception("row doesnt selected");
            }
            if (dataGridView.Rows.Count < 2)
            {
                throw new Exception("row doesnt exist");
            }
            T objectMy = (T)Activator.CreateInstance(typeof(T));
            var propertiesObj = typeof(T).GetProperties();
            foreach (var properties in propertiesObj)
            {
                bool propIsExist = false;
                int columnIndex;
                for (columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
                {
                    if (dataGridView.Columns[columnIndex].Name.ToString() == properties.Name)
                    {
                        propIsExist = true;
                        break;
                    }
                }
                if (!propIsExist)
                {
                    throw new Exception("propertie doesnt exists");
                }
                object value = dataGridView.SelectedRows[0].Cells[columnIndex].Value;
                properties.SetValue(objectMy, Convert.ChangeType(value, properties.PropertyType));
            }
            return objectMy;
        }
    }
}
