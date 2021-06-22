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
    public partial class AddEmployeeForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string editCode = "";
        private string cellValue = "";
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jajak\source\repos\HotelWFA\HotelWFA\Db\Database.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT fullName, dOB, hiringDate, passportProperties, homeAddress, phoneNumber, position From Employees", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewEmployee.DataSource = dataSet.Tables[0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if (str == "")
            {
                AddEmployeeForm_Load(sender, e);
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT fullName, dOB, hiringDate, passportProperties, homeAddress, phoneNumber, position From Employees WHERE fullName=N'{str}'", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewEmployee.DataSource = dataSet.Tables[0];
                textBoxSearch.Text = "";
            }
        }

        private void dataGridViewEmployee_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cellValueBegin = dataGridViewEmployee[e.ColumnIndex, e.RowIndex].Value.ToString();
            cellValue = cellValueBegin;
            DateTime anyDate = new DateTime();
            if (dataGridViewEmployee.Columns[e.ColumnIndex].Name == "dOB" || dataGridViewEmployee.Columns[e.ColumnIndex].Name == "hiringDate")
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
            SqlCommand selectCommand = new SqlCommand($"SELECT employeeCode, {dataGridViewEmployee.Columns[e.ColumnIndex].Name} FROM Employees WHERE {dataGridViewEmployee.Columns[e.ColumnIndex].Name}=N'{cellValueBegin}'", sqlConnection);
            editCode = selectCommand.ExecuteScalar().ToString();
        }

        private void dataGridViewEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cellValueEnd = dataGridViewEmployee[e.ColumnIndex, e.RowIndex].Value.ToString();
                DateTime anyDate = new DateTime();
                if (dataGridViewEmployee.Columns[e.ColumnIndex].Name == "hiringDate" || dataGridViewEmployee.Columns[e.ColumnIndex].Name == "hiringDate")
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
                SqlCommand updateCommand = new SqlCommand($"UPDATE Employees SET {dataGridViewEmployee.Columns[e.ColumnIndex].Name} = N'{cellValueEnd}' WHERE employeeCode = N'{editCode}'", sqlConnection);
                updateCommand.ExecuteNonQuery();
            }
            catch
            {
                dataGridViewEmployee[e.ColumnIndex, e.RowIndex].Value = cellValue;
                MessageBox.Show("Год введён неверно");
            }
            /*
             * dataGridViewClients.Columns[e.ColumnIndex].Name - Получаем название колонки которую собираемся редактировать
             * dataGridViewClients[e.ColumnIndex, e.RowIndex].Value.ToString() - Получаем отредактированное значение ячейки           
             */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand($"DELETE FROM Employees WHERE fullName = N'{textBoxDelete.Text}'", sqlConnection);
            if (deleteCommand.ExecuteNonQuery().ToString() == "0")
            {
                MessageBox.Show("Такого сотрудника нет в бд");
            }
            AddEmployeeForm_Load(sender, e);
            textBoxDelete.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dOB = new DateTime();
            DateTime hiringDate = new DateTime();
            try // проверяем правильность полей заселение/выселение
            {
                dOB = DateTime.Parse(textBox2.Text);
                hiringDate = DateTime.Parse(textBox3.Text);
                SqlCommand insertCommand = new SqlCommand($"INSERT INTO Employees (fullName, dOB, hiringDate, passportProperties, homeAddress, phoneNumber, position) VALUES (N'{textBox1.Text}', N'{dOB.Month}/{dOB.Day}/{dOB.Year}', N'{hiringDate.Month}/{hiringDate.Day}/{hiringDate.Year}', N'{textBox4.Text}', N'{textBox5.Text}', N'{textBox6.Text}', N'{textBox7.Text}')", sqlConnection);
                insertCommand.ExecuteNonQuery();
                AddEmployeeForm_Load(sender, e);
                MessageBox.Show("Сотрудник успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Проверьте правильность полей <<Дата рождения>> и <<Дата найма>>");
            }
        }
    }
}
