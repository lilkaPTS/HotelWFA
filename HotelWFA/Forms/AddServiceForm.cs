using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelWFA.Forms
{
    public partial class AddServiceForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string editCode = "";
        private string cellValue = "";
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT serviceName, category, price FROM Services", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewService.DataSource = dataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand($"INSERT INTO Services (serviceName, category, price) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}')", sqlConnection);
                insertCommand.ExecuteNonQuery();
                AddServiceForm_Load(sender, e);
                MessageBox.Show("Услуга успешно создана");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM Services WHERE serviceName = N'{textBoxDelete.Text}'", sqlConnection);
            if (deleteCommand.ExecuteNonQuery().ToString() == "0")
            {
                MessageBox.Show("Такой услуги нет в бд");
            }
            AddServiceForm_Load(sender, e);
            textBoxDelete.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if (str == "")
            {
                AddServiceForm_Load(sender, e);
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT serviceName, category, price From Services WHERE (price<N'{str}') OR (price=N'{str}')", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewService.DataSource = dataSet.Tables[0];
                textBoxSearch.Text = "";
            }
        }

        private void dataGridViewService_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cellValueBegin = dataGridViewService[e.ColumnIndex, e.RowIndex].Value.ToString();
            cellValue = cellValueBegin;
            dataGridViewService[e.ColumnIndex, e.RowIndex].Value = cellValueBegin.Remove(cellValueBegin.Length - 6, 5);
            if (dataGridViewService.Columns[e.ColumnIndex].Name == "price")
            {
                cellValueBegin = cellValueBegin.Remove(cellValueBegin.Length - 6, 5);
            }
            SqlCommand selectCommand = new SqlCommand($"SELECT serviceCode, {dataGridViewService.Columns[e.ColumnIndex].Name} FROM Services WHERE {dataGridViewService.Columns[e.ColumnIndex].Name}=N'{cellValueBegin}'", sqlConnection);
            editCode = selectCommand.ExecuteScalar().ToString();
        }

        private void dataGridViewService_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cellValueEnd = dataGridViewService[e.ColumnIndex, e.RowIndex].Value.ToString();
                SqlCommand updateCommand = new SqlCommand($"UPDATE Services SET {dataGridViewService.Columns[e.ColumnIndex].Name} = N'{cellValueEnd}' WHERE serviceCode = N'{editCode}'", sqlConnection);
                updateCommand.ExecuteNonQuery();
                dataGridViewService[e.ColumnIndex, e.RowIndex].Value = $"{cellValueEnd},0000";
            }
            catch
            {
                dataGridViewService[e.ColumnIndex, e.RowIndex].Value = cellValue;
                MessageBox.Show("Что-то пошло не так");
            }
            /*
             * dataGridViewClients.Columns[e.ColumnIndex].Name - Получаем название колонки которую собираемся редактировать
             * dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString() - Получаем отредактированное значение ячейки           
             */
        }
    }
}
