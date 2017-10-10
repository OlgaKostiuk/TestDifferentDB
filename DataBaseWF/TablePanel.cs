using DataBaseApi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseWF
{
    public class TablePanel
    {
        IPersonDAO db = null;

        public TablePanel(string type)
        {
            db = DBFactory.GetInstance(type);
        }

        public void Create(Person person)
        {
            db.Create(person);
        }

        public void Delete(Person person)
        {
            db.Delete(person);
        }

        public DataTable Read()
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("FirstName");
            dataTable.Columns.Add("LastName");
            dataTable.Columns.Add("Age");

            List<Person> listPerson = db.Read();

            foreach(Person person in listPerson)
            {
                DataRow dr = dataTable.NewRow();
                dr.SetField(0, person.Id);
                dr.SetField(1, person.FirstName);
                dr.SetField(2, person.LastName);
                dr.SetField(3, person.Age);
                dataTable.Rows.Add(dr);
            }

            return dataTable;
        }

        public void Update(Person person)
        {
            db.Update(person);
        }

        public void ClearTable(DataGridView dgv)
        {
            dgv.DataSource = new DataTable();
        }

    }
}
