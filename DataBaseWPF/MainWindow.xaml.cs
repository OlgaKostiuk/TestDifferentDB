using DataBaseApi;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace DataBaseWPF
{
    public partial class MainWindow : Window
    {
        TablePanel tablePanel = null;
        public MainWindow()
        {
            InitializeComponent();
            string[] types = { "Binary", "BinaryL", "MS SQL", "MY SQL", "H2", "MONGODB", "CSV", "CSV_L", "JSON", "JSON_L", "XML", "XML_L", "YAML", "YAML_L", "MS SQL EF" };

            foreach(string t in types)
            {
                SQLSwitcher.Items.Add(t);
            }
            tablePanel = new TablePanel("Binary");
        }

        private void bCreate_Click(object sender, RoutedEventArgs e)
        {
            tablePanel.Create(GetPerson());
        }

        private void bRead_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = tablePanel.Read();
        }

        private void bUpdate_Click(object sender, RoutedEventArgs e)
        {
            tablePanel.Update(GetPerson());
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            tablePanel.Delete(GetPerson());
        }

        private void SelectDB(object sender, SelectionChangedEventArgs e)
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
