using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class DisplayScreen : UserControl
    {
        public DisplayScreen()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Person[] data = [
                new() {Name = "John", Salary = 30_000m},
                new() {Name = "Mary", Salary = 45_000m},
                new() {Name = "Jim", Salary = 50_000m},
                new() {Name = "Korawich Chunoi", Salary = 100_000m}
                ];

            dataGridView1.Rows.Clear();
            for (int i = 0; i < data.Length; i++)
                dataGridView1.Rows.Add(data[i].Name, data[i].Salary);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
                return;
            var row = rows[0];
            Debug.WriteLine(row.Cells[0].Value + ", " + row.Cells[1].Value);

            txtName.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value is decimal)
                txtSalary.Text = ((decimal)row.Cells[1].Value).ToString("N2");
            else
                txtSalary.Text = "";
        }
    }
}
