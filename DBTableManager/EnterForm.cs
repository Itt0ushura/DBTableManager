using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DBTableManager
{
    public partial class EnterForm : Form
    {
        private Dictionary<string, TextBox> _textboxes = new Dictionary<string, TextBox>(); //dictionary to store TKey = name of column TValue = textbox to place

        public EnterForm(DataTable columns)
        {
            InitializeComponent();
            int x = 5;

            foreach (DataRow row in columns.Rows)
            {
                string columnName = row["name"].ToString();

                Label label = new Label() { Text = columnName, Location = new Point(x, 10) };

                TextBox textbox = new TextBox() { Location = new Point(x, 40), Size = new Size(120, 20) };

                Controls.Add(label);
                Controls.Add(textbox);
                                
                _textboxes[columnName] = textbox;
                
                x += 200;
            }
        }

        public string GetValueFromDict(string columnName)
        {
            return _textboxes[columnName].Text;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
