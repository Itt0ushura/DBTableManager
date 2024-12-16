using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DBTableManager
{
    internal class DBOperations
    {
        private DataBaseConnector _connector;
        private MainForm _mainForm;

        public DBOperations(DataBaseConnector connector, MainForm mainForm)
        {
            _connector = connector;
            _mainForm = mainForm;
        }

        public void DeleteEntry(string tableName, DataGridView dataGridView)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                string idRow = dataGridView.Columns[0].HeaderText;
                string query = $"DELETE FROM {tableName} WHERE {idRow}={id}";
                _connector.StartNoQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
        }

        
        public void AddEntry(ComboBox comboBox, string tableName)
        {

            string query = $"PRAGMA table_info({tableName});";

            DataTable columns = _connector.StartQuery(query);

            using (EnterForm enterForm = new EnterForm(columns))
            {
                if (enterForm.ShowDialog() == DialogResult.OK)
                {
                    var columnNames = new List<string>();
                    var values = new List<string>();
                    foreach(DataRow row in columns.Rows)
                    {
                        string columnName = row["name"].ToString();
                        string value = enterForm.GetValueFromDict(columnName);
                        columnNames.Add(columnName);
                        values.Add($"'{value}'");
                    }

                    string insertQuery = $"INSERT INTO {tableName}({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", values)});";
                    _connector.StartNoQuery(insertQuery);
                }
            }
        }



        public void ModifyEntry(string tableName)
        {

            string query = $"PRAGMA table_info({tableName});";

            DataTable columns = _connector.StartQuery(query);
            using (EnterForm enterForm = new EnterForm(columns))
            {
                if (enterForm.ShowDialog() == DialogResult.OK)
                {
                    int id = Convert.ToInt32(_mainForm.DataGridProp.SelectedRows[0].Cells[0].Value);
                    var columnNames = new List<string>();
                    var values = new List<string>();
                    var setPair = new List<string>();
                    foreach (DataRow row in columns.Rows)
                    {
                        string columnName = row["name"].ToString();
                        string value = enterForm.GetValueFromDict(columnName);
                        columnNames.Add(columnName);
                        setPair.Add($"{columnName}='{value}'");
                    }
                    string updateQuery = $"UPDATE {tableName} SET {string.Join(", ", setPair)} WHERE {columnNames[0]} = {id};";
                    _connector.StartNoQuery(updateQuery);

                }
            }
        }


        public void LoadTablesList(ComboBox comboBoxTables)
        {
            try
            {
                string query = "SELECT name FROM sqlite_master WHERE type='table'";
                DataTable tableNames = _connector.StartQuery(query);

                comboBoxTables.Items.Clear();

                foreach (DataRow row in tableNames.Rows)
                {
                    comboBoxTables.Items.Add(row["name"].ToString());
                }
                if (comboBoxTables.Items.Count > 0)
                {
                    comboBoxTables.SelectedIndex = 0;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public void LoadTables(string tableName)
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";
                DataTable tableData = _connector.StartQuery(query);
                _mainForm.DataGridProp.DataSource = tableData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }
    }
}
