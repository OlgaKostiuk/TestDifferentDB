using DataBaseApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseWF
{
    public partial class Form1 : Form
    {
        TablePanel tablePanel = null;
        public Form1()
        {
            InitializeComponent(); 
            string[] types = { "Binary", "BinaryL", "MS SQL", "MY SQL", "H2", "MONGODB", "CSV", "CSV_L", "JSON", "JSON_L", "XML", "XML_L", "YAML", "YAML_L", "MS SQL EF", "Mock" };

            foreach (string t in types)
            {
                SQLSwitcher.Items.Add(t);
            }
            SQLSwitcher.SelectedIndex = 0;
            tablePanel = new TablePanel("Binary");
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            tablePanel.Delete(GetPerson());
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            tablePanel.Update(GetPerson());
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = tablePanel.Read();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            tablePanel.Create(GetPerson());
        }

        private void SQLSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablePanel = new TablePanel(SQLSwitcher.SelectedItem.ToString());
            tablePanel.ClearTable(dataGrid);
        }

        private Person GetPerson()
        {
            int id = Int32.Parse(boxId.Text);
            string fn = boxFirstName.Text;
            string ln = boxLastName.Text;
            int age = Int32.Parse(boxAge.Text);
            return new Person(id, fn, ln, age);
        }
    }
}
