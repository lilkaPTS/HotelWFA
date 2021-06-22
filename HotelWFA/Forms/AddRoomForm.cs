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
    public partial class AddRoomForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string editCode = "";
        private string cellValue = "";
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT roomNumber, storey, capacity, classification, price FROM Rooms", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewRoom.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cellValueBegin = dataGridViewRoom[e.ColumnIndex, e.RowIndex].Value.ToString();
            cellValue = cellValueBegin;
            dataGridViewRoom[e.ColumnIndex, e.RowIndex].Value = cellValueBegin.Remove(cellValueBegin.Length - 6, 5);
            if (dataGridViewRoom.Columns[e.ColumnIndex].Name == "price")
            {
                cellValueBegin = cellValueBegin.Remove(cellValueBegin.Length - 6, 5);
            }
            SqlCommand selectCommand = new SqlCommand($"SELECT roomCode, {dataGridViewRoom.Columns[e.ColumnIndex].Name} FROM Rooms WHERE {dataGridViewRoom.Columns[e.ColumnIndex].Name}=N'{cellValueBegin}'", sqlConnection);
            editCode = selectCommand.ExecuteScalar().ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cellValueEnd = dataGridViewRoom[e.ColumnIndex, e.RowIndex].Value.ToString();                
                SqlCommand updateCommand = new SqlCommand($"UPDATE Rooms SET {dataGridViewRoom.Columns[e.ColumnIndex].Name} = N'{cellValueEnd}' WHERE roomCode = N'{editCode}'", sqlConnection);
                updateCommand.ExecuteNonQuery();
                dataGridViewRoom[e.ColumnIndex, e.RowIndex].Value = $"{cellValueEnd},0000";
            }
            catch
            {
                dataGridViewRoom[e.ColumnIndex, e.RowIndex].Value = cellValue;
                MessageBox.Show("Что-то пошло не так");
            }
            /*
             * dataGridViewClients.Columns[e.ColumnIndex].Name - Получаем название колонки которую собираемся редактировать
             * dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString() - Получаем отредактированное значение ячейки           
             */
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if (str == "")
            {
                AddRoomForm_Load(sender, e);
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT roomNumber, storey, capacity, classification, price From Rooms WHERE classification=N'{str}'", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewRoom.DataSource = dataSet.Tables[0];
                textBoxSearch.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM Rooms WHERE roomNumber = N'{textBoxDelete.Text}'", sqlConnection);
            if (deleteCommand.ExecuteNonQuery().ToString() == "0")
            {
                MessageBox.Show("Номера такого класса нет в бд");
            }
            AddRoomForm_Load(sender, e);
            textBoxDelete.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand($"INSERT INTO Rooms (roomNumber, storey, capacity, classification, price) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', N'{textBox4.Text}', N'{textBox5.Text}')", sqlConnection);
                insertCommand.ExecuteNonQuery();
                AddRoomForm_Load(sender, e);
                MessageBox.Show("Номер успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
