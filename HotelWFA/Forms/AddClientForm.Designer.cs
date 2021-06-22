
namespace HotelWFA.Forms
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addClient = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_eviction = new System.Windows.Forms.TextBox();
            this.textBox_placement = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_passportProperties = new System.Windows.Forms.TextBox();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox_roomNumber = new System.Windows.Forms.TextBox();
            this.deleteClient = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.addClient.SuspendLayout();
            this.deleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addClient);
            this.tabControl1.Controls.Add(this.deleteClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.SystemColors.Control;
            this.addClient.Controls.Add(this.label6);
            this.addClient.Controls.Add(this.label5);
            this.addClient.Controls.Add(this.label4);
            this.addClient.Controls.Add(this.label3);
            this.addClient.Controls.Add(this.label2);
            this.addClient.Controls.Add(this.label1);
            this.addClient.Controls.Add(this.TextBox_eviction);
            this.addClient.Controls.Add(this.textBox_placement);
            this.addClient.Controls.Add(this.textBox_phoneNumber);
            this.addClient.Controls.Add(this.textBox_passportProperties);
            this.addClient.Controls.Add(this.textBox_fullName);
            this.addClient.Controls.Add(this.addButton);
            this.addClient.Controls.Add(this.textBox_roomNumber);
            this.addClient.Location = new System.Drawing.Point(4, 24);
            this.addClient.Name = "addClient";
            this.addClient.Padding = new System.Windows.Forms.Padding(3);
            this.addClient.Size = new System.Drawing.Size(792, 422);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Добавить клиента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата выселения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата заселения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Серия номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер";
            // 
            // TextBox_eviction
            // 
            this.TextBox_eviction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_eviction.Location = new System.Drawing.Point(266, 278);
            this.TextBox_eviction.Multiline = true;
            this.TextBox_eviction.Name = "TextBox_eviction";
            this.TextBox_eviction.Size = new System.Drawing.Size(504, 30);
            this.TextBox_eviction.TabIndex = 11;
            // 
            // textBox_placement
            // 
            this.textBox_placement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_placement.Location = new System.Drawing.Point(266, 227);
            this.textBox_placement.Multiline = true;
            this.textBox_placement.Name = "textBox_placement";
            this.textBox_placement.Size = new System.Drawing.Size(504, 30);
            this.textBox_placement.TabIndex = 10;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_phoneNumber.Location = new System.Drawing.Point(266, 176);
            this.textBox_phoneNumber.Multiline = true;
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(504, 30);
            this.textBox_phoneNumber.TabIndex = 9;
            // 
            // textBox_passportProperties
            // 
            this.textBox_passportProperties.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_passportProperties.Location = new System.Drawing.Point(266, 125);
            this.textBox_passportProperties.Multiline = true;
            this.textBox_passportProperties.Name = "textBox_passportProperties";
            this.textBox_passportProperties.Size = new System.Drawing.Size(504, 30);
            this.textBox_passportProperties.TabIndex = 8;
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_fullName.Location = new System.Drawing.Point(266, 74);
            this.textBox_fullName.Multiline = true;
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(504, 30);
            this.textBox_fullName.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(266, 328);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 45);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox_roomNumber
            // 
            this.textBox_roomNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_roomNumber.Location = new System.Drawing.Point(266, 23);
            this.textBox_roomNumber.Multiline = true;
            this.textBox_roomNumber.Name = "textBox_roomNumber";
            this.textBox_roomNumber.Size = new System.Drawing.Size(504, 30);
            this.textBox_roomNumber.TabIndex = 0;
            // 
            // deleteClient
            // 
            this.deleteClient.BackColor = System.Drawing.SystemColors.Control;
            this.deleteClient.Controls.Add(this.buttonSearch);
            this.deleteClient.Controls.Add(this.label8);
            this.deleteClient.Controls.Add(this.textBoxSearch);
            this.deleteClient.Controls.Add(this.label7);
            this.deleteClient.Controls.Add(this.buttonDelete);
            this.deleteClient.Controls.Add(this.textBoxDelete);
            this.deleteClient.Controls.Add(this.dataGridViewClients);
            this.deleteClient.Location = new System.Drawing.Point(4, 24);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.deleteClient.Size = new System.Drawing.Size(792, 422);
            this.deleteClient.TabIndex = 1;
            this.deleteClient.Text = "Таблица \"Клиенты\"";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(632, 382);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(157, 33);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Номер телефона:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(177, 383);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(449, 33);
            this.textBoxSearch.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "ФИО:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(632, 344);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 33);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDelete.Location = new System.Drawing.Point(76, 344);
            this.textBoxDelete.Multiline = true;
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(550, 33);
            this.textBoxDelete.TabIndex = 1;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewClients.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowTemplate.Height = 25;
            this.dataGridViewClients.Size = new System.Drawing.Size(786, 335);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewClients_CellBeginEdit);
            this.dataGridViewClients.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellEndEdit);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.addClient.ResumeLayout(false);
            this.addClient.PerformLayout();
            this.deleteClient.ResumeLayout(false);
            this.deleteClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addClient;
        private System.Windows.Forms.TabPage deleteClient;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox_roomNumber;
        private System.Windows.Forms.TextBox TextBox_eviction;
        private System.Windows.Forms.TextBox textBox_placement;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_passportProperties;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}