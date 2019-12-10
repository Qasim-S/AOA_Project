using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace translator
{
    public partial class DataFiller : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOAT4VF\SQLEXPRESS01;Initial Catalog=Translator;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            disp_data();
        }

        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dictionary";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dictionary values ('" + word.Text + "','" + (translation.Text) + "','" + partOfSpeech.Text + "')";
            cmd.ExecuteNonQuery();

            word.Text = "";
            translation.Text = "";
            partOfSpeech.Text = "";
            disp_data();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dictionary where word = '" + (word.Text) + "'";
            cmd.ExecuteNonQuery();
            disp_data();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dictionary set word = ' " + (word.Text) + " ', translation = ' " + (translation.Text) + " ', part-of-speech = ' " + (partOfSpeech.Text) + " 'where word = '" + (word.Text) + "'";
            cmd.ExecuteNonQuery();
            disp_data();
        }
    }
}