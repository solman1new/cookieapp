using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CookieApp
{
    public partial class homeform : Form
    {

        private DBUtils db;
        private Form parent;
        private string userLogin;

        public homeform()
        {
            InitializeComponent();
        }

        public homeform(DBUtils db, string userLogin, Form parent)
        {
            InitializeComponent();

            this.db = db;
            this.userLogin = userLogin;
            this.parent = parent;

            ToHiddenListOrder();
            ToHiddenMakeOrder();

        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.parent.Close();
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            ToHiddenListOrder();
            ToVisibleMakeOrder();
            GetAndFillDataForOrder();
        }

        private void ToInsertNewOrder()
        {
            if(!CheckOnFillOrder())
            {
                MessageBox.Show("Нужно заполнить все поля");
                return;
            }

            var goods = this.choiseGoods.Text;
            var countGoods = Convert.ToInt32(this.countGoods.Text.Trim());
            var addressClient = this.addressTr.Text.Trim();
            var phoneClient = this.phone.Text.Trim();
            var idGoods = GetIdGoods(goods);

            var sqlQuery = "INSERT INTO cookiedb.dbo.orderlist (cookiedb.dbo.orderlist.id_goods, " +
                "cookiedb.dbo.orderlist.count_goods, " +
                "cookiedb.dbo.orderlist.address_client, " +
                "cookiedb.dbo.orderlist.phone_client, " +
                "cookiedb.dbo.orderlist.client_login, " +
                "cookiedb.dbo.orderlist.status) VALUES(" +
                    + idGoods        +
                "," + countGoods     + "," +
                "'" + addressClient  + "'," +
                "'" + phoneClient    + "'," +
                "'" + this.userLogin + "'"
                + ", 0)";

            if (db.ToInsertQuery(sqlQuery))
                MessageBox.Show("Ваш заказ добавлен. Ожидайте пока менеджер его обработает");
        }

        private bool CheckOnFillOrder()
        {
            var goods         = this.choiseGoods.Text.Trim();
            var countGoods    = this.countGoods.Text.Trim();
            var addressClient = this.addressTr.Text.Trim();
            var phoneClient   = this.addressTr.Text.Trim();

            if ((goods != "") && (countGoods != "") && (addressClient != "") && (phoneClient != ""))
                return true;

            return false;
        }

        private int GetIdGoods(string nameGoods)
        {

            var sqlQuery = "SELECT cookiedb.dbo.goodslist.id id FROM cookiedb.dbo.goodslist WHERE cookiedb.dbo.goodslist.name='" + nameGoods + "'";

            var reulstID = 0;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    reulstID = reader.GetInt32(0);

                reader.Close();
                conn.Close();
            }


            return reulstID;
        }

        private void GetAndFillDataForOrder()
        {

            this.choiseGoods.Items.Clear();

            var sqlQueyr = "SELECT * FROM cookiedb.dbo.goodsList";

            using(SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQueyr, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    this.choiseGoods.Items.Add(Convert.ToString(reader.GetValue(1)));
                }

                reader.Close();
                conn.Close();
            }
        }

        private void checkOrderBtn_Click(object sender, EventArgs e)
        {
            ToHiddenMakeOrder();
            ToVisibleListOrder();
            
            GetAndFillDataForCheckOrder();

            ClearFieldOfOrder();

            this.AgreeOrderBtn.Visible = false;
            
        }

        private void ClearFieldOfOrder()
        {
            this.idOrderLabel.Text     = "";
            this.orderGoodsLabel.Text  = "";
            this.OrderCountLabel.Text  = "";
            this.OrderDateLabel.Text   = "";
            this.OrderPhoneLabel.Text  = "";
            this.OrderStatusLabel.Text = "";

        }

        private void FillFiledOfOrder()
        {
            
        }

        private void GetAndFillDataForCheckOrder()
        {
            this.listOrder.Items.Clear();
            GetListOrders();
        }

        private void ClearLabelCheckOrder()
        {

        }

        private void GetListOrders()
        {
            var sqlQuery = "SELECT * FROM cookiedb.dbo.orderlist WHERE cookiedb.dbo.orderlist.client_login='" + userLogin + "'";

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.listOrder.Items.Add(Convert.ToString(reader.GetInt32(0)));
                }

                reader.Close();
                conn.Close();
            }
        }

        private void homeform_Load(object sender, EventArgs e)
        {

        }

        private void ToHiddenListOrder()
        {
            this.listOrder.Visible              = false;

            this.idOrderCheckLabel.Visible      = false;
            this.GoodsLable.Visible             = false;
            this.CountGoodsCheckLabel.Visible   = false;
            this.AddressOrderCheckLabel.Visible = false;
            this.PhoneOrderCheckLabel.Visible   = false;
            this.OrderStatusCheckLabel.Visible  = false;
            this.OrderDateCheckLabel.Visible    = false;


            this.idOrderLabel.Visible           = false;
            this.orderGoodsLabel.Visible        = false;
            this.OrderCountLabel.Visible        = false;
            this.OrderAdressLabel.Visible       = false;
            this.OrderPhoneLabel.Visible        = false;
            this.OrderStatusLabel.Visible       = false;
            this.OrderDateLabel.Visible         = false;
            this.AgreeOrderBtn.Visible          = false;
        }

        private void ToVisibleListOrder()
        {
            this.listOrder.Visible              = true;

            this.idOrderCheckLabel.Visible      = true;
            this.GoodsLable.Visible             = true;
            this.CountGoodsCheckLabel.Visible   = true;
            this.AddressOrderCheckLabel.Visible = true;
            this.PhoneOrderCheckLabel.Visible   = true;
            this.OrderStatusCheckLabel.Visible  = true;
            this.OrderDateCheckLabel.Visible    = true;


            this.idOrderLabel.Visible           = true;
            this.orderGoodsLabel.Visible        = true;
            this.OrderCountLabel.Visible        = true;
            this.OrderAdressLabel.Visible       = true;
            this.OrderPhoneLabel.Visible        = true;
            this.OrderStatusLabel.Visible       = true;
            this.OrderDateLabel.Visible         = true;

            this.AgreeOrderBtn.Visible          = true;
        }

        private void ToHiddenMakeOrder()
        {
            this.AdressTrLabel.Visible   = false;
            this.CountGoodsLabel.Visible = false;
            this.GoodsLabel.Visible      = false;
            this.PhoneLabel.Visible      = false;

            this.choiseGoods.Visible     = false;
            this.phone.Visible           = false;
            this.countGoods.Visible      = false;
            this.addressTr.Visible       = false;

            this.goOrderBtn.Visible      = false;
        }

        private void ToVisibleMakeOrder()
        {
            this.AdressTrLabel.Visible   = true;
            this.CountGoodsLabel.Visible = true;
            this.GoodsLabel.Visible      = true;
            this.PhoneLabel.Visible      = true;

            this.choiseGoods.Visible     = true;
            this.phone.Visible           = true;
            this.countGoods.Visible      = true;
            this.addressTr.Visible       = true;

            this.goOrderBtn.Visible      = true;
        }

        private void AgreeOrderBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void choiseGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void goOrderBtn_Click(object sender, EventArgs e)
        {
            ToInsertNewOrder();
        }
    }
}
