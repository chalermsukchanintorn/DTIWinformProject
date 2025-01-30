namespace DTIWinformProject
{
    partial class FrmSAUShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAUShop));
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.lbShowTotalPay = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPencil = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPencil = new System.Windows.Forms.TextBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRuler = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRuler = new System.Windows.Forms.TextBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbRubber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRubber = new System.Windows.Forms.TextBox();
            this.cbRubber = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cbbSale = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Location = new System.Drawing.Point(60, 152);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(112, 17);
            this.cbPen.TabIndex = 0;
            this.cbPen.Text = "ปากกา 5 บาท/ด้าม";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.Click += new System.EventHandler(this.cbPen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btCalculate);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lbShowTotalPay);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(28, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(580, 23);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 49);
            this.btCancel.TabIndex = 45;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCalculate.Location = new System.Drawing.Point(436, 23);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(121, 49);
            this.btCalculate.TabIndex = 43;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(384, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 23);
            this.label22.TabIndex = 44;
            this.label22.Text = "บาท";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowTotalPay
            // 
            this.lbShowTotalPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbShowTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTotalPay.ForeColor = System.Drawing.Color.Red;
            this.lbShowTotalPay.Location = new System.Drawing.Point(185, 27);
            this.lbShowTotalPay.Name = "lbShowTotalPay";
            this.lbShowTotalPay.Size = new System.Drawing.Size(185, 47);
            this.lbShowTotalPay.TabIndex = 43;
            this.lbShowTotalPay.Text = "0.00";
            this.lbShowTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 23);
            this.label20.TabIndex = 43;
            this.label20.Text = "รวมเป็นเงินทั้งสิ้น";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "SAU Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPen
            // 
            this.tbPen.Location = new System.Drawing.Point(216, 149);
            this.tbPen.MaxLength = 3;
            this.tbPen.Name = "tbPen";
            this.tbPen.Size = new System.Drawing.Size(121, 20);
            this.tbPen.TabIndex = 16;
            this.tbPen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPen_KeyPress);
            this.tbPen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPen_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "รายการสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "จำนวน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "คิดเป็นเงิน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(343, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "ด้าม";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPen
            // 
            this.lbPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPen.ForeColor = System.Drawing.Color.Red;
            this.lbPen.Location = new System.Drawing.Point(404, 146);
            this.lbPen.Name = "lbPen";
            this.lbPen.Size = new System.Drawing.Size(130, 23);
            this.lbPen.TabIndex = 20;
            this.lbPen.Text = "0.00";
            this.lbPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(549, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "บาท";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(549, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "บาท";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPencil
            // 
            this.lbPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPencil.ForeColor = System.Drawing.Color.Red;
            this.lbPencil.Location = new System.Drawing.Point(404, 182);
            this.lbPencil.Name = "lbPencil";
            this.lbPencil.Size = new System.Drawing.Size(130, 23);
            this.lbPencil.TabIndex = 25;
            this.lbPencil.Text = "0.00";
            this.lbPencil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(343, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "ด้าม";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPencil
            // 
            this.tbPencil.Location = new System.Drawing.Point(216, 185);
            this.tbPencil.MaxLength = 3;
            this.tbPencil.Name = "tbPencil";
            this.tbPencil.Size = new System.Drawing.Size(121, 20);
            this.tbPencil.TabIndex = 23;
            this.tbPencil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPencil_KeyPress);
            this.tbPencil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPencil_KeyUp);
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Location = new System.Drawing.Point(60, 188);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(123, 17);
            this.cbPencil.TabIndex = 22;
            this.cbPencil.Text = "ดินสอ 1.50 บาท/ด้าม";
            this.cbPencil.UseVisualStyleBackColor = true;
            this.cbPencil.Click += new System.EventHandler(this.cbPencil_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(549, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 36;
            this.label11.Text = "บาท";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRuler
            // 
            this.lbRuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuler.ForeColor = System.Drawing.Color.Red;
            this.lbRuler.Location = new System.Drawing.Point(404, 252);
            this.lbRuler.Name = "lbRuler";
            this.lbRuler.Size = new System.Drawing.Size(130, 23);
            this.lbRuler.TabIndex = 35;
            this.lbRuler.Text = "0.00";
            this.lbRuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(343, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "อัน";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRuler
            // 
            this.tbRuler.Location = new System.Drawing.Point(216, 255);
            this.tbRuler.MaxLength = 3;
            this.tbRuler.Name = "tbRuler";
            this.tbRuler.Size = new System.Drawing.Size(121, 20);
            this.tbRuler.TabIndex = 33;
            this.tbRuler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRuler_KeyPress);
            this.tbRuler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRuler_KeyUp);
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Location = new System.Drawing.Point(60, 258);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(122, 17);
            this.cbRuler.TabIndex = 32;
            this.cbRuler.Text = "ไม้บรรทัด 2 บาท/อัน";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.Click += new System.EventHandler(this.cbRuler_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(549, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "บาท";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRubber
            // 
            this.lbRubber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbRubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRubber.ForeColor = System.Drawing.Color.Red;
            this.lbRubber.Location = new System.Drawing.Point(404, 216);
            this.lbRubber.Name = "lbRubber";
            this.lbRubber.Size = new System.Drawing.Size(130, 23);
            this.lbRubber.TabIndex = 30;
            this.lbRubber.Text = "0.00";
            this.lbRubber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(343, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "ก้อน";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRubber
            // 
            this.tbRubber.Location = new System.Drawing.Point(216, 219);
            this.tbRubber.MaxLength = 3;
            this.tbRubber.Name = "tbRubber";
            this.tbRubber.Size = new System.Drawing.Size(121, 20);
            this.tbRubber.TabIndex = 28;
            this.tbRubber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRubber_KeyPress);
            this.tbRubber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRubber_KeyUp);
            // 
            // cbRubber
            // 
            this.cbRubber.AutoSize = true;
            this.cbRubber.Location = new System.Drawing.Point(60, 222);
            this.cbRubber.Name = "cbRubber";
            this.cbRubber.Size = new System.Drawing.Size(128, 17);
            this.cbRubber.TabIndex = 27;
            this.cbRubber.Text = "ยางลบ 2.50 บาท/ก้อน";
            this.cbRubber.UseVisualStyleBackColor = true;
            this.cbRubber.Click += new System.EventHandler(this.cbRubber_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(549, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 23);
            this.label17.TabIndex = 41;
            this.label17.Text = "บาท";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBook
            // 
            this.lbBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.ForeColor = System.Drawing.Color.Red;
            this.lbBook.Location = new System.Drawing.Point(404, 288);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(130, 23);
            this.lbBook.TabIndex = 40;
            this.lbBook.Text = "0.00";
            this.lbBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(343, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 23);
            this.label19.TabIndex = 39;
            this.label19.Text = "เล่ม";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBook
            // 
            this.tbBook.Location = new System.Drawing.Point(216, 291);
            this.tbBook.MaxLength = 3;
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(121, 20);
            this.tbBook.TabIndex = 38;
            this.tbBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBook_KeyPress);
            this.tbBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBook_KeyUp);
            // 
            // cbBook
            // 
            this.cbBook.AutoSize = true;
            this.cbBook.Location = new System.Drawing.Point(60, 294);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(121, 17);
            this.cbBook.TabIndex = 37;
            this.cbBook.Text = "สมุด 10.25 บาท/เล่ม";
            this.cbBook.UseVisualStyleBackColor = true;
            this.cbBook.Click += new System.EventHandler(this.cbBook_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 505);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 42;
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
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(618, 26);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(151, 67);
            this.btMainMenu.TabIndex = 14;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(93, 337);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 23);
            this.label23.TabIndex = 43;
            this.label23.Text = "ส่วนลด";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Items.AddRange(new object[] {
            "ส่วนลด 5%",
            "ส่วนลด 10%",
            "ส่วนลด 15%"});
            this.cbbSale.Location = new System.Drawing.Point(216, 339);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(121, 21);
            this.cbbSale.TabIndex = 44;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.cbbSale);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbRuler);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbRuler);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbRubber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbRubber);
            this.Controls.Add(this.cbRubber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPencil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPencil);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbPen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSAUShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอ SAU Shop - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAUShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPencil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPencil;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbRuler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRuler;
        private System.Windows.Forms.CheckBox cbRuler;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRubber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRubber;
        private System.Windows.Forms.CheckBox cbRubber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.CheckBox cbBook;
        private System.Windows.Forms.Label lbShowTotalPay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbbSale;
        private System.Windows.Forms.Timer timer1;
    }
}