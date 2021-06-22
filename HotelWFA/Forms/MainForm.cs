using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelWFA
{
    public partial class MainForm : Form
    {

        private SqlConnection sqlConnection = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True

            sqlConnection.Open();

            //if (sqlConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Подключение установлено");
            //}
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            HotelWFA.Forms.AddClientForm addClientForm = new HotelWFA.Forms.AddClientForm();
            addClientForm.Show();            
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            HotelWFA.Forms.AddEmployeeForm addEmployeeForm = new HotelWFA.Forms.AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            HotelWFA.Forms.AddRoomForm addRoomForm = new HotelWFA.Forms.AddRoomForm();
            addRoomForm.Show();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            HotelWFA.Forms.AddServiceForm addServiceForm = new HotelWFA.Forms.AddServiceForm();
            addServiceForm.Show();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            HotelWFA.Forms.AddOrderForm addOrderForm = new HotelWFA.Forms.AddOrderForm();
            addOrderForm.Show();
        }
    }
}
