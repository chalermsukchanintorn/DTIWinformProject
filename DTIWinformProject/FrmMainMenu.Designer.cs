﻿namespace DTIWinformProject
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btExitToLogin = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btShapeArea = new System.Windows.Forms.Button();
            this.btDooDung = new System.Windows.Forms.Button();
            this.btLotto = new System.Windows.Forms.Button();
            this.btSAUShop = new System.Windows.Forms.Button();
            this.btCalculator = new System.Windows.Forms.Button();
            this.btWelcome = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "DTI Soft V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExitToLogin
            // 
            this.btExitToLogin.Image = global::DTIWinformProject.Properties.Resources.exitapp;
            this.btExitToLogin.Location = new System.Drawing.Point(678, 335);
            this.btExitToLogin.Name = "btExitToLogin";
            this.btExitToLogin.Size = new System.Drawing.Size(151, 184);
            this.btExitToLogin.TabIndex = 9;
            this.btExitToLogin.Text = "ออกจากระบบ";
            this.btExitToLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExitToLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExitToLogin.UseVisualStyleBackColor = true;
            this.btExitToLogin.Click += new System.EventHandler(this.btExitToLogin_Click);
            // 
            // btRegister
            // 
            this.btRegister.Image = global::DTIWinformProject.Properties.Resources.menu7;
            this.btRegister.Location = new System.Drawing.Point(474, 335);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(151, 184);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Go to Register";
            this.btRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btShapeArea
            // 
            this.btShapeArea.Image = global::DTIWinformProject.Properties.Resources.menu6;
            this.btShapeArea.Location = new System.Drawing.Point(270, 335);
            this.btShapeArea.Name = "btShapeArea";
            this.btShapeArea.Size = new System.Drawing.Size(151, 184);
            this.btShapeArea.TabIndex = 7;
            this.btShapeArea.Text = "Go to Shape Area";
            this.btShapeArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btShapeArea.UseVisualStyleBackColor = true;
            this.btShapeArea.Click += new System.EventHandler(this.btShapeArea_Click);
            // 
            // btDooDung
            // 
            this.btDooDung.Image = global::DTIWinformProject.Properties.Resources.menu5;
            this.btDooDung.Location = new System.Drawing.Point(66, 335);
            this.btDooDung.Name = "btDooDung";
            this.btDooDung.Size = new System.Drawing.Size(151, 184);
            this.btDooDung.TabIndex = 6;
            this.btDooDung.Text = "Go to DooDung";
            this.btDooDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDooDung.UseVisualStyleBackColor = true;
            this.btDooDung.Click += new System.EventHandler(this.btDooDung_Click);
            // 
            // btLotto
            // 
            this.btLotto.Image = global::DTIWinformProject.Properties.Resources.menu4;
            this.btLotto.Location = new System.Drawing.Point(678, 125);
            this.btLotto.Name = "btLotto";
            this.btLotto.Size = new System.Drawing.Size(151, 184);
            this.btLotto.TabIndex = 5;
            this.btLotto.Text = "Go to Lotto";
            this.btLotto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLotto.UseVisualStyleBackColor = true;
            this.btLotto.Click += new System.EventHandler(this.btLotto_Click);
            // 
            // btSAUShop
            // 
            this.btSAUShop.Image = global::DTIWinformProject.Properties.Resources.menu3;
            this.btSAUShop.Location = new System.Drawing.Point(474, 125);
            this.btSAUShop.Name = "btSAUShop";
            this.btSAUShop.Size = new System.Drawing.Size(151, 184);
            this.btSAUShop.TabIndex = 4;
            this.btSAUShop.Text = "Go to SAU Shop";
            this.btSAUShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSAUShop.UseVisualStyleBackColor = true;
            this.btSAUShop.Click += new System.EventHandler(this.btSAUShop_Click);
            // 
            // btCalculator
            // 
            this.btCalculator.Image = global::DTIWinformProject.Properties.Resources.menu2;
            this.btCalculator.Location = new System.Drawing.Point(270, 125);
            this.btCalculator.Name = "btCalculator";
            this.btCalculator.Size = new System.Drawing.Size(151, 184);
            this.btCalculator.TabIndex = 3;
            this.btCalculator.Text = "Go to Calculator";
            this.btCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCalculator.UseVisualStyleBackColor = true;
            this.btCalculator.Click += new System.EventHandler(this.btCalculator_Click);
            // 
            // btWelcome
            // 
            this.btWelcome.Image = global::DTIWinformProject.Properties.Resources.menu1;
            this.btWelcome.Location = new System.Drawing.Point(66, 125);
            this.btWelcome.Name = "btWelcome";
            this.btWelcome.Size = new System.Drawing.Size(151, 184);
            this.btWelcome.TabIndex = 2;
            this.btWelcome.Text = "Go to Welcome";
            this.btWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btWelcome.UseVisualStyleBackColor = true;
            this.btWelcome.Click += new System.EventHandler(this.btWelcome_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 580);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(912, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 605);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btExitToLogin);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btShapeArea);
            this.Controls.Add(this.btDooDung);
            this.Controls.Add(this.btLotto);
            this.Controls.Add(this.btSAUShop);
            this.Controls.Add(this.btCalculator);
            this.Controls.Add(this.btWelcome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWelcome;
        private System.Windows.Forms.Button btCalculator;
        private System.Windows.Forms.Button btSAUShop;
        private System.Windows.Forms.Button btLotto;
        private System.Windows.Forms.Button btExitToLogin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btShapeArea;
        private System.Windows.Forms.Button btDooDung;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}