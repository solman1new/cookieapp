
namespace CookieApp
{
    partial class homeformAdmin
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
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.checkOrderBtn = new System.Windows.Forms.Button();
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.searchOrderInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.idOrderLb = new System.Windows.Forms.Label();
            this.goodsLb = new System.Windows.Forms.Label();
            this.countLb = new System.Windows.Forms.Label();
            this.phoneClientLb = new System.Windows.Forms.Label();
            this.loginClientLb = new System.Windows.Forms.Label();
            this.IdViewLb = new System.Windows.Forms.Label();
            this.goodsViewLb = new System.Windows.Forms.Label();
            this.addressViewLb = new System.Windows.Forms.Label();
            this.phoneViewLb = new System.Windows.Forms.Label();
            this.loginViewLb = new System.Windows.Forms.Label();
            this.setDateLb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.countViewLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Image = global::CookieApp.media.remove_q;
            this.closeButton.Location = new System.Drawing.Point(889, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // checkOrderBtn
            // 
            this.checkOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.checkOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOrderBtn.ForeColor = System.Drawing.Color.White;
            this.checkOrderBtn.Location = new System.Drawing.Point(140, 12);
            this.checkOrderBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkOrderBtn.Name = "checkOrderBtn";
            this.checkOrderBtn.Size = new System.Drawing.Size(145, 31);
            this.checkOrderBtn.TabIndex = 31;
            this.checkOrderBtn.Text = "Проверка заказа";
            this.checkOrderBtn.UseVisualStyleBackColor = false;
            this.checkOrderBtn.Click += new System.EventHandler(this.checkOrderBtn_Click);
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.createOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderBtn.ForeColor = System.Drawing.Color.White;
            this.createOrderBtn.Location = new System.Drawing.Point(16, 12);
            this.createOrderBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(110, 31);
            this.createOrderBtn.TabIndex = 30;
            this.createOrderBtn.Text = "Создать заказ";
            this.createOrderBtn.UseVisualStyleBackColor = false;
            // 
            // searchOrderInput
            // 
            this.searchOrderInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchOrderInput.Location = new System.Drawing.Point(14, 97);
            this.searchOrderInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchOrderInput.Name = "searchOrderInput";
            this.searchOrderInput.Size = new System.Drawing.Size(436, 23);
            this.searchOrderInput.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Поиск по номеру/пользотелю";
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 16;
            this.listOrder.Location = new System.Drawing.Point(14, 133);
            this.listOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(436, 468);
            this.listOrder.TabIndex = 60;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // idOrderLb
            // 
            this.idOrderLb.AutoSize = true;
            this.idOrderLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrderLb.ForeColor = System.Drawing.Color.DarkRed;
            this.idOrderLb.Location = new System.Drawing.Point(471, 149);
            this.idOrderLb.Name = "idOrderLb";
            this.idOrderLb.Size = new System.Drawing.Size(20, 16);
            this.idOrderLb.TabIndex = 61;
            this.idOrderLb.Text = "ID";
            // 
            // goodsLb
            // 
            this.goodsLb.AutoSize = true;
            this.goodsLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodsLb.ForeColor = System.Drawing.Color.DarkRed;
            this.goodsLb.Location = new System.Drawing.Point(471, 188);
            this.goodsLb.Name = "goodsLb";
            this.goodsLb.Size = new System.Drawing.Size(57, 16);
            this.goodsLb.TabIndex = 62;
            this.goodsLb.Text = "Изделие";
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLb.ForeColor = System.Drawing.Color.DarkRed;
            this.countLb.Location = new System.Drawing.Point(471, 230);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(76, 16);
            this.countLb.TabIndex = 63;
            this.countLb.Text = "Количество";
            // 
            // phoneClientLb
            // 
            this.phoneClientLb.AutoSize = true;
            this.phoneClientLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneClientLb.ForeColor = System.Drawing.Color.DarkRed;
            this.phoneClientLb.Location = new System.Drawing.Point(471, 274);
            this.phoneClientLb.Name = "phoneClientLb";
            this.phoneClientLb.Size = new System.Drawing.Size(61, 16);
            this.phoneClientLb.TabIndex = 64;
            this.phoneClientLb.Text = "Телефон";
            // 
            // loginClientLb
            // 
            this.loginClientLb.AutoSize = true;
            this.loginClientLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginClientLb.ForeColor = System.Drawing.Color.DarkRed;
            this.loginClientLb.Location = new System.Drawing.Point(471, 321);
            this.loginClientLb.Name = "loginClientLb";
            this.loginClientLb.Size = new System.Drawing.Size(94, 16);
            this.loginClientLb.TabIndex = 65;
            this.loginClientLb.Text = "Логин клиента";
            // 
            // IdViewLb
            // 
            this.IdViewLb.AutoSize = true;
            this.IdViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdViewLb.ForeColor = System.Drawing.Color.Black;
            this.IdViewLb.Location = new System.Drawing.Point(497, 149);
            this.IdViewLb.Name = "IdViewLb";
            this.IdViewLb.Size = new System.Drawing.Size(20, 16);
            this.IdViewLb.TabIndex = 66;
            this.IdViewLb.Text = "ID";
            // 
            // goodsViewLb
            // 
            this.goodsViewLb.AutoSize = true;
            this.goodsViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodsViewLb.ForeColor = System.Drawing.Color.Black;
            this.goodsViewLb.Location = new System.Drawing.Point(534, 188);
            this.goodsViewLb.Name = "goodsViewLb";
            this.goodsViewLb.Size = new System.Drawing.Size(42, 16);
            this.goodsViewLb.TabIndex = 67;
            this.goodsViewLb.Text = "godos";
            // 
            // addressViewLb
            // 
            this.addressViewLb.AutoSize = true;
            this.addressViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressViewLb.ForeColor = System.Drawing.Color.Black;
            this.addressViewLb.Location = new System.Drawing.Point(523, 362);
            this.addressViewLb.Name = "addressViewLb";
            this.addressViewLb.Size = new System.Drawing.Size(53, 16);
            this.addressViewLb.TabIndex = 68;
            this.addressViewLb.Text = "address";
            // 
            // phoneViewLb
            // 
            this.phoneViewLb.AutoSize = true;
            this.phoneViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneViewLb.ForeColor = System.Drawing.Color.Black;
            this.phoneViewLb.Location = new System.Drawing.Point(538, 274);
            this.phoneViewLb.Name = "phoneViewLb";
            this.phoneViewLb.Size = new System.Drawing.Size(43, 16);
            this.phoneViewLb.TabIndex = 69;
            this.phoneViewLb.Text = "phone";
            // 
            // loginViewLb
            // 
            this.loginViewLb.AutoSize = true;
            this.loginViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginViewLb.ForeColor = System.Drawing.Color.Black;
            this.loginViewLb.Location = new System.Drawing.Point(571, 321);
            this.loginViewLb.Name = "loginViewLb";
            this.loginViewLb.Size = new System.Drawing.Size(35, 16);
            this.loginViewLb.TabIndex = 70;
            this.loginViewLb.Text = "login";
            // 
            // setDateLb
            // 
            this.setDateLb.AutoSize = true;
            this.setDateLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setDateLb.ForeColor = System.Drawing.Color.DarkRed;
            this.setDateLb.Location = new System.Drawing.Point(468, 426);
            this.setDateLb.Name = "setDateLb";
            this.setDateLb.Size = new System.Drawing.Size(94, 16);
            this.setDateLb.TabIndex = 71;
            this.setDateLb.Text = "Дата поставки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 421);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Maroon;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AcceptButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(474, 479);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(294, 31);
            this.AcceptButton.TabIndex = 73;
            this.AcceptButton.Text = "Проверка заказа";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // countViewLb
            // 
            this.countViewLb.AutoSize = true;
            this.countViewLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countViewLb.ForeColor = System.Drawing.Color.Black;
            this.countViewLb.Location = new System.Drawing.Point(553, 230);
            this.countViewLb.Name = "countViewLb";
            this.countViewLb.Size = new System.Drawing.Size(39, 16);
            this.countViewLb.TabIndex = 75;
            this.countViewLb.Text = "count";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLb.ForeColor = System.Drawing.Color.DarkRed;
            this.addressLb.Location = new System.Drawing.Point(471, 362);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(49, 16);
            this.addressLb.TabIndex = 74;
            this.addressLb.Text = "Адресс";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkRed;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(452, 97);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(140, 23);
            this.searchBtn.TabIndex = 76;
            this.searchBtn.Text = "Проверка заказа";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1049, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(967, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Адресс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1067, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1034, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1019, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1030, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "godos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(967, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "Логин клиента";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(967, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(967, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Количество";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(967, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Изделие";
            // 
            // homeformAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1622, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.countViewLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.setDateLb);
            this.Controls.Add(this.loginViewLb);
            this.Controls.Add(this.phoneViewLb);
            this.Controls.Add(this.addressViewLb);
            this.Controls.Add(this.goodsViewLb);
            this.Controls.Add(this.IdViewLb);
            this.Controls.Add(this.loginClientLb);
            this.Controls.Add(this.phoneClientLb);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.goodsLb);
            this.Controls.Add(this.idOrderLb);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchOrderInput);
            this.Controls.Add(this.checkOrderBtn);
            this.Controls.Add(this.createOrderBtn);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "homeformAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти";
            this.Load += new System.EventHandler(this.homeformAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button checkOrderBtn;
        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.TextBox searchOrderInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Label idOrderLb;
        private System.Windows.Forms.Label goodsLb;
        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.Label phoneClientLb;
        private System.Windows.Forms.Label loginClientLb;
        private System.Windows.Forms.Label IdViewLb;
        private System.Windows.Forms.Label goodsViewLb;
        private System.Windows.Forms.Label addressViewLb;
        private System.Windows.Forms.Label phoneViewLb;
        private System.Windows.Forms.Label loginViewLb;
        private System.Windows.Forms.Label setDateLb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label countViewLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}