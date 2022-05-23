using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqlconn = new SqlConnection();
            sqlconn.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=SomeDB;Trusted_Connection=True;"; 
            sqlconn.Open();

            var adapter = new SqlDataAdapter("SELECT * from SomeTable", sqlconn);

            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlconn.Close();
        }
    }
}
