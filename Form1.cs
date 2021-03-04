using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CookieApp
{
    public partial class autorizationForm : Form
    {

        private DBUtils db;

        public autorizationForm()
        {
            InitializeComponent();
            this.ToHiddenRegInputs();

            db = new DBUtils(@"Data Source=DESKTOP-UK6V12H\SQLEXPRESS;Initial Catalog=cookiedb;Integrated Security=True");

        }

        private void autorizationForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check input fileds and check on exist in db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToLogin_Click(object sender, EventArgs e)
        {
            
            var userLogin    = this.loginInput.Text.Trim();
            var userPassword = this.pswInput.Text.Trim();



            var sqlQuery = "SELECT * FROM cookiedb.dbo.users " +
                "WHERE(cookiedb.dbo.users.login = '" + userLogin + "' OR cookiedb.dbo.users.email = '" + userLogin + "') " +
                "AND cookiedb.dbo.users.psw = '" + userPassword + "'";

            if ((userLogin == "") || (userPassword == ""))
            {
                if (!this.warmLabel.Visible)
                    this.warmLabel.Visible = true;
            }
            else
            {
                if (db.IsRowExistAutorizatoin(sqlQuery) == 1)
                {
                    homeform hf = new homeform(db, userLogin, this);
                    hf.Show();
                    this.Hide();
                }
                else if (db.IsRowExistAutorizatoin(sqlQuery) == 2)
                {
                    homeformAdmin hfd = new homeformAdmin(db, userLogin, this);
                    hfd.Show();
                    this.Hide();
                }
                else
                {
                    this.warmLabel.Text = "Такого пользователя не существует";
                }
            }
        }


        private void ToRegistration_Click(object sender, EventArgs e)
        {
            this.ToHiddenLoginInputs();
            this.ToVisibleRegInputs();
        }

        

        /// <summary>
        /// To close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void ToHiddenRegInputs()
        {
            this.regLoginLabel.Visible  = false;
            this.regPswLabel.Visible    = false;
            this.RegRepPswLabel.Visible = false;
            this.RegEmailLabel.Visible  = false;

            this.RegLoginInput.Visible  = false;
            this.RegPswInput.Visible    = false;
            this.RegRepPswInput.Visible = false;
            this.RegEmailInput.Visible  = false;

            this.ToRegBtn.Visible       = false;
            this.backToLoginBtn.Visible = false;

            this.warmLabel.Visible      = false;
        }

        private void ToVisibleRegInputs()
        {
            this.regLoginLabel.Visible  = true;
            this.regPswLabel.Visible    = true;
            this.RegRepPswLabel.Visible = true;
            this.RegEmailLabel.Visible  = true;

            this.RegLoginInput.Visible  = true;
            this.RegPswInput.Visible    = true;
            this.RegRepPswInput.Visible = true;
            this.RegEmailInput.Visible  = true;

            this.ToRegBtn.Visible       = true;
            this.backToLoginBtn.Visible = true;

            this.warmLabel.Visible      = false;
        }

        private void ToHiddenLoginInputs()
        {
            this.loginInput.Visible = false;
            this.pswInput.Visible   = false;

            this.loginLabel.Visible = false;
            this.pswLabel.Visible   = false;

            this.loginBtn.Visible   = false;
            this.RegBtn.Visible     = false;

            this.warmLabel.Visible  = false;
        }

        private void ToVisibleLoginInputs()
        {
            this.loginInput.Visible = true;
            this.pswInput.Visible   = true;

            this.loginLabel.Visible = true;
            this.pswLabel.Visible   = true;

            this.loginBtn.Visible   = true;
            this.RegBtn.Visible     = true;

            this.warmLabel.Visible  = false;
        }

        private void ToRegBtn_Click(object sender, EventArgs e)
        {
            var userLogin       = this.RegLoginInput.Text.Trim();
            var userPassword    = this.RegPswInput.Text.Trim();
            var userRepPassword = this.RegRepPswInput.Text.Trim();
            var userEmail       = this.RegEmailInput.Text.Trim();

            if ((userLogin == "") || (userPassword == "") || (userRepPassword == "") || (userEmail == ""))
            {
                if (!this.warmLabel.Visible)
                    this.warmLabel.Visible = true;
            }
            else if(userRepPassword != userPassword)
            {
                this.warmLabel.Text = "Пароли не совпадают";
            }
            else 
            {
                var sqlQuery = "SELECT * FROM cookiedb.dbo.users " +
                    "WHERE (cookiedb.dbo.users.login = '" + userLogin + "' OR cookiedb.dbo.users.email = '" + userLogin + "') " +
                    "AND cookiedb.dbo.users.psw = '" + userPassword + "'";
                if (db.IsRowExist(sqlQuery))
                {
                    this.warmLabel.Text = "Пользователь с такими данными уже существует";
                }
                else
                {
                    sqlQuery = "INSERT INTO cookiedb.dbo.users (cookiedb.dbo.users.login, cookiedb.dbo.users.email, cookiedb.dbo.users.psw, cookiedb.dbo.users.admin) VALUES(" +
                        "'" + userLogin + "', " +
                        "'" + userEmail + "', " +
                        "'" + userPassword + "', " +
                        "0" +
                        ")";

                    if (db.ToInsertQuery(sqlQuery))
                    {
                        MessageBox.Show("Регистрация прошла успешно");
                        ToHiddenRegInputs();
                        ToVisibleLoginInputs();
                    }
                    else
                    {
                        MessageBox.Show("Васян, шо то не так пошло :(");
                    }
                }
            }
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            this.ToHiddenRegInputs();
            this.ToVisibleLoginInputs();
        }
    }
}
