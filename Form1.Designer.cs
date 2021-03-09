
namespace CookieApp
{
    partial class autorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.pswLabel = new System.Windows.Forms.Label();
            this.pswInput = new System.Windows.Forms.MaskedTextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.RegBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.warmLabel = new System.Windows.Forms.Label();
            this.regLoginLabel = new System.Windows.Forms.Label();
            this.regPswLabel = new System.Windows.Forms.Label();
            this.RegRepPswLabel = new System.Windows.Forms.Label();
            this.RegEmailLabel = new System.Windows.Forms.Label();
            this.RegLoginInput = new System.Windows.Forms.TextBox();
            this.RegPswInput = new System.Windows.Forms.TextBox();
            this.RegEmailInput = new System.Windows.Forms.TextBox();
            this.RegRepPswInput = new System.Windows.Forms.TextBox();
            this.ToRegBtn = new System.Windows.Forms.Button();
            this.backToLoginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(130, 118);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(79, 16);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин/Email";
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswLabel.Location = new System.Drawing.Point(158, 157);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(51, 16);
            this.pswLabel.TabIndex = 1;
            this.pswLabel.Text = "Пароль";
            // 
            // pswInput
            // 
            this.pswInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswInput.Location = new System.Drawing.Point(215, 154);
            this.pswInput.Name = "pswInput";
            this.pswInput.PasswordChar = '*';
            this.pswInput.Size = new System.Drawing.Size(190, 23);
            this.pswInput.TabIndex = 2;
            // 
            // loginInput
            // 
            this.loginInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(215, 116);
            this.loginInput.MaxLength = 50;
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(190, 23);
            this.loginInput.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkRed;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginBtn.Location = new System.Drawing.Point(215, 191);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(190, 30);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.ToLogin_Click);
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.DarkRed;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegBtn.Location = new System.Drawing.Point(215, 231);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(190, 30);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.ToRegistration_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::CookieApp.media.remove_q;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.InitialImage = global::CookieApp.media.remove;
            this.exitBtn.Location = new System.Drawing.Point(572, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(24, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // warmLabel
            // 
            this.warmLabel.AutoSize = true;
            this.warmLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warmLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warmLabel.Location = new System.Drawing.Point(212, 26);
            this.warmLabel.Name = "warmLabel";
            this.warmLabel.Size = new System.Drawing.Size(195, 18);
            this.warmLabel.TabIndex = 7;
            this.warmLabel.Text = "Нужно заполнить все поля";
            this.warmLabel.Visible = false;
            // 
            // regLoginLabel
            // 
            this.regLoginLabel.AutoSize = true;
            this.regLoginLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginLabel.Location = new System.Drawing.Point(168, 69);
            this.regLoginLabel.Name = "regLoginLabel";
            this.regLoginLabel.Size = new System.Drawing.Size(43, 16);
            this.regLoginLabel.TabIndex = 8;
            this.regLoginLabel.Text = "Логин";
            // 
            // regPswLabel
            // 
            this.regPswLabel.AutoSize = true;
            this.regPswLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPswLabel.Location = new System.Drawing.Point(160, 108);
            this.regPswLabel.Name = "regPswLabel";
            this.regPswLabel.Size = new System.Drawing.Size(51, 16);
            this.regPswLabel.TabIndex = 9;
            this.regPswLabel.Text = "Пароль";
            // 
            // RegRepPswLabel
            // 
            this.RegRepPswLabel.AutoSize = true;
            this.RegRepPswLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegRepPswLabel.Location = new System.Drawing.Point(81, 146);
            this.RegRepPswLabel.Name = "RegRepPswLabel";
            this.RegRepPswLabel.Size = new System.Drawing.Size(130, 16);
            this.RegRepPswLabel.TabIndex = 10;
            this.RegRepPswLabel.Text = "Подтвердите пароль";
            // 
            // RegEmailLabel
            // 
            this.RegEmailLabel.AutoSize = true;
            this.RegEmailLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegEmailLabel.Location = new System.Drawing.Point(172, 185);
            this.RegEmailLabel.Name = "RegEmailLabel";
            this.RegEmailLabel.Size = new System.Drawing.Size(39, 16);
            this.RegEmailLabel.TabIndex = 11;
            this.RegEmailLabel.Text = "Email";
            // 
            // RegLoginInput
            // 
            this.RegLoginInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLoginInput.Location = new System.Drawing.Point(217, 68);
            this.RegLoginInput.MaxLength = 50;
            this.RegLoginInput.Name = "RegLoginInput";
            this.RegLoginInput.Size = new System.Drawing.Size(190, 23);
            this.RegLoginInput.TabIndex = 12;
            // 
            // RegPswInput
            // 
            this.RegPswInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPswInput.Location = new System.Drawing.Point(217, 107);
            this.RegPswInput.MaxLength = 50;
            this.RegPswInput.Name = "RegPswInput";
            this.RegPswInput.PasswordChar = '*';
            this.RegPswInput.Size = new System.Drawing.Size(190, 23);
            this.RegPswInput.TabIndex = 13;
            // 
            // RegEmailInput
            // 
            this.RegEmailInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegEmailInput.Location = new System.Drawing.Point(217, 184);
            this.RegEmailInput.MaxLength = 100;
            this.RegEmailInput.Name = "RegEmailInput";
            this.RegEmailInput.Size = new System.Drawing.Size(190, 23);
            this.RegEmailInput.TabIndex = 15;
            // 
            // RegRepPswInput
            // 
            this.RegRepPswInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegRepPswInput.Location = new System.Drawing.Point(217, 145);
            this.RegRepPswInput.MaxLength = 50;
            this.RegRepPswInput.Name = "RegRepPswInput";
            this.RegRepPswInput.PasswordChar = '*';
            this.RegRepPswInput.Size = new System.Drawing.Size(190, 23);
            this.RegRepPswInput.TabIndex = 14;
            // 
            // ToRegBtn
            // 
            this.ToRegBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ToRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToRegBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToRegBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ToRegBtn.Location = new System.Drawing.Point(217, 224);
            this.ToRegBtn.Name = "ToRegBtn";
            this.ToRegBtn.Size = new System.Drawing.Size(190, 30);
            this.ToRegBtn.TabIndex = 16;
            this.ToRegBtn.Text = "Регистрация";
            this.ToRegBtn.UseVisualStyleBackColor = false;
            this.ToRegBtn.Click += new System.EventHandler(this.ToRegBtn_Click);
            // 
            // backToLoginBtn
            // 
            this.backToLoginBtn.BackColor = System.Drawing.Color.DarkRed;
            this.backToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToLoginBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToLoginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backToLoginBtn.Location = new System.Drawing.Point(217, 269);
            this.backToLoginBtn.Name = "backToLoginBtn";
            this.backToLoginBtn.Size = new System.Drawing.Size(190, 30);
            this.backToLoginBtn.TabIndex = 17;
            this.backToLoginBtn.Text = "Назад";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // autorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToLoginBtn);
            this.Controls.Add(this.ToRegBtn);
            this.Controls.Add(this.RegEmailInput);
            this.Controls.Add(this.RegRepPswInput);
            this.Controls.Add(this.RegPswInput);
            this.Controls.Add(this.RegLoginInput);
            this.Controls.Add(this.RegEmailLabel);
            this.Controls.Add(this.RegRepPswLabel);
            this.Controls.Add(this.regPswLabel);
            this.Controls.Add(this.regLoginLabel);
            this.Controls.Add(this.warmLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.pswInput);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "autorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.autorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.MaskedTextBox pswInput;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label warmLabel;
        private System.Windows.Forms.Label regLoginLabel;
        private System.Windows.Forms.Label regPswLabel;
        private System.Windows.Forms.Label RegRepPswLabel;
        private System.Windows.Forms.Label RegEmailLabel;
        private System.Windows.Forms.TextBox RegLoginInput;
        private System.Windows.Forms.TextBox RegPswInput;
        private System.Windows.Forms.TextBox RegEmailInput;
        private System.Windows.Forms.TextBox RegRepPswInput;
        private System.Windows.Forms.Button ToRegBtn;
        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

