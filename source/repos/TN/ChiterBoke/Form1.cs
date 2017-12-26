using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiterBoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (tableDataGridView.CurrentRow != null)
                        tableDataGridView.Rows.RemoveAt(tableDataGridView.CurrentRow.Index);
                    tableTableAdapter.Update(database1DataSet.Table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tableTableAdapter.Update(database1DataSet.Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableDataGridView.RowCount; i++)
            {
                tableDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < tableDataGridView.ColumnCount; j++)
                    if (tableDataGridView.Rows[i].Cells[j].Value != null)
                        if (tableDataGridView.Rows[i].Cells[j].Value.ToString().Contains(idTextBox.Text))
                        {
                            tableDataGridView.Rows[i].Selected = true;
                            tableDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            break;
                        }
            }


            /* string selectString =
                 "Name Like '%" + idTextBox.Text.Trim() + "%'";

            DataGridViewRowCollection allRows =
                 tableDataGridView.Rows;

             DataRow[] searchedRows =
                 ((DataTable)tableDataGridView.).
                 Select(selectString);

             int rowIndex = allRows.IndexOf(searchedRows[0]);

             tableDataGridView.CurrentCell =
                 tableDataGridView[0, rowIndex];


            /*for (int i = 0; i < tableDataGridView.RowCount; i++)
                if (tableDataGridView[1, i].FormattedValue.ToString().
                    Contains(idTextBox.Text.Trim()))
                {
                    tableDataGridView.CurrentCell = tableDataGridView[0, i];
                    return;
                }*/
            }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableDataGridView.RowCount; i++)
            {
                tableDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < tableDataGridView.ColumnCount; j++)
                    if (tableDataGridView.Rows[i].Cells[j].Value != null)
                        if (tableDataGridView.Rows[i].Cells[j].Value.ToString().Contains(idTextBox.Text))
                        {
                            tableDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
