
namespace WinFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LblLoginError = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.LblCorrectData = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.TxtDiscountP = new System.Windows.Forms.TextBox();
            this.LblDiscountP = new System.Windows.Forms.Label();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxtGoldPrice = new System.Windows.Forms.TextBox();
            this.LblGoldPrice = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelLogin.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.LblLoginError);
            this.PanelLogin.Controls.Add(this.TxtPassword);
            this.PanelLogin.Controls.Add(this.TxtUsername);
            this.PanelLogin.Controls.Add(this.BtnLogin);
            this.PanelLogin.Controls.Add(this.LblUsername);
            this.PanelLogin.Controls.Add(this.LblPassword);
            this.PanelLogin.Controls.Add(this.LblLogin);
            this.PanelLogin.Location = new System.Drawing.Point(245, 100);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(246, 263);
            this.PanelLogin.TabIndex = 0;
            // 
            // LblLoginError
            // 
            this.LblLoginError.AutoSize = true;
            this.LblLoginError.ForeColor = System.Drawing.Color.Red;
            this.LblLoginError.Location = new System.Drawing.Point(27, 227);
            this.LblLoginError.Name = "LblLoginError";
            this.LblLoginError.Size = new System.Drawing.Size(191, 15);
            this.LblLoginError.TabIndex = 6;
            this.LblLoginError.Text = "Username or password is incorrect.";
            this.LblLoginError.Visible = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(14, 140);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(190, 23);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(14, 82);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(190, 23);
            this.TxtUsername.TabIndex = 4;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(37, 186);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(167, 38);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(14, 63);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(62, 15);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "UserName";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(10, 120);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 15);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(10, 13);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(42, 15);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "LOGIN";
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.LblCorrectData);
            this.PanelUser.Controls.Add(this.btnClose);
            this.PanelUser.Controls.Add(this.btnScreen);
            this.PanelUser.Controls.Add(this.btnFile);
            this.PanelUser.Controls.Add(this.btnPaper);
            this.PanelUser.Controls.Add(this.btnCalculate);
            this.PanelUser.Controls.Add(this.TxtDiscountP);
            this.PanelUser.Controls.Add(this.LblDiscountP);
            this.PanelUser.Controls.Add(this.TxtTotalPrice);
            this.PanelUser.Controls.Add(this.LblTotalPrice);
            this.PanelUser.Controls.Add(this.TxtWeight);
            this.PanelUser.Controls.Add(this.LblWeight);
            this.PanelUser.Controls.Add(this.TxtGoldPrice);
            this.PanelUser.Controls.Add(this.LblGoldPrice);
            this.PanelUser.Controls.Add(this.LblWelcome);
            this.PanelUser.Location = new System.Drawing.Point(146, 44);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(536, 355);
            this.PanelUser.TabIndex = 1;
            this.PanelUser.Visible = false;
            // 
            // LblCorrectData
            // 
            this.LblCorrectData.AutoSize = true;
            this.LblCorrectData.ForeColor = System.Drawing.Color.Red;
            this.LblCorrectData.Location = new System.Drawing.Point(21, 321);
            this.LblCorrectData.Name = "LblCorrectData";
            this.LblCorrectData.Size = new System.Drawing.Size(169, 15);
            this.LblCorrectData.TabIndex = 14;
            this.LblCorrectData.Text = "Enter Correct Price and Weight";
            this.LblCorrectData.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(451, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnScreen
            // 
            this.btnScreen.Location = new System.Drawing.Point(180, 255);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(75, 43);
            this.btnScreen.TabIndex = 12;
            this.btnScreen.Text = "Print To Screen";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(282, 255);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 43);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "Print To File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(385, 255);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 43);
            this.btnPaper.TabIndex = 10;
            this.btnPaper.Text = "Print To Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 43);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // TxtDiscountP
            // 
            this.TxtDiscountP.Enabled = false;
            this.TxtDiscountP.Location = new System.Drawing.Point(265, 202);
            this.TxtDiscountP.Name = "TxtDiscountP";
            this.TxtDiscountP.Size = new System.Drawing.Size(58, 23);
            this.TxtDiscountP.TabIndex = 8;
            // 
            // LblDiscountP
            // 
            this.LblDiscountP.AutoSize = true;
            this.LblDiscountP.Location = new System.Drawing.Point(192, 202);
            this.LblDiscountP.Name = "LblDiscountP";
            this.LblDiscountP.Size = new System.Drawing.Size(67, 15);
            this.LblDiscountP.TabIndex = 7;
            this.LblDiscountP.Text = "Discount %";
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Enabled = false;
            this.TxtTotalPrice.Location = new System.Drawing.Point(157, 176);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.Size = new System.Drawing.Size(166, 23);
            this.TxtTotalPrice.TabIndex = 6;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Location = new System.Drawing.Point(21, 176);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(61, 15);
            this.LblTotalPrice.TabIndex = 5;
            this.LblTotalPrice.Text = "Total Price";
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(157, 115);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(269, 23);
            this.TxtWeight.TabIndex = 4;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(21, 115);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(89, 15);
            this.LblWeight.TabIndex = 3;
            this.LblWeight.Text = "Weight (grams)";
            // 
            // TxtGoldPrice
            // 
            this.TxtGoldPrice.Location = new System.Drawing.Point(157, 69);
            this.TxtGoldPrice.Name = "TxtGoldPrice";
            this.TxtGoldPrice.Size = new System.Drawing.Size(269, 23);
            this.TxtGoldPrice.TabIndex = 2;
            // 
            // LblGoldPrice
            // 
            this.LblGoldPrice.AutoSize = true;
            this.LblGoldPrice.Location = new System.Drawing.Point(21, 69);
            this.LblGoldPrice.Name = "LblGoldPrice";
            this.LblGoldPrice.Size = new System.Drawing.Size(117, 15);
            this.LblGoldPrice.TabIndex = 1;
            this.LblGoldPrice.Text = "Gold Price(per gram)";
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Location = new System.Drawing.Point(329, 12);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(57, 15);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.PanelLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblLoginError;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TxtGoldPrice;
        private System.Windows.Forms.Label LblGoldPrice;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TxtDiscountP;
        private System.Windows.Forms.Label LblDiscountP;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label LblCorrectData;
    }
}

