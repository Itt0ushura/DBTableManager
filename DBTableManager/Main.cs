using System;
using System.Windows.Forms;

namespace DBTableManager
{
    public partial class MainForm : Form
    {

        private DataBaseConnector _connector;
        private DBOperations _operation;
        private string _dataSourcePath;

        public string DataSourcePath
        {
            get { return _dataSourcePath; }
            set { _dataSourcePath = value; }
        }

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
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _operation.LoadTables(CurrentTable, DataGridProp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operation.AddEntry(comboBoxTables, CurrentTable);
            _operation.LoadTables(CurrentTable, DataGridProp);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _operation.DeleteEntry(CurrentTable, DataGridProp);
                _operation.LoadTables(CurrentTable, DataGridProp);
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
                _operation.ModifyEntry(CurrentTable, DataGridProp);
                _operation.LoadTables(CurrentTable, DataGridProp);
            }
            else
            {
                MessageBox.Show("Select something to modify first.");
            }
        }
        
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentTable = comboBoxTables.SelectedItem.ToString();
            _operation.LoadTables(CurrentTable, DataGridProp);
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
            _connector = new DataBaseConnector($@"Data source={_dataSourcePath}");
            _operation = new DBOperations(_connector);

            _operation.LoadTablesList(comboBoxTables);
        }


        public void OpenFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Filter = "sql database files (*.db)|*.db| All Files (*.*)|*.*";
                ofd.Title = "Select your database file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _dataSourcePath = ofd.FileName;
                }
            }
        }
    }
}