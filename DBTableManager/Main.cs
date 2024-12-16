using System;
using System.Windows.Forms;

namespace DBTableManager
{
    public partial class MainForm : Form
    {
        private DataBaseConnector _connector;
        private DBOperations _operation;


        public DataGridView DataGridProp
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }


        private string _currentTable;

        public string CurrentTable
        {
            get { return _currentTable; }
            set { _currentTable = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            _connector = new DataBaseConnector(@"Data source=restrauntDB.db");
            _operation = new DBOperations(_connector, this);

            _operation.LoadTablesList(comboBoxTables);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _operation.LoadTables(CurrentTable);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operation.AddEntry(comboBoxTables, CurrentTable);
            _operation.LoadTables(CurrentTable);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _operation.DeleteEntry(CurrentTable, DataGridProp);
                _operation.LoadTables(CurrentTable);
            }
            else
            {
                MessageBox.Show("Select something to delete first.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _operation.ModifyEntry(CurrentTable);
                _operation.LoadTables(CurrentTable);
            }
        }
        
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTable = comboBoxTables.SelectedItem.ToString();
            _operation.LoadTables(CurrentTable);
        }
        
    }
}