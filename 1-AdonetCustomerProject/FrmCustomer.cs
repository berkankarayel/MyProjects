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

namespace _1_AdonetCustomerProject
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("Server=USER-PC\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True");

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName From TblCustomer\r\nInner Join TblCity On TblCity.CityId=TblCustomer.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("Select * from TblCity ", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCity.ValueMember = "CityId";
			cmbCity.DisplayMember =  "CityName";
			cmbCity.DataSource = dataTable;

			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Insert Into TblCustomer (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) values (@customerName,@customerSurname,@customerCity,@customerBalance,@customerStatus)", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);

			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);
			}
			else if (rdbPassive.Checked) // else if kullanımı daha mantıklı
			{
				command.Parameters.AddWithValue("@customerStatus", false); // "s" harfi düzeltildi
			}

			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı şekilde eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Delete  From TbLCustomer Where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerId",txtCustomerId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Update  TblCustomer Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus where  CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);
			}
			else if (rdbPassive.Checked) // else if kullanımı daha mantıklı
			{
				command.Parameters.AddWithValue("@customerStatus", false); // "s" harfi düzeltildi
			}

			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarılı şekilde güncellendi");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName From TblCustomer\r\nInner Join TblCity On TblCity.CityId=TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
			command.Parameters.AddWithValue("@customerName",txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}
	}
}
