namespace LookInnaBook
{
    partial class formSignUp
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelReEnterPassword = new System.Windows.Forms.Label();
            this.textBoxReEnterPassword = new System.Windows.Forms.TextBox();
            this.labelFollowingInformation = new System.Windows.Forms.Label();
            this.labelCreditCard = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.labelAddressInfo = new System.Windows.Forms.Label();
            this.buttonSignUpNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(371, 186);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(339, 238);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(354, 496);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(344, 285);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(307, 450);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(439, 186);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(439, 232);
            this.textBoxUsername.MaxLength = 10;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(151, 26);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(439, 279);
            this.textBoxPassword.MaxLength = 10;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(151, 26);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelReEnterPassword
            // 
            this.labelReEnterPassword.AutoSize = true;
            this.labelReEnterPassword.Location = new System.Drawing.Point(275, 333);
            this.labelReEnterPassword.Name = "labelReEnterPassword";
            this.labelReEnterPassword.Size = new System.Drawing.Size(147, 20);
            this.labelReEnterPassword.TabIndex = 8;
            this.labelReEnterPassword.Text = "Re-Enter Password";
            // 
            // textBoxReEnterPassword
            // 
            this.textBoxReEnterPassword.Location = new System.Drawing.Point(439, 330);
            this.textBoxReEnterPassword.MaxLength = 10;
            this.textBoxReEnterPassword.Name = "textBoxReEnterPassword";
            this.textBoxReEnterPassword.Size = new System.Drawing.Size(151, 26);
            this.textBoxReEnterPassword.TabIndex = 9;
            this.textBoxReEnterPassword.UseSystemPasswordChar = true;
            // 
            // labelFollowingInformation
            // 
            this.labelFollowingInformation.AutoSize = true;
            this.labelFollowingInformation.Location = new System.Drawing.Point(186, 398);
            this.labelFollowingInformation.Name = "labelFollowingInformation";
            this.labelFollowingInformation.Size = new System.Drawing.Size(575, 20);
            this.labelFollowingInformation.TabIndex = 10;
            this.labelFollowingInformation.Text = "The Following Information Will Not Be Used Without The Permission Of The User";
            // 
            // labelCreditCard
            // 
            this.labelCreditCard.AutoSize = true;
            this.labelCreditCard.Location = new System.Drawing.Point(273, 554);
            this.labelCreditCard.Name = "labelCreditCard";
            this.labelCreditCard.Size = new System.Drawing.Size(149, 20);
            this.labelCreditCard.TabIndex = 11;
            this.labelCreditCard.Text = "Credit Card Number";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(439, 447);
            this.textBoxPhoneNumber.MaxLength = 10;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(151, 26);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(439, 496);
            this.textBoxAddress.MaxLength = 50;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(151, 26);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(439, 548);
            this.textBoxCreditCardNumber.MaxLength = 16;
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(151, 26);
            this.textBoxCreditCardNumber.TabIndex = 14;
            // 
            // labelAddressInfo
            // 
            this.labelAddressInfo.AutoSize = true;
            this.labelAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.labelAddressInfo.Location = new System.Drawing.Point(174, 516);
            this.labelAddressInfo.Name = "labelAddressInfo";
            this.labelAddressInfo.Size = new System.Drawing.Size(248, 15);
            this.labelAddressInfo.TabIndex = 15;
            this.labelAddressInfo.Text = "Street / City / Province / Postal Code / Country";
            // 
            // buttonSignUpNewUser
            // 
            this.buttonSignUpNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSignUpNewUser.Location = new System.Drawing.Point(439, 611);
            this.buttonSignUpNewUser.Name = "buttonSignUpNewUser";
            this.buttonSignUpNewUser.Size = new System.Drawing.Size(103, 43);
            this.buttonSignUpNewUser.TabIndex = 16;
            this.buttonSignUpNewUser.Text = "Sign Up";
            this.buttonSignUpNewUser.UseVisualStyleBackColor = false;
            this.buttonSignUpNewUser.Click += new System.EventHandler(this.buttonSignUpNewUser_Click);
            // 
            // formSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 943);
            this.Controls.Add(this.buttonSignUpNewUser);
            this.Controls.Add(this.labelAddressInfo);
            this.Controls.Add(this.textBoxCreditCardNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelCreditCard);
            this.Controls.Add(this.labelFollowingInformation);
            this.Controls.Add(this.textBoxReEnterPassword);
            this.Controls.Add(this.labelReEnterPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelName);
            this.Name = "formSignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelReEnterPassword;
        private System.Windows.Forms.TextBox textBoxReEnterPassword;
        private System.Windows.Forms.Label labelFollowingInformation;
        private System.Windows.Forms.Label labelCreditCard;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.Label labelAddressInfo;
        private System.Windows.Forms.Button buttonSignUpNewUser;
    }
}