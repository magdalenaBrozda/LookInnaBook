namespace LookInnaBook
{
    partial class formCheckOut
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCompleteOrder = new System.Windows.Forms.Label();
            this.labelAddressInfo = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(309, 192);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(292, 252);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address:";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(257, 323);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(107, 20);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(395, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 26);
            this.textBox3.TabIndex = 5;
            // 
            // labelCompleteOrder
            // 
            this.labelCompleteOrder.AutoSize = true;
            this.labelCompleteOrder.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleteOrder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCompleteOrder.Location = new System.Drawing.Point(364, 131);
            this.labelCompleteOrder.Name = "labelCompleteOrder";
            this.labelCompleteOrder.Size = new System.Drawing.Size(194, 21);
            this.labelCompleteOrder.TabIndex = 6;
            this.labelCompleteOrder.Text = "Complete Your Order!";
            // 
            // labelAddressInfo
            // 
            this.labelAddressInfo.AutoSize = true;
            this.labelAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.labelAddressInfo.Location = new System.Drawing.Point(116, 272);
            this.labelAddressInfo.Name = "labelAddressInfo";
            this.labelAddressInfo.Size = new System.Drawing.Size(248, 15);
            this.labelAddressInfo.TabIndex = 16;
            this.labelAddressInfo.Text = "Street / City / Province / Postal Code / Country";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(257, 395);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(175, 20);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "Your Total Comes To: $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "total";
            // 
            // formCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAddressInfo);
            this.Controls.Add(this.labelCompleteOrder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Name = "formCheckOut";
            this.Text = "FormCheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCompleteOrder;
        private System.Windows.Forms.Label labelAddressInfo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
    }
}