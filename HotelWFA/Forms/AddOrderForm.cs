using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelWFA.Forms
{
    public partial class AddOrderForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string editCode = "";
        private string cellValue = "";
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT o.orderCode, c.fullName AS clientCode, e.fullName AS employeeCode, s.serviceName AS serviceCode, o.quantity FROM Orders o INNER JOIN Clients c ON o.clientCode = c.clientCode INNER JOIN Employees e ON o.employeeCode = e.employeeCode INNER JOIN Services s ON o.serviceCode = s.serviceCode", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewOrders.DataSource = dataSet.Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand selectCommandClient = new SqlCommand($"SELECT clientCode, fullName FROM Clients WHERE fullName=N'{textBox1.Text}'", sqlConnection);
                SqlCommand selectCommandEmployee = new SqlCommand($"SELECT employeeCode, fullName FROM Employees WHERE fullName=N'{textBox2.Text}'",sqlConnection);
                SqlCommand selectCommandService = new SqlCommand($"SELECT serviceCode, serviceName FROM Services WHERE serviceName=N'{textBox3.Text}'", sqlConnection);
                SqlCommand insertCommand = new SqlCommand($"INSERT INTO Orders (clientCode, employeeCode, serviceCode, quantity) VALUES (N'{selectCommandClient.ExecuteScalar().ToString()}', N'{selectCommandEmployee.ExecuteScalar().ToString()}', N'{selectCommandService.ExecuteScalar().ToString()}', N'{textBox4.Text}')", sqlConnection);
                insertCommand.ExecuteNonQuery();
                AddOrderForm_Load(sender, e);
                MessageBox.Show("Заказ успешно создан");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if (str == "")
            {
                AddOrderForm_Load(sender, e);
            }
            else
            {
                //SqlCommand selectCommandClient = new SqlCommand($"SELECT clientCode, fullName FROM Clients WHERE fullName=N'{str}'", sqlConnection);
                //str = selectCommandClient.ExecuteScalar().ToString();
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT o.orderCode, c.fullName AS clientCode, e.fullName AS employeeCode, s.serviceName AS serviceCode, o.quantity FROM Orders o INNER JOIN Clients c ON o.clientCode = c.clientCode INNER JOIN Employees e ON o.employeeCode = e.employeeCode INNER JOIN Services s ON o.serviceCode = s.serviceCode WHERE c.fullName=N'{str}'", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewOrders.DataSource = dataSet.Tables[0];
                textBoxSearch.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM Orders WHERE orderCode = N'{textBoxDelete.Text}'", sqlConnection);
            if (deleteCommand.ExecuteNonQuery().ToString() == "0")
            {
                MessageBox.Show("Такого заказа нет в бд");
            }
            AddOrderForm_Load(sender, e);
            textBoxDelete.Text = "";
        }

        private void dataGridViewOrders_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cellValueBegin = dataGridViewOrders[e.ColumnIndex, e.RowIndex].Value.ToString();
            cellValue = cellValueBegin;            
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "clientCode")
            {
                SqlCommand sqlCommandClients = new SqlCommand($"SELECT clientCode, fullName FROM Clients WHERE fullName=N'{cellValueBegin}'", sqlConnection);
                cellValueBegin = sqlCommandClients.ExecuteScalar().ToString();
            }
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "employeeCode")
            {
                SqlCommand sqlCommandEmployees = new SqlCommand($"SELECT employeeCode, fullName FROM Employees WHERE fullName=N'{cellValueBegin}'", sqlConnection);
                cellValueBegin = sqlCommandEmployees.ExecuteScalar().ToString();
            }
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "serviceCode")
            {
                SqlCommand sqlCommandServices = new SqlCommand($"SELECT serviceCode, serviceName FROM Services WHERE serviceName=N'{cellValueBegin}'", sqlConnection);
                cellValueBegin = sqlCommandServices.ExecuteScalar().ToString();
            }
            SqlCommand selectCommand = new SqlCommand($"SELECT orderCode, {dataGridViewOrders.Columns[e.ColumnIndex].Name} FROM Orders WHERE {dataGridViewOrders.Columns[e.ColumnIndex].Name}=N'{cellValueBegin}'", sqlConnection);
            editCode = selectCommand.ExecuteScalar().ToString();
        }

        private void dataGridViewOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValueEnd = dataGridViewOrders[e.ColumnIndex, e.RowIndex].Value.ToString();            
            try
            {
                if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "clientCode")
                {
                    SqlCommand sqlCommandClients = new SqlCommand($"SELECT clientCode, fullName FROM Clients WHERE fullName=N'{cellValueEnd}'", sqlConnection);
                    cellValueEnd = sqlCommandClients.ExecuteScalar().ToString();
                }
                if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "employeeCode")
                {
                    SqlCommand sqlCommandEmployees = new SqlCommand($"SELECT employeeCode, fullName FROM Employees WHERE fullName=N'{cellValueEnd}'", sqlConnection);
                    cellValueEnd = sqlCommandEmployees.ExecuteScalar().ToString();
                }
                if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "serviceCode")
                {
                    SqlCommand sqlCommandServices = new SqlCommand($"SELECT serviceCode, serviceName FROM Services WHERE serviceName=N'{cellValueEnd}'", sqlConnection);
                    cellValueEnd = sqlCommandServices.ExecuteScalar().ToString();
                }
                try
                {
                    SqlCommand updateCommand = new SqlCommand($"UPDATE Orders SET {dataGridViewOrders.Columns[e.ColumnIndex].Name} = N'{cellValueEnd}' WHERE orderCode = N'{editCode}'", sqlConnection);
                    updateCommand.ExecuteNonQuery();
                }
                catch
                {
                    dataGridViewOrders[e.ColumnIndex, e.RowIndex].Value = cellValue;
                    MessageBox.Show("Это поле нельзя изменять!");
                }
            }
            catch (NullReferenceException n)
            {
                dataGridViewOrders[e.ColumnIndex, e.RowIndex].Value = cellValue;
                MessageBox.Show(n.ToString());
            }
            /*
             * dataGridViewClients.Columns[e.ColumnIndex].Name - Получаем название колонки которую собираемся редактировать
             * dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString() - Получаем отредактированное значение ячейки           
             */
        }
    }
}
