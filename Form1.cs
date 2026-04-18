using System.Data;

namespace Note_Taking_App
{
    public partial class Form1 : Form
    {
        DataTable Table;
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        { 
            textTitle.Text = "";
            textNotes.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Table = new DataTable();
            Table.Columns.Add("Title", typeof(string));
            Table.Columns.Add("Note", typeof(string));
            dataGridView1.DataSource = Table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        public void editData(string title, string note)
        {
            string s = title;
            string n = note;
            Table.Rows.Add(s, n);
            clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new FormEdit();
                m.Show();
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    textTitle.Text = Table.Rows[index].ItemArray[0].ToString();
                    textNotes.Text = Table.Rows[index].ItemArray[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Nothing to edit.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textTitle == null && this.textNotes == null)
            {
                MessageBox.Show("Error: Nothing to add.");
            }
            else if (this.textTitle.Text == "" && this.textNotes.Text == "")
            {
                MessageBox.Show("Error: Nothing to add.");
            }
            else if (this.textTitle.Text == "" || this.textNotes.Text == "")
            {
                MessageBox.Show("Error: Title or Note both must not Empty.");
            }
            else
            {
                Table.Rows.Add(textTitle.Text, textNotes.Text);
            }

            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    string s = Table.Rows[index].ItemArray[0].ToString();
                    string n = Table.Rows[index].ItemArray[1].ToString();
                    MessageBox.Show("Title: " + s + "\nNote: " + n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Nothing to read.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Table.Rows[index].Delete();
        }
    }
}
