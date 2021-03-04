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
    public partial class homeformAdmin : Form
    {
        private DBUtils db;
        private Form parent;
        private string userLogin;
        private int idOrder;

        public homeformAdmin()
        {
            InitializeComponent();
            this.ToHiddeneDetaliOrder();
            this.ToHiddenListOrder();
        }

        private void homeformAdmin_Load(object sender, EventArgs e)
        {

        }

        public homeformAdmin(DBUtils db, string userLogin, Form parent)
        {
            InitializeComponent();

            this.db = db;
            this.userLogin = userLogin;
            this.parent = parent;

            ToHiddenListOrder();
            ToHiddenMakeOrder();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void ToHiddenListOrder()
        {
            this.listOrder.Visible = false;
        }

        private void ToVisibleListOrder()
        {
            this.listOrder.Visible = true;
        }

        private void ToHiddeneDetaliOrder()
        {
            this.idOrderLb.Visible       = false;
            this.goodsLb.Visible         = false;
            this.addressLb.Visible       = false;
            this.countLb.Visible         = false;
            this.phoneClientLb.Visible   = false;
            this.loginClientLb.Visible   = false;
            this.setDateLb.Visible       = false;

            this.IdViewLb.Visible        = false;
            this.goodsViewLb.Visible     = false;
            this.countViewLb.Visible     = false;
            this.phoneViewLb.Visible     = false;
            this.loginViewLb.Visible     = false;
            this.addressViewLb.Visible   = false;
            this.dateTimePicker1.Visible = false;
            this.AcceptButton.Visible    = false;
        }

        private void ToVisibleDetaliOrder()
        {
            this.idOrderLb.Visible       = true;
            this.goodsLb.Visible         = true;
            this.addressLb.Visible       = true;
            this.countLb.Visible         = true;
            this.phoneClientLb.Visible   = true;
            this.loginClientLb.Visible   = true;
            this.setDateLb.Visible       = true;

            this.IdViewLb.Visible        = true;
            this.goodsViewLb.Visible     = true;
            this.countViewLb.Visible     = true;
            this.phoneViewLb.Visible     = true;
            this.loginViewLb.Visible     = true;
            this.addressViewLb.Visible   = true;
            this.dateTimePicker1.Visible = true;
            this.AcceptButton.Visible    = true;
        }

        private void ToHiddenMakeOrder()
        {
            //this.AdressTrLabel.Visible        = false;
            //this.CountGoodsLabel.Visible      = false;
            //this.GoodsLabel.Visible           = false;
            //this.PhoneLabel.Visible           = false;

            //this.choiseGoods.Visible          = false;
            //this.phone.Visible                = false;
            //this.countGoods.Visible           = false;
            //this.addressTr.Visible            = false;

            //this.goOrderBtn.Visible           = false;

            //this.searchOrderInput.Visible     = false;
        }

        private void ToVisibleMakeOrder()
        {
            //this.AdressTrLabel.Visible        = true;
            //this.CountGoodsLabel.Visible      = true;
            //this.GoodsLabel.Visible           = true;
            //this.PhoneLabel.Visible           = true;

            //this.choiseGoods.Visible          = true;
            //this.phone.Visible                = true;
            //this.countGoods.Visible           = true;
            //this.addressTr.Visible            = true;

            //this.goOrderBtn.Visible           = true;

            //this.searchOrderInput.Visible     = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            idOrder = Convert.ToInt32(this.listOrder.SelectedItem.ToString());
            MessageBox.Show(Convert.ToString(idOrder));
            fillFiledOnSelected();
        }

        private void fillFiledOnSelected()
        {
            ToVisibleDetaliOrder();


            var sqlQuery = "SELECT * FROM cookiedb.dbo.orderlist WHERE cookiedb.dbo.orderlist.id = " + idOrder;


            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(6) == 0)
                        this.AcceptButton.Enabled = true;
                    else
                    {
                        this.AcceptButton.Enabled = false;
                        this.dateTimePicker1.Visible = false;
                        this.setDateLb.Text = reader.GetString(7);
                    }

                    this.IdViewLb.Text = Convert.ToString(reader.GetInt32(0));
                    this.countViewLb.Text = Convert.ToString(reader.GetInt32(2));
                    this.phoneViewLb.Text = reader.GetString(4);
                    this.loginViewLb.Text = reader.GetString(5);
                }

                reader.Close();

                this.goodsViewLb.Text = getNameGoods();
            }
        }

        private string getNameGoods()
        {
            var name = "";
            var sqlQuery = "SELECT cookiedb.dbo.goodslist.name FROM cookiedb.dbo.goodslist WHERE cookiedb.dbo.goodslist.id=" + this.idOrder;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                    name = reader.GetString(0);

            }

            return name;
        }

        private void checkOrderBtn_Click(object sender, EventArgs e)
        {
            this.listOrder.Items.Clear();

            ToVisibleListOrder();


            var sqlQuery = "SELECT cookiedb.dbo.orderlist.id FROM cookiedb.dbo.orderlist WHERE cookiedb.dbo.orderlist.status = 0";
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                    this.listOrder.Items.Add(Convert.ToString(reader.GetValue(0)));

                reader.Close();

            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var statusQuery = 0;
            MessageBox.Show(dateTimePicker1.Value.ToString("yyyy MM dd"));
            var sqlQuery = "UPDATE cookiedb.dbo.orderlist SET cookiedb.dbo.orderlist.date_get = '" + dateTimePicker1.Value.ToString("yyyy MM dd") + "' WHERE cookiedb.dbo.orderlist.id = " + idOrder;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                statusQuery = cmd.ExecuteNonQuery();
            }

            if (statusQuery > 0)
                MessageBox.Show("Данные обновлены");
            else MessageBox.Show("Вася, ты проблема ходячая. Почему опять не работает?!");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.listOrder.Items.Clear();

            if (this.searchOrderInput.Text.Trim() == "")
                MessageBox.Show("Нужно что-то ввести");
            else
            {
                var sqlQuery = "SELECT cookiedb.dbo.orderlist.id " +
                    "FROM cookiedb.dbo.orderlist " +
                    "WHERE cookiedb.dbo.orderlist.client_login='" + searchOrderInput.Text.Trim() +"'" +
                    "OR cokiedb.dbo.orderlist.id=" + searchOrderInput.Text.Trim();

                using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                        this.listOrder.Items.Add(Convert.ToString(reader.GetValue(0)));

                    reader.Close();
                }
            }
        }
    }
}
