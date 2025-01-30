namespace DTIWinformProject
{
    partial class FrmShapeArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShapeArea));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbCircleShow = new System.Windows.Forms.Label();
            this.btCircleCancel = new System.Windows.Forms.Button();
            this.btCircleCal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdCircleRound = new System.Windows.Forms.RadioButton();
            this.rdCircleArea = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbRectShow = new System.Windows.Forms.Label();
            this.btRectCancel = new System.Windows.Forms.Button();
            this.btRectCal = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdRectRound = new System.Windows.Forms.RadioButton();
            this.rdRectArea = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbTriShow = new System.Windows.Forms.Label();
            this.btTriCancel = new System.Windows.Forms.Button();
            this.tbSideAngle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdTriRound = new System.Windows.Forms.RadioButton();
            this.rdTriArea = new System.Windows.Forms.RadioButton();
            this.btTriCal = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 482);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 21;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(105, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 295);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbCircleShow);
            this.tabPage1.Controls.Add(this.btCircleCancel);
            this.tabPage1.Controls.Add(this.btCircleCal);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.rdCircleRound);
            this.tabPage1.Controls.Add(this.rdCircleArea);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbCircleShow
            // 
            this.lbCircleShow.BackColor = System.Drawing.Color.Yellow;
            this.lbCircleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircleShow.ForeColor = System.Drawing.Color.Red;
            this.lbCircleShow.Location = new System.Drawing.Point(47, 189);
            this.lbCircleShow.Name = "lbCircleShow";
            this.lbCircleShow.Size = new System.Drawing.Size(228, 46);
            this.lbCircleShow.TabIndex = 25;
            this.lbCircleShow.Text = "0.00";
            this.lbCircleShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCircleCancel
            // 
            this.btCircleCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCircleCancel.Location = new System.Drawing.Point(310, 153);
            this.btCircleCancel.Name = "btCircleCancel";
            this.btCircleCancel.Size = new System.Drawing.Size(108, 33);
            this.btCircleCancel.TabIndex = 35;
            this.btCircleCancel.Text = "ยกเลิก";
            this.btCircleCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCancel.UseVisualStyleBackColor = true;
            this.btCircleCancel.Click += new System.EventHandler(this.btCircleCancel_Click);
            // 
            // btCircleCal
            // 
            this.btCircleCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCircleCal.Location = new System.Drawing.Point(310, 98);
            this.btCircleCal.Name = "btCircleCal";
            this.btCircleCal.Size = new System.Drawing.Size(108, 31);
            this.btCircleCal.TabIndex = 34;
            this.btCircleCal.Text = "คำนวณ";
            this.btCircleCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCal.UseVisualStyleBackColor = true;
            this.btCircleCal.Click += new System.EventHandler(this.btCircleCal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "ผลลัพธ์";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(50, 51);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(225, 20);
            this.tbRadius.TabIndex = 26;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "รัศมี";
            // 
            // rdCircleRound
            // 
            this.rdCircleRound.AutoSize = true;
            this.rdCircleRound.Location = new System.Drawing.Point(50, 122);
            this.rdCircleRound.Name = "rdCircleRound";
            this.rdCircleRound.Size = new System.Drawing.Size(94, 17);
            this.rdCircleRound.TabIndex = 24;
            this.rdCircleRound.Text = "เส้นรอบวงกลม";
            this.rdCircleRound.UseVisualStyleBackColor = true;
            // 
            // rdCircleArea
            // 
            this.rdCircleArea.AutoSize = true;
            this.rdCircleArea.Checked = true;
            this.rdCircleArea.Location = new System.Drawing.Point(50, 88);
            this.rdCircleArea.Name = "rdCircleArea";
            this.rdCircleArea.Size = new System.Drawing.Size(79, 17);
            this.rdCircleArea.TabIndex = 23;
            this.rdCircleArea.TabStop = true;
            this.rdCircleArea.Text = "พื้นที่วงกลม";
            this.rdCircleArea.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbRectShow);
            this.tabPage2.Controls.Add(this.btRectCancel);
            this.tabPage2.Controls.Add(this.btRectCal);
            this.tabPage2.Controls.Add(this.tbHeight);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbWidth);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rdRectRound);
            this.tabPage2.Controls.Add(this.rdRectArea);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRectShow
            // 
            this.lbRectShow.BackColor = System.Drawing.Color.Yellow;
            this.lbRectShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRectShow.ForeColor = System.Drawing.Color.Red;
            this.lbRectShow.Location = new System.Drawing.Point(48, 189);
            this.lbRectShow.Name = "lbRectShow";
            this.lbRectShow.Size = new System.Drawing.Size(228, 46);
            this.lbRectShow.TabIndex = 36;
            this.lbRectShow.Text = "0.00";
            this.lbRectShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRectCancel
            // 
            this.btRectCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btRectCancel.Location = new System.Drawing.Point(294, 143);
            this.btRectCancel.Name = "btRectCancel";
            this.btRectCancel.Size = new System.Drawing.Size(108, 33);
            this.btRectCancel.TabIndex = 35;
            this.btRectCancel.Text = "ยกเลิก";
            this.btRectCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCancel.UseVisualStyleBackColor = true;
            // 
            // btRectCal
            // 
            this.btRectCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btRectCal.Location = new System.Drawing.Point(294, 88);
            this.btRectCal.Name = "btRectCal";
            this.btRectCal.Size = new System.Drawing.Size(108, 31);
            this.btRectCal.TabIndex = 34;
            this.btRectCal.Text = "คำนวณ";
            this.btRectCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCal.UseVisualStyleBackColor = true;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(177, 51);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(98, 20);
            this.tbHeight.TabIndex = 15;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ยาว";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ผลลัพธ์";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(50, 51);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(98, 20);
            this.tbWidth.TabIndex = 10;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "กว้าง";
            // 
            // rdRectRound
            // 
            this.rdRectRound.AutoSize = true;
            this.rdRectRound.Location = new System.Drawing.Point(50, 122);
            this.rdRectRound.Name = "rdRectRound";
            this.rdRectRound.Size = new System.Drawing.Size(101, 17);
            this.rdRectRound.TabIndex = 8;
            this.rdRectRound.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdRectRound.UseVisualStyleBackColor = true;
            // 
            // rdRectArea
            // 
            this.rdRectArea.AutoSize = true;
            this.rdRectArea.Checked = true;
            this.rdRectArea.Location = new System.Drawing.Point(50, 88);
            this.rdRectArea.Name = "rdRectArea";
            this.rdRectArea.Size = new System.Drawing.Size(86, 17);
            this.rdRectArea.TabIndex = 7;
            this.rdRectArea.TabStop = true;
            this.rdRectArea.Text = "พื้นที่สี่เหลี่ยม";
            this.rdRectArea.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbTriShow);
            this.tabPage3.Controls.Add(this.btTriCancel);
            this.tabPage3.Controls.Add(this.tbSideAngle);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtHeight);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbBase);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.rdTriRound);
            this.tabPage3.Controls.Add(this.rdTriArea);
            this.tabPage3.Controls.Add(this.btTriCal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbTriShow
            // 
            this.lbTriShow.BackColor = System.Drawing.Color.Yellow;
            this.lbTriShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriShow.ForeColor = System.Drawing.Color.Red;
            this.lbTriShow.Location = new System.Drawing.Point(48, 189);
            this.lbTriShow.Name = "lbTriShow";
            this.lbTriShow.Size = new System.Drawing.Size(228, 46);
            this.lbTriShow.TabIndex = 34;
            this.lbTriShow.Text = "0.00";
            this.lbTriShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTriCancel
            // 
            this.btTriCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btTriCancel.Location = new System.Drawing.Point(305, 143);
            this.btTriCancel.Name = "btTriCancel";
            this.btTriCancel.Size = new System.Drawing.Size(108, 33);
            this.btTriCancel.TabIndex = 33;
            this.btTriCancel.Text = "ยกเลิก";
            this.btTriCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCancel.UseVisualStyleBackColor = true;
            // 
            // tbSideAngle
            // 
            this.tbSideAngle.Location = new System.Drawing.Point(308, 51);
            this.tbSideAngle.Name = "tbSideAngle";
            this.tbSideAngle.Size = new System.Drawing.Size(109, 20);
            this.tbSideAngle.TabIndex = 26;
            this.tbSideAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSideAngle_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "ด้านตรงข้ามมุมฉาก";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(177, 51);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(98, 20);
            this.txtHeight.TabIndex = 24;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "สูง";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ผลลัพธ์";
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(50, 51);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(98, 20);
            this.tbBase.TabIndex = 19;
            this.tbBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBase_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ฐาน";
            // 
            // rdTriRound
            // 
            this.rdTriRound.AutoSize = true;
            this.rdTriRound.Location = new System.Drawing.Point(50, 122);
            this.rdTriRound.Name = "rdTriRound";
            this.rdTriRound.Size = new System.Drawing.Size(113, 17);
            this.rdTriRound.TabIndex = 17;
            this.rdTriRound.Text = "เส้นรอบสามเหลี่ยม";
            this.rdTriRound.UseVisualStyleBackColor = true;
            // 
            // rdTriArea
            // 
            this.rdTriArea.AutoSize = true;
            this.rdTriArea.Checked = true;
            this.rdTriArea.Location = new System.Drawing.Point(50, 88);
            this.rdTriArea.Name = "rdTriArea";
            this.rdTriArea.Size = new System.Drawing.Size(98, 17);
            this.rdTriArea.TabIndex = 16;
            this.rdTriArea.TabStop = true;
            this.rdTriArea.Text = "พื้นที่สามเหลี่ยม";
            this.rdTriArea.UseVisualStyleBackColor = true;
            // 
            // btTriCal
            // 
            this.btTriCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btTriCal.Location = new System.Drawing.Point(305, 88);
            this.btTriCal.Name = "btTriCal";
            this.btTriCal.Size = new System.Drawing.Size(108, 31);
            this.btTriCal.TabIndex = 21;
            this.btTriCal.Text = "คำนวณ";
            this.btTriCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCal.UseVisualStyleBackColor = true;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(622, 31);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(151, 67);
            this.btMainMenu.TabIndex = 24;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 67);
            this.label1.TabIndex = 23;
            this.label1.Text = "คำนวณรูปทรง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 507);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอ คำนวณรูปทรง - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btCircleCancel;
        private System.Windows.Forms.Button btCircleCal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdCircleRound;
        private System.Windows.Forms.RadioButton rdCircleArea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btRectCancel;
        private System.Windows.Forms.Button btRectCal;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdRectRound;
        private System.Windows.Forms.RadioButton rdRectArea;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btTriCancel;
        private System.Windows.Forms.TextBox tbSideAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdTriRound;
        private System.Windows.Forms.RadioButton rdTriArea;
        private System.Windows.Forms.Button btTriCal;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCircleShow;
        private System.Windows.Forms.Label lbRectShow;
        private System.Windows.Forms.Label lbTriShow;
        private System.Windows.Forms.Timer timer1;
    }
}