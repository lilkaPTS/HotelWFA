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
    public partial class AddClientForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string editCode = "";
        private string cellValue = "";
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT r.roomNumber AS roomCode, c.fullName, c.passportProperties, c.phoneNumber, c.dateOfPlacement, c.dateOfEviction FROM Rooms r INNER JOIN Clients c ON r.roomCode = c.roomCode", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewClients.DataSource = dataSet.Tables[0];
            //if (sqlConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Подключение установлено");
            //}
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader = null;
            DateTime placement = new DateTime();
            DateTime eviction = new DateTime();
            bool check = false;
            try // проверяем правильность полей заселение/выселение
            {
                placement = DateTime.Parse(textBox_placement.Text);
                eviction = DateTime.Parse(TextBox_eviction.Text);
                check = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Проверьте правильность полей <<Дата заселения>> и <<Дата выселения>>");
            }
            //SqlCommand selectCommand = new SqlCommand($"SELECT roomCode, roomNumber FROM Rooms WHERE roomNumber={Int32.Parse(textBox_roomNumber.Text)}", sqlConnection);
            string roomCode = "";
            try //обработка dataReader (очень капризная вещь) 
            {
                SqlCommand selectCommand = new SqlCommand($"SELECT roomCode, roomNumber FROM Rooms WHERE roomNumber={Int32.Parse(textBox_roomNumber.Text)}", sqlConnection);
                dataReader = selectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    roomCode = Convert.ToString(dataReader["roomCode"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            try // проверка правильности поля Номер
            {
                if(check == true)
                {
                    SqlCommand insertCommand = new SqlCommand($"INSERT INTO Clients (roomCode, fullName, passportProperties, phoneNumber, dateOfPlacement, dateOfEviction) VALUES (N'{roomCode}', N'{textBox_fullName.Text}', N'{textBox_passportProperties.Text}', N'{textBox_phoneNumber.Text}', '{placement.Month}/{placement.Day}/{placement.Year}', '{eviction.Month}/{eviction.Day}/{eviction.Year}')", sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    AddClientForm_Load(sender, e);
                    MessageBox.Show("Клиент успешно добавлен");
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Проверьте правильность поля <<Номер>>");
            }  
            
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM Clients WHERE fullName = N'{textBoxDelete.Text}'", sqlConnection);
            if(deleteCommand.ExecuteNonQuery().ToString() == "0")
            {
                MessageBox.Show("Такого клиента нет в бд");
            }
            AddClientForm_Load(sender, e);
            textBoxDelete.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if(str == "")
            {
                AddClientForm_Load(sender, e);
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT r.roomNumber AS roomCode, c.fullName, c.passportProperties, c.phoneNumber, c.dateOfPlacement, c.dateOfEviction FROM Rooms r INNER JOIN Clients c ON r.roomCode = c.roomCode WHERE phoneNumber=N'{str}'", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewClients.DataSource = dataSet.Tables[0];
                textBoxSearch.Text = "";
            }
        }

        private void dataGridViewClients_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) //Тут получаем клиентКод клиента которого мы редактируем
        {
            string cellValueBegin = dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString();
            cellValue = cellValueBegin;
            DateTime anyDate = new DateTime();
            if (dataGridViewClients.Columns[e.ColumnIndex].Name == "dateOfPlacement" || dataGridViewClients.Columns[e.ColumnIndex].Name == "dateOfEviction")
            {
                try // проверяем правильность полей заселение/выселение
                {
                    anyDate = DateTime.Parse(cellValueBegin);
                    cellValueBegin = $"{anyDate.Month}/{anyDate.Day}/{anyDate.Year}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (dataGridViewClients.Columns[e.ColumnIndex].Name == "roomCode")
            {
                SqlCommand sqlCommandRoom = new SqlCommand($"SELECT roomCode, roomNumber FROM Rooms WHERE roomNumber=N'{cellValueBegin}'", sqlConnection);
                cellValueBegin = sqlCommandRoom.ExecuteScalar().ToString();
            }
            SqlCommand selectCommand = new SqlCommand($"SELECT clientCode, {dataGridViewClients.Columns[e.ColumnIndex].Name} FROM Clients WHERE {dataGridViewClients.Columns[e.ColumnIndex].Name}=N'{cellValueBegin}'", sqlConnection);
            editCode = selectCommand.ExecuteScalar().ToString();
        }

        private void dataGridViewClients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValueEnd = dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString();
            DateTime anyDate = new DateTime();
            try
            {
                if (dataGridViewClients.Columns[e.ColumnIndex].Name == "roomCode")
                {
                    SqlCommand sqlCommandRoom = new SqlCommand($"SELECT roomCode, roomNumber FROM Rooms WHERE roomNumber=N'{cellValueEnd}'", sqlConnection);                    
                    cellValueEnd = sqlCommandRoom.ExecuteScalar().ToString();                    
                }
                if (dataGridViewClients.Columns[e.ColumnIndex].Name == "dateOfPlacement" || dataGridViewClients.Columns[e.ColumnIndex].Name == "dateOfEviction")
                {
                    try // проверяем правильность полей заселение/выселение
                    {
                        anyDate = DateTime.Parse(cellValueEnd);
                        cellValueEnd = $"{anyDate.Month}/{anyDate.Day}/{anyDate.Year}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                try
                {
                    SqlCommand updateCommand = new SqlCommand($"UPDATE Clients SET {dataGridViewClients.Columns[e.ColumnIndex].Name} = N'{cellValueEnd}' WHERE clientCode = N'{editCode}'", sqlConnection);
                    updateCommand.ExecuteNonQuery();
                }
                catch
                {
                    dataGridViewClients[e.ColumnIndex, e.RowIndex].Value = cellValue;
                    MessageBox.Show("Год введён неверно");
                }
            }
            catch (NullReferenceException n)
            {
                dataGridViewClients[e.ColumnIndex, e.RowIndex].Value = cellValue;
                MessageBox.Show("Введено неправильное значение номера комнаты!");
            }
            /*
             * dataGridViewClients.Columns[e.ColumnIndex].Name - Получаем название колонки которую собираемся редактировать
             * dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString() - Получаем отредактированное значение ячейки           
             */
        }
    }
}
