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

namespace StudentsListCRUD
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server = localhost; Database = studentsdb; Uid = root;";
        int studentsID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("studentsAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_studentsID", studentsID);
                mySqlCmd.Parameters.AddWithValue("_studentsEmri", txtEmri.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_studentsMbiemri", txtMbiemri.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_studentsProfili", txtProfili.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("studentsViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblStudents = new DataTable();
                sqlDa.Fill(dtblStudents);
                dgvStudents.DataSource = dtblStudents;
                dgvStudents.Columns[0].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txtEmri.Text = txtMbiemri.Text = txtProfili.Text = txtKerko.Text = "";
            studentsID = 0;
            buttonRuaj.Text = "Ruaj";
            buttonFshi.Enabled = false;
           
        }

        private void dgvStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgvStudents.CurrentRow.Index != -1)
            {
                txtEmri.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                txtMbiemri.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                txtProfili.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                studentsID = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                buttonRuaj.Text = "Perditso";
                buttonFshi.Enabled = Enabled;
                
            }
        }

        private void buttonKerko_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("studentsSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.Add("_searchValue", txtKerko.Text);
                DataTable dtblStudents = new DataTable();
                sqlDa.Fill(dtblStudents);
                dgvStudents.DataSource = dtblStudents;
                dgvStudents.Columns[0].Visible = false;
            }
        }

        private void buttonAnuloje_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonFshi_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("studentsDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_studentsID", studentsID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

    }
}
