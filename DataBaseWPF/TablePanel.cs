using DataBaseApi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataBaseWPF
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

        public List<Person> Read()
        {
            return db.Read();
        }

        public void Update(Person person)
        {
            db.Update(person);
        }

        public void ClearTable(DataGrid dgv)
        {
            dgv.ItemsSource = null;
        }
    }
}
