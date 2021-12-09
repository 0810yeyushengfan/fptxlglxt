
namespace fpglxt
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Account = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Revoke = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.User = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登录富婆通讯录管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(124, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(124, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Account
            // 
            this.Account.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account.Location = new System.Drawing.Point(316, 212);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(401, 56);
            this.Account.TabIndex = 5;
            this.Account.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(316, 347);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(401, 56);
            this.Password.TabIndex = 6;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login.Location = new System.Drawing.Point(175, 521);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(135, 55);
            this.Login.TabIndex = 7;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Revoke
            // 
            this.Revoke.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Revoke.Location = new System.Drawing.Point(582, 521);
            this.Revoke.Name = "Revoke";
            this.Revoke.Size = new System.Drawing.Size(135, 55);
            this.Revoke.TabIndex = 8;
            this.Revoke.Text = "取消";
            this.Revoke.UseVisualStyleBackColor = true;
            this.Revoke.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin.Location = new System.Drawing.Point(582, 461);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(162, 52);
            this.Admin.TabIndex = 9;
            this.Admin.Text = "管理员";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Checked = true;
            this.User.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User.Location = new System.Drawing.Point(175, 461);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(125, 52);
            this.User.TabIndex = 10;
            this.User.TabStop = true;
            this.User.Text = "用户";
            this.User.UseVisualStyleBackColor = true;
            this.User.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 782);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Revoke);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("华文仿宋", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Revoke;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.Button Login;
    }
}

