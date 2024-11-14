using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMayBay
{
    public partial class Form1 : Form
    {
        private Connect dbHelper;

        public Form1()
        {
            InitializeComponent();

            dbHelper = new Connect();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT MaMB, TenMayBay, NamSX, SoGioBay " +
               "FROM MayBay " +
               "ORDER BY TenMayBay ASC";


            DataTable simTable = dbHelper.GetData(query);
            dataGridView1.DataSource = simTable;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                ID_field.Text = row.Cells["MaMB"].Value.ToString();
                Name_field.Text = row.Cells["TenMayBay"].Value.ToString();
                Born_field.Text = row.Cells["NamSX"].Value.ToString();
                Time_field.Text = row.Cells["SoGioBay"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            ThemMayBay add = new ThemMayBay();
            add.AddAircraft(ID_field.Text, Name_field.Text, int.Parse(Born_field.Text), int.Parse(Time_field.Text));
            MessageBox.Show("Thêm máy bay thành công!");
            LoadData(); 
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            SuaMayBay update = new SuaMayBay();
            update.UpdateAircraft(ID_field.Text, Name_field.Text, int.Parse(Born_field.Text), int.Parse(Time_field.Text));
            MessageBox.Show("Cập nhật thông tin máy bay thành công!");
            LoadData();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            XoaMayBay delete = new XoaMayBay();
            delete.DeleteAircraft(ID_field.Text);
            MessageBox.Show("Xóa máy bay thành công!");
            LoadData();
        }
    }
}
