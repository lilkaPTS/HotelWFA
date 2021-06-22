
namespace HotelWFA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClient = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.addRoom = new System.Windows.Forms.Button();
            this.addService = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 12);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(100, 158);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Клиенты";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(118, 12);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(100, 158);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Сотрудники";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // addRoom
            // 
            this.addRoom.Location = new System.Drawing.Point(224, 12);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(100, 158);
            this.addRoom.TabIndex = 2;
            this.addRoom.Text = "Номера";
            this.addRoom.UseVisualStyleBackColor = true;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(330, 12);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(100, 158);
            this.addService.TabIndex = 3;
            this.addService.Text = "Услуги";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(436, 12);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(100, 158);
            this.addOrder.TabIndex = 4;
            this.addOrder.Text = "Заказы";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 480);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.addClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Гостиница";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.Button addOrder;
    }
}

