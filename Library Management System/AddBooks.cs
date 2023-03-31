using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String bname = txtBookName.Text;
            String bauthor = txtAuthor.Text;
            String bpublication=txtPublication.Text;
            String bdate=dateTimeBook.Text;
            Int64 price= Int64.Parse(txtPrice.Text);
            Int64 quan = Int64.Parse(txtQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-N81RA4R\\SQLEXPRESS; database= libraryyy; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NewBookkk (bname, bAuthor, bPubl, bDate, bPrice, bQuan) values ('"+bname+"', '" + bauthor + "', '" + bpublication + "', '" + bdate + "', " + price + ", " + quan + " )";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }
    }
}
