using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oop_w15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=;database=oopdb";
                string Query = "select * from author;";
                MySqlConnection MyConn3 = new MySqlConnection (MyConnection3);
                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand3;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable;



                // MyConn3.Close(); 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=;database=oopdb";

                string Query = "insert into author(aut_name,aut_address,aut_phone) values('" + this.txtAutName.Text + "','" + this.txtAutAddress.Text + "','" + this.txtAutPhone.Text + "');";

                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);

                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);

                MySqlDataReader MyReader3;

                MyConn3.Open();

                MyReader3 = MyCommand3.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader3.Read())
                {



                }

                MyConn3.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=;database=oopdb";
                string Query = "update author set aut_name='" + this.txtAutName.Text + "',aut_address='" + this.txtAutAddress.Text + "',aut_phone='" + this.txtAutPhone.Text + "'" + "' where aut_id'" + this.txtAutId.Text + "';";
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);

                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);

                MySqlDataReader MyReader3;

                MyConn3.Open();

                MyReader3 = MyCommand3.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader3.Read())
                {



                }

                MyConn3.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection3 = "datasource=localhost;port=3306;username=root;password=;database=oopdb";

                string Query = "delete from author where aut_name'" + this.txtAutName.Text + "';";

                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);

                MySqlCommand MyCommand3 = new MySqlCommand(Query, MyConn3);

                MySqlDataReader MyReader3;

                MyConn3.Open();

                MyReader3 = MyCommand3.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader3.Read())
                {



                }

                MyConn3.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }
    }
}
