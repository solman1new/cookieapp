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
            ToHiddeneDetaliOrder();
            ToHiddenListOrder();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void ToHiddenListOrder()
        {
            this.listOrder.Visible        = false;
            this.searchBtn.Visible        = false;
            this.searchOrderInput.Visible = false;
            this.label1.Visible           = false;
        }

        private void ToVisibleListOrder()
        {
            this.listOrder.Visible        = true;
            this.searchBtn.Visible        = true;
            this.searchOrderInput.Visible = true;
            this.label1.Visible           = true;
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
            
        }

        private void ToVisibleMakeOrder()
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            idOrder = Convert.ToInt32(this.listOrder.SelectedItem.ToString());
            //MessageBox.Show(Convert.ToString(idOrder));
            fillFiledOnSelected();
        }

        /// <summary>
        /// Заполняем поля, если выбрали заказ из списка
        /// </summary>
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
                    {
                        this.AcceptButton.Enabled = true;
                    }
                    else if (reader.GetInt32(6) == 1)
                    {
                        this.AcceptButton.Enabled = false;
                        this.dateTimePicker1.Visible = false;
                        this.setDateLb.Text = reader.GetString(7);
                        this.AcceptButton.BackColor = Color.Yellow;
                    }
                    else
                    {
                        this.AcceptButton.Enabled = false;
                        this.dateTimePicker1.Visible = false;
                        this.setDateLb.Text = reader.GetString(7);
                        this.AcceptButton.Text = "Заказ уже забрали";
                        this.AcceptButton.BackColor = Color.DarkRed;
                    }

                    this.IdViewLb.Text = Convert.ToString(reader.GetInt32(0));
                    this.countViewLb.Text = Convert.ToString(reader.GetInt32(2));
                    this.phoneViewLb.Text = reader.GetString(4);
                    this.loginViewLb.Text = reader.GetString(5);
                    this.addressViewLb.Text = reader.GetString(4);
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


        /// <summary>
        /// Выводим в список все заказы со статусом 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Запрос на апдейт строки заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            /*
             * 0 - запрос не обратботан менеджером
             * 1 - менеджер обработал запрос, ожидается пока клиент подтвердит получение товара
             * 2 - пользователь подтвердил получение
            */
            
            var statusQuery = 0;
            MessageBox.Show(dateTimePicker1.Value.ToString("yyyy MM dd"));
            var sqlQuery = "UPDATE cookiedb.dbo.orderlist SET" +
                " cookiedb.dbo.orderlist.date_get = '" + dateTimePicker1.Value.ToString("yyyy MM dd") + "'" + // ставим ту дату, которую указал менджер
                ", cookiedb.dbo.orderlist.status = 1" + // ставим статус обработан
                "cookiedb.dbo.orderlist.status=1 WHERE cookiedb.dbo.orderlist.id = " + idOrder;

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


        /// <summary>
        /// Поиск заказов по idшнику или по логину пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    "OR cookiedb.dbo.orderlist.id=" + searchOrderInput.Text.Trim();

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
