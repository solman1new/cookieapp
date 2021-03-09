
namespace CookieApp
{
    partial class homeform
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
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.checkOrderBtn = new System.Windows.Forms.Button();
            this.GoodsLabel = new System.Windows.Forms.Label();
            this.CountGoodsLabel = new System.Windows.Forms.Label();
            this.AdressTrLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.addressTr = new System.Windows.Forms.TextBox();
            this.countGoods = new System.Windows.Forms.TextBox();
            this.choiseGoods = new System.Windows.Forms.ComboBox();
            this.goOrderBtn = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.idOrderCheckLabel = new System.Windows.Forms.Label();
            this.GoodsLable = new System.Windows.Forms.Label();
            this.CountGoodsCheckLabel = new System.Windows.Forms.Label();
            this.AddressOrderCheckLabel = new System.Windows.Forms.Label();
            this.PhoneOrderCheckLabel = new System.Windows.Forms.Label();
            this.idOrderLabel = new System.Windows.Forms.Label();
            this.orderGoodsLabel = new System.Windows.Forms.Label();
            this.OrderCountLabel = new System.Windows.Forms.Label();
            this.OrderAdressLabel = new System.Windows.Forms.Label();
            this.OrderPhoneLabel = new System.Windows.Forms.Label();
            this.OrderStatusCheckLabel = new System.Windows.Forms.Label();
            this.OrderDateCheckLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.AgreeOrderBtn = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.createOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderBtn.ForeColor = System.Drawing.Color.White;
            this.createOrderBtn.Location = new System.Drawing.Point(12, 12);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(94, 25);
            this.createOrderBtn.TabIndex = 1;
            this.createOrderBtn.Text = "Создать заказ";
            this.createOrderBtn.UseVisualStyleBackColor = false;
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // checkOrderBtn
            // 
            this.checkOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.checkOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOrderBtn.ForeColor = System.Drawing.Color.White;
            this.checkOrderBtn.Location = new System.Drawing.Point(118, 12);
            this.checkOrderBtn.Name = "checkOrderBtn";
            this.checkOrderBtn.Size = new System.Drawing.Size(124, 25);
            this.checkOrderBtn.TabIndex = 2;
            this.checkOrderBtn.Text = "Проверка заказа";
            this.checkOrderBtn.UseVisualStyleBackColor = false;
            this.checkOrderBtn.Click += new System.EventHandler(this.checkOrderBtn_Click);
            // 
            // GoodsLabel
            // 
            this.GoodsLabel.AutoSize = true;
            this.GoodsLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodsLabel.Location = new System.Drawing.Point(257, 207);
            this.GoodsLabel.Name = "GoodsLabel";
            this.GoodsLabel.Size = new System.Drawing.Size(57, 16);
            this.GoodsLabel.TabIndex = 3;
            this.GoodsLabel.Text = "Изделие";
            // 
            // CountGoodsLabel
            // 
            this.CountGoodsLabel.AutoSize = true;
            this.CountGoodsLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGoodsLabel.Location = new System.Drawing.Point(238, 242);
            this.CountGoodsLabel.Name = "CountGoodsLabel";
            this.CountGoodsLabel.Size = new System.Drawing.Size(76, 16);
            this.CountGoodsLabel.TabIndex = 4;
            this.CountGoodsLabel.Text = "Количество";
            // 
            // AdressTrLabel
            // 
            this.AdressTrLabel.AutoSize = true;
            this.AdressTrLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressTrLabel.Location = new System.Drawing.Point(214, 270);
            this.AdressTrLabel.Name = "AdressTrLabel";
            this.AdressTrLabel.Size = new System.Drawing.Size(100, 16);
            this.AdressTrLabel.TabIndex = 5;
            this.AdressTrLabel.Text = "Адрес доставки";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(253, 302);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(61, 16);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(320, 302);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(223, 23);
            this.phone.TabIndex = 7;
            // 
            // addressTr
            // 
            this.addressTr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTr.Location = new System.Drawing.Point(320, 270);
            this.addressTr.Name = "addressTr";
            this.addressTr.Size = new System.Drawing.Size(223, 23);
            this.addressTr.TabIndex = 8;
            // 
            // countGoods
            // 
            this.countGoods.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countGoods.Location = new System.Drawing.Point(320, 241);
            this.countGoods.Name = "countGoods";
            this.countGoods.Size = new System.Drawing.Size(39, 23);
            this.countGoods.TabIndex = 9;
            // 
            // choiseGoods
            // 
            this.choiseGoods.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseGoods.FormattingEnabled = true;
            this.choiseGoods.Location = new System.Drawing.Point(320, 206);
            this.choiseGoods.Name = "choiseGoods";
            this.choiseGoods.Size = new System.Drawing.Size(223, 24);
            this.choiseGoods.TabIndex = 10;
            this.choiseGoods.SelectedIndexChanged += new System.EventHandler(this.choiseGoods_SelectedIndexChanged);
            // 
            // goOrderBtn
            // 
            this.goOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.goOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goOrderBtn.ForeColor = System.Drawing.Color.White;
            this.goOrderBtn.Location = new System.Drawing.Point(320, 343);
            this.goOrderBtn.Name = "goOrderBtn";
            this.goOrderBtn.Size = new System.Drawing.Size(223, 37);
            this.goOrderBtn.TabIndex = 11;
            this.goOrderBtn.Text = "Оформить заказ";
            this.goOrderBtn.UseVisualStyleBackColor = false;
            this.goOrderBtn.Click += new System.EventHandler(this.goOrderBtn_Click);
            // 
            // listOrder
            // 
            this.listOrder.BackColor = System.Drawing.Color.Gray;
            this.listOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOrder.ForeColor = System.Drawing.Color.White;
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 18;
            this.listOrder.Location = new System.Drawing.Point(12, 68);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(230, 560);
            this.listOrder.TabIndex = 12;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.choiseGoods_SelectedIndexChanged);
            // 
            // idOrderCheckLabel
            // 
            this.idOrderCheckLabel.AutoSize = true;
            this.idOrderCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrderCheckLabel.Location = new System.Drawing.Point(258, 103);
            this.idOrderCheckLabel.Name = "idOrderCheckLabel";
            this.idOrderCheckLabel.Size = new System.Drawing.Size(22, 19);
            this.idOrderCheckLabel.TabIndex = 14;
            this.idOrderCheckLabel.Text = "#";
            // 
            // GoodsLable
            // 
            this.GoodsLable.AutoSize = true;
            this.GoodsLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodsLable.Location = new System.Drawing.Point(258, 162);
            this.GoodsLable.Name = "GoodsLable";
            this.GoodsLable.Size = new System.Drawing.Size(80, 19);
            this.GoodsLable.TabIndex = 15;
            this.GoodsLable.Text = "Изделие";
            // 
            // CountGoodsCheckLabel
            // 
            this.CountGoodsCheckLabel.AutoSize = true;
            this.CountGoodsCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGoodsCheckLabel.Location = new System.Drawing.Point(259, 223);
            this.CountGoodsCheckLabel.Name = "CountGoodsCheckLabel";
            this.CountGoodsCheckLabel.Size = new System.Drawing.Size(112, 19);
            this.CountGoodsCheckLabel.TabIndex = 16;
            this.CountGoodsCheckLabel.Text = "Количество ";
            // 
            // AddressOrderCheckLabel
            // 
            this.AddressOrderCheckLabel.AutoSize = true;
            this.AddressOrderCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressOrderCheckLabel.Location = new System.Drawing.Point(259, 296);
            this.AddressOrderCheckLabel.Name = "AddressOrderCheckLabel";
            this.AddressOrderCheckLabel.Size = new System.Drawing.Size(143, 19);
            this.AddressOrderCheckLabel.TabIndex = 17;
            this.AddressOrderCheckLabel.Text = "Адрес доставки";
            // 
            // PhoneOrderCheckLabel
            // 
            this.PhoneOrderCheckLabel.AutoSize = true;
            this.PhoneOrderCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneOrderCheckLabel.Location = new System.Drawing.Point(259, 367);
            this.PhoneOrderCheckLabel.Name = "PhoneOrderCheckLabel";
            this.PhoneOrderCheckLabel.Size = new System.Drawing.Size(188, 19);
            this.PhoneOrderCheckLabel.TabIndex = 18;
            this.PhoneOrderCheckLabel.Text = "Контактный телефон";
            // 
            // idOrderLabel
            // 
            this.idOrderLabel.AutoSize = true;
            this.idOrderLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idOrderLabel.ForeColor = System.Drawing.Color.Maroon;
            this.idOrderLabel.Location = new System.Drawing.Point(298, 103);
            this.idOrderLabel.Name = "idOrderLabel";
            this.idOrderLabel.Size = new System.Drawing.Size(55, 19);
            this.idOrderLabel.TabIndex = 19;
            this.idOrderLabel.Text = "idlabel";
            // 
            // orderGoodsLabel
            // 
            this.orderGoodsLabel.AutoSize = true;
            this.orderGoodsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderGoodsLabel.ForeColor = System.Drawing.Color.Maroon;
            this.orderGoodsLabel.Location = new System.Drawing.Point(344, 162);
            this.orderGoodsLabel.Name = "orderGoodsLabel";
            this.orderGoodsLabel.Size = new System.Drawing.Size(52, 19);
            this.orderGoodsLabel.TabIndex = 20;
            this.orderGoodsLabel.Text = "goods";
            // 
            // OrderCountLabel
            // 
            this.OrderCountLabel.AutoSize = true;
            this.OrderCountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCountLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderCountLabel.Location = new System.Drawing.Point(371, 223);
            this.OrderCountLabel.Name = "OrderCountLabel";
            this.OrderCountLabel.Size = new System.Drawing.Size(129, 19);
            this.OrderCountLabel.TabIndex = 21;
            this.OrderCountLabel.Text = "OrderCountLabel";
            // 
            // OrderAdressLabel
            // 
            this.OrderAdressLabel.AutoSize = true;
            this.OrderAdressLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderAdressLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderAdressLabel.Location = new System.Drawing.Point(408, 296);
            this.OrderAdressLabel.Name = "OrderAdressLabel";
            this.OrderAdressLabel.Size = new System.Drawing.Size(135, 19);
            this.OrderAdressLabel.TabIndex = 22;
            this.OrderAdressLabel.Text = "OrderAdressLabel";
            // 
            // OrderPhoneLabel
            // 
            this.OrderPhoneLabel.AutoSize = true;
            this.OrderPhoneLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPhoneLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderPhoneLabel.Location = new System.Drawing.Point(447, 367);
            this.OrderPhoneLabel.Name = "OrderPhoneLabel";
            this.OrderPhoneLabel.Size = new System.Drawing.Size(131, 19);
            this.OrderPhoneLabel.TabIndex = 23;
            this.OrderPhoneLabel.Text = "OrderPhoneLabel";
            // 
            // OrderStatusCheckLabel
            // 
            this.OrderStatusCheckLabel.AutoSize = true;
            this.OrderStatusCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.OrderStatusCheckLabel.Location = new System.Drawing.Point(258, 503);
            this.OrderStatusCheckLabel.Name = "OrderStatusCheckLabel";
            this.OrderStatusCheckLabel.Size = new System.Drawing.Size(65, 19);
            this.OrderStatusCheckLabel.TabIndex = 24;
            this.OrderStatusCheckLabel.Text = "Статус";
            // 
            // OrderDateCheckLabel
            // 
            this.OrderDateCheckLabel.AutoSize = true;
            this.OrderDateCheckLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.OrderDateCheckLabel.Location = new System.Drawing.Point(259, 445);
            this.OrderDateCheckLabel.Name = "OrderDateCheckLabel";
            this.OrderDateCheckLabel.Size = new System.Drawing.Size(132, 19);
            this.OrderDateCheckLabel.TabIndex = 25;
            this.OrderDateCheckLabel.Text = "Дата поставки";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderDateLabel.Location = new System.Drawing.Point(435, 445);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(82, 19);
            this.OrderDateLabel.TabIndex = 26;
            this.OrderDateLabel.Text = "DateOrder";
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderStatusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.OrderStatusLabel.Location = new System.Drawing.Point(329, 503);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(52, 19);
            this.OrderStatusLabel.TabIndex = 27;
            this.OrderStatusLabel.Text = "Status";
            // 
            // AgreeOrderBtn
            // 
            this.AgreeOrderBtn.BackColor = System.Drawing.Color.Maroon;
            this.AgreeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgreeOrderBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgreeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.AgreeOrderBtn.Location = new System.Drawing.Point(256, 570);
            this.AgreeOrderBtn.Name = "AgreeOrderBtn";
            this.AgreeOrderBtn.Size = new System.Drawing.Size(223, 37);
            this.AgreeOrderBtn.TabIndex = 29;
            this.AgreeOrderBtn.Text = "Подтвердить получение";
            this.AgreeOrderBtn.UseVisualStyleBackColor = false;
            this.AgreeOrderBtn.Click += new System.EventHandler(this.AgreeOrderBtn_Click);
            // 
            // closeApp
            // 
            this.closeApp.Image = global::CookieApp.media.remove_q;
            this.closeApp.InitialImage = global::CookieApp.media.remove_q;
            this.closeApp.Location = new System.Drawing.Point(764, 12);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(24, 25);
            this.closeApp.TabIndex = 0;
            this.closeApp.TabStop = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.AgreeOrderBtn);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.OrderDateCheckLabel);
            this.Controls.Add(this.OrderStatusCheckLabel);
            this.Controls.Add(this.OrderPhoneLabel);
            this.Controls.Add(this.OrderAdressLabel);
            this.Controls.Add(this.OrderCountLabel);
            this.Controls.Add(this.orderGoodsLabel);
            this.Controls.Add(this.idOrderLabel);
            this.Controls.Add(this.PhoneOrderCheckLabel);
            this.Controls.Add(this.AddressOrderCheckLabel);
            this.Controls.Add(this.CountGoodsCheckLabel);
            this.Controls.Add(this.GoodsLable);
            this.Controls.Add(this.idOrderCheckLabel);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.goOrderBtn);
            this.Controls.Add(this.choiseGoods);
            this.Controls.Add(this.countGoods);
            this.Controls.Add(this.addressTr);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AdressTrLabel);
            this.Controls.Add(this.CountGoodsLabel);
            this.Controls.Add(this.GoodsLabel);
            this.Controls.Add(this.checkOrderBtn);
            this.Controls.Add(this.createOrderBtn);
            this.Controls.Add(this.closeApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.homeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeApp;
        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.Button checkOrderBtn;
        private System.Windows.Forms.Label GoodsLabel;
        private System.Windows.Forms.Label CountGoodsLabel;
        private System.Windows.Forms.Label AdressTrLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox addressTr;
        private System.Windows.Forms.TextBox countGoods;
        private System.Windows.Forms.ComboBox choiseGoods;
        private System.Windows.Forms.Button goOrderBtn;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Label idOrderCheckLabel;
        private System.Windows.Forms.Label GoodsLable;
        private System.Windows.Forms.Label CountGoodsCheckLabel;
        private System.Windows.Forms.Label AddressOrderCheckLabel;
        private System.Windows.Forms.Label PhoneOrderCheckLabel;
        private System.Windows.Forms.Label idOrderLabel;
        private System.Windows.Forms.Label orderGoodsLabel;
        private System.Windows.Forms.Label OrderCountLabel;
        private System.Windows.Forms.Label OrderAdressLabel;
        private System.Windows.Forms.Label OrderPhoneLabel;
        private System.Windows.Forms.Label OrderStatusCheckLabel;
        private System.Windows.Forms.Label OrderDateCheckLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.Button AgreeOrderBtn;
    }
}