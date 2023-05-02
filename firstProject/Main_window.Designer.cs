namespace firstProject
{
    partial class Main_window
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
            this.bank = new System.Windows.Forms.Label();
            this.greet = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Label();
            this.otpButton = new System.Windows.Forms.Button();
            this.otp = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.close_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.depositInput = new System.Windows.Forms.TextBox();
            this.withdrawInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.ForeColor = System.Drawing.Color.White;
            this.bank.Location = new System.Drawing.Point(133, 24);
            this.bank.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(104, 40);
            this.bank.TabIndex = 7;
            this.bank.Text = "Bank";
            // 
            // greet
            // 
            this.greet.AutoSize = true;
            this.greet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet.ForeColor = System.Drawing.Color.White;
            this.greet.Location = new System.Drawing.Point(19, 99);
            this.greet.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.greet.Name = "greet";
            this.greet.Size = new System.Drawing.Size(104, 24);
            this.greet.TabIndex = 8;
            this.greet.Text = "Welcome";
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.White;
            this.withdraw.Location = new System.Drawing.Point(21, 271);
            this.withdraw.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(192, 29);
            this.withdraw.TabIndex = 9;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deposit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.White;
            this.deposit.Location = new System.Drawing.Point(21, 206);
            this.deposit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(192, 29);
            this.deposit.TabIndex = 10;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.White;
            this.credit.Location = new System.Drawing.Point(21, 155);
            this.credit.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(101, 24);
            this.credit.TabIndex = 11;
            this.credit.Text = "Credits : ";
            // 
            // otpButton
            // 
            this.otpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.otpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpButton.ForeColor = System.Drawing.Color.White;
            this.otpButton.Location = new System.Drawing.Point(54, 393);
            this.otpButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.otpButton.Name = "otpButton";
            this.otpButton.Size = new System.Drawing.Size(70, 29);
            this.otpButton.TabIndex = 12;
            this.otpButton.Text = "OTP";
            this.otpButton.UseVisualStyleBackColor = false;
            this.otpButton.Click += new System.EventHandler(this.otpButton_Click);
            // 
            // otp
            // 
            this.otp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otp.Location = new System.Drawing.Point(140, 393);
            this.otp.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.otp.Name = "otp";
            this.otp.Size = new System.Drawing.Size(100, 29);
            this.otp.TabIndex = 13;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(20, 340);
            this.status.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(86, 24);
            this.status.TabIndex = 14;
            this.status.Text = "Status :";
            // 
            // close_Button
            // 
            this.close_Button.BackColor = System.Drawing.Color.IndianRed;
            this.close_Button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Button.ForeColor = System.Drawing.Color.White;
            this.close_Button.Location = new System.Drawing.Point(267, -1);
            this.close_Button.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(41, 29);
            this.close_Button.TabIndex = 15;
            this.close_Button.Text = "X";
            this.close_Button.UseVisualStyleBackColor = false;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::firstProject.Properties.Resources.data_server;
            this.pictureBox1.Location = new System.Drawing.Point(73, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // depositInput
            // 
            this.depositInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositInput.Location = new System.Drawing.Point(226, 206);
            this.depositInput.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.depositInput.Name = "depositInput";
            this.depositInput.Size = new System.Drawing.Size(64, 29);
            this.depositInput.TabIndex = 19;
            this.depositInput.Enter += new System.EventHandler(this.depositInput_Enter);
            this.depositInput.Leave += new System.EventHandler(this.depositInput_Leave);
            // 
            // withdrawInput
            // 
            this.withdrawInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawInput.Location = new System.Drawing.Point(226, 271);
            this.withdrawInput.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.withdrawInput.Name = "withdrawInput";
            this.withdrawInput.Size = new System.Drawing.Size(64, 29);
            this.withdrawInput.TabIndex = 20;
            this.withdrawInput.Enter += new System.EventHandler(this.withdrawInput_Enter);
            this.withdrawInput.Leave += new System.EventHandler(this.withdrawInput_Leave);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.withdrawInput);
            this.Controls.Add(this.depositInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.status);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.otpButton);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.greet);
            this.Controls.Add(this.bank);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Main_window";
            this.Text = "Main_window";
            this.Load += new System.EventHandler(this.Main_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Label greet;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Button otpButton;
        private System.Windows.Forms.TextBox otp;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox depositInput;
        private System.Windows.Forms.TextBox withdrawInput;
    }
}