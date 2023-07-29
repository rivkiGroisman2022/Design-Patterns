namespace DesigenPatternsAvigailAndRivkiKafirerya
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
            this.lblorder = new System.Windows.Forms.Label();
            this.lblnewClient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbClub = new System.Windows.Forms.CheckBox();
            this.btnStartInvite = new System.Windows.Forms.Button();
            this.cbChoklate = new System.Windows.Forms.CheckBox();
            this.cbFruits = new System.Windows.Forms.CheckBox();
            this.cbPekan = new System.Windows.Forms.CheckBox();
            this.cbCookies = new System.Windows.Forms.CheckBox();
            this.lblPutOn = new System.Windows.Forms.Label();
            this.btnAddWaffle = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.rbSqure = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbShoko = new System.Windows.Forms.RadioButton();
            this.rbOrangeJuice = new System.Windows.Forms.RadioButton();
            this.rbLimonada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblWaffle = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.dgvShowOrder = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbNewOrder = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbSearchOrder = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtClientPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).BeginInit();
            this.gbNewOrder.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.gbSearchOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Location = new System.Drawing.Point(366, 45);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(0, 20);
            this.lblorder.TabIndex = 0;
            // 
            // lblnewClient
            // 
            this.lblnewClient.AutoSize = true;
            this.lblnewClient.Location = new System.Drawing.Point(69, 38);
            this.lblnewClient.Name = "lblnewClient";
            this.lblnewClient.Size = new System.Drawing.Size(76, 20);
            this.lblnewClient.TabIndex = 1;
            this.lblnewClient.Text = "new client";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(218, 77);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "phone number:";
            // 
            // tbname
            // 
            this.tbname.HideSelection = false;
            this.tbname.Location = new System.Drawing.Point(95, 77);
            this.tbname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(114, 27);
            this.tbname.TabIndex = 4;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(351, 77);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(114, 27);
            this.tbPhone.TabIndex = 5;
            // 
            // cbClub
            // 
            this.cbClub.AutoSize = true;
            this.cbClub.Location = new System.Drawing.Point(528, 83);
            this.cbClub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(94, 24);
            this.cbClub.TabIndex = 6;
            this.cbClub.Text = "have club";
            this.cbClub.UseVisualStyleBackColor = true;
            // 
            // btnStartInvite
            // 
            this.btnStartInvite.Location = new System.Drawing.Point(640, 77);
            this.btnStartInvite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartInvite.Name = "btnStartInvite";
            this.btnStartInvite.Size = new System.Drawing.Size(86, 31);
            this.btnStartInvite.TabIndex = 7;
            this.btnStartInvite.Text = "start invite";
            this.btnStartInvite.UseVisualStyleBackColor = true;
            this.btnStartInvite.Click += new System.EventHandler(this.btnStartInvite_Click);
            // 
            // cbChoklate
            // 
            this.cbChoklate.AutoSize = true;
            this.cbChoklate.Location = new System.Drawing.Point(58, 144);
            this.cbChoklate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChoklate.Name = "cbChoklate";
            this.cbChoklate.Size = new System.Drawing.Size(96, 24);
            this.cbChoklate.TabIndex = 12;
            this.cbChoklate.Text = "chocolate";
            this.cbChoklate.UseVisualStyleBackColor = true;
            // 
            // cbFruits
            // 
            this.cbFruits.AutoSize = true;
            this.cbFruits.Location = new System.Drawing.Point(170, 144);
            this.cbFruits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFruits.Name = "cbFruits";
            this.cbFruits.Size = new System.Drawing.Size(58, 24);
            this.cbFruits.TabIndex = 13;
            this.cbFruits.Text = "fruit";
            this.cbFruits.UseVisualStyleBackColor = true;
            // 
            // cbPekan
            // 
            this.cbPekan.AutoSize = true;
            this.cbPekan.Location = new System.Drawing.Point(245, 145);
            this.cbPekan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPekan.Name = "cbPekan";
            this.cbPekan.Size = new System.Drawing.Size(71, 24);
            this.cbPekan.TabIndex = 14;
            this.cbPekan.Text = "pekan";
            this.cbPekan.UseVisualStyleBackColor = true;
            // 
            // cbCookies
            // 
            this.cbCookies.AutoSize = true;
            this.cbCookies.Location = new System.Drawing.Point(318, 145);
            this.cbCookies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCookies.Name = "cbCookies";
            this.cbCookies.Size = new System.Drawing.Size(81, 24);
            this.cbCookies.TabIndex = 15;
            this.cbCookies.Text = "cookies";
            this.cbCookies.UseVisualStyleBackColor = true;
            // 
            // lblPutOn
            // 
            this.lblPutOn.AutoSize = true;
            this.lblPutOn.Location = new System.Drawing.Point(-5, 145);
            this.lblPutOn.Name = "lblPutOn";
            this.lblPutOn.Size = new System.Drawing.Size(55, 20);
            this.lblPutOn.TabIndex = 16;
            this.lblPutOn.Text = "put on:";
            this.lblPutOn.Click += new System.EventHandler(this.lblPutOn_Click);
            // 
            // btnAddWaffle
            // 
            this.btnAddWaffle.Location = new System.Drawing.Point(82, 215);
            this.btnAddWaffle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddWaffle.Name = "btnAddWaffle";
            this.btnAddWaffle.Size = new System.Drawing.Size(182, 31);
            this.btnAddWaffle.TabIndex = 21;
            this.btnAddWaffle.Text = "add waffle ro invetation";
            this.btnAddWaffle.UseVisualStyleBackColor = true;
            this.btnAddWaffle.Click += new System.EventHandler(this.btnAddWaffle_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(438, 215);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(193, 31);
            this.btnAddDrink.TabIndex = 22;
            this.btnAddDrink.Text = "add drink to invetatiov";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(270, 301);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(139, 31);
            this.btnFinish.TabIndex = 23;
            this.btnFinish.Text = "finish invetation";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // rbSqure
            // 
            this.rbSqure.AutoSize = true;
            this.rbSqure.Location = new System.Drawing.Point(36, 84);
            this.rbSqure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSqure.Name = "rbSqure";
            this.rbSqure.Size = new System.Drawing.Size(66, 24);
            this.rbSqure.TabIndex = 26;
            this.rbSqure.TabStop = true;
            this.rbSqure.Text = "squre";
            this.rbSqure.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(144, 84);
            this.rbCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(65, 24);
            this.rbCircle.TabIndex = 27;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Location = new System.Drawing.Point(456, 80);
            this.rbCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(72, 24);
            this.rbCoffee.TabIndex = 28;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "coffee";
            this.rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbShoko
            // 
            this.rbShoko.AutoSize = true;
            this.rbShoko.Location = new System.Drawing.Point(456, 113);
            this.rbShoko.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbShoko.Name = "rbShoko";
            this.rbShoko.Size = new System.Drawing.Size(69, 24);
            this.rbShoko.TabIndex = 29;
            this.rbShoko.Text = "shoko";
            this.rbShoko.UseVisualStyleBackColor = true;
            // 
            // rbOrangeJuice
            // 
            this.rbOrangeJuice.AutoSize = true;
            this.rbOrangeJuice.Location = new System.Drawing.Point(456, 147);
            this.rbOrangeJuice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOrangeJuice.Name = "rbOrangeJuice";
            this.rbOrangeJuice.Size = new System.Drawing.Size(109, 24);
            this.rbOrangeJuice.TabIndex = 30;
            this.rbOrangeJuice.TabStop = true;
            this.rbOrangeJuice.Text = "orangeJuice";
            this.rbOrangeJuice.UseVisualStyleBackColor = true;
            // 
            // rbLimonada
            // 
            this.rbLimonada.AutoSize = true;
            this.rbLimonada.Location = new System.Drawing.Point(456, 181);
            this.rbLimonada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLimonada.Name = "rbLimonada";
            this.rbLimonada.Size = new System.Drawing.Size(93, 24);
            this.rbLimonada.TabIndex = 31;
            this.rbLimonada.TabStop = true;
            this.rbLimonada.Text = "limonada";
            this.rbLimonada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Write id of order do you ";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.AliceBlue;
            this.txtState.Location = new System.Drawing.Point(759, 135);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(260, 473);
            this.txtState.TabIndex = 33;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // lblWaffle
            // 
            this.lblWaffle.AutoSize = true;
            this.lblWaffle.Location = new System.Drawing.Point(82, 56);
            this.lblWaffle.Name = "lblWaffle";
            this.lblWaffle.Size = new System.Drawing.Size(52, 20);
            this.lblWaffle.TabIndex = 34;
            this.lblWaffle.Text = "Waffle";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(417, 56);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(50, 20);
            this.lblDrinks.TabIndex = 35;
            this.lblDrinks.Text = "Drinks";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(25, 69);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(254, 43);
            this.btnNewOrder.TabIndex = 36;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(1049, 81);
            this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(254, 43);
            this.btnSearchOrder.TabIndex = 37;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(234, 81);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(228, 27);
            this.dtpOrderDate.TabIndex = 38;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(96, 80);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(114, 27);
            this.txtNameClient.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "name:";
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(348, 356);
            this.btnFinishOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(114, 31);
            this.btnFinishOrder.TabIndex = 41;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // dgvShowOrder
            // 
            this.dgvShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOrder.Location = new System.Drawing.Point(69, 133);
            this.dgvShowOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvShowOrder.Name = "dgvShowOrder";
            this.dgvShowOrder.RowHeadersWidth = 51;
            this.dgvShowOrder.RowTemplate.Height = 25;
            this.dgvShowOrder.Size = new System.Drawing.Size(274, 200);
            this.dgvShowOrder.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(219, 358);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 27);
            this.txtId.TabIndex = 43;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // gbNewOrder
            // 
            this.gbNewOrder.Controls.Add(this.groupBox1);
            this.gbNewOrder.Controls.Add(this.gbMenu);
            this.gbNewOrder.Controls.Add(this.lblnewClient);
            this.gbNewOrder.Controls.Add(this.lblName);
            this.gbNewOrder.Controls.Add(this.lblPhone);
            this.gbNewOrder.Controls.Add(this.tbname);
            this.gbNewOrder.Controls.Add(this.tbPhone);
            this.gbNewOrder.Controls.Add(this.cbClub);
            this.gbNewOrder.Controls.Add(this.btnStartInvite);
            this.gbNewOrder.Location = new System.Drawing.Point(14, 120);
            this.gbNewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNewOrder.Name = "gbNewOrder";
            this.gbNewOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNewOrder.Size = new System.Drawing.Size(767, 501);
            this.gbNewOrder.TabIndex = 48;
            this.gbNewOrder.TabStop = false;
            this.gbNewOrder.Visible = false;
            this.gbNewOrder.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 528);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(760, 93);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnAddDrink);
            this.gbMenu.Controls.Add(this.rbShoko);
            this.gbMenu.Controls.Add(this.rbCoffee);
            this.gbMenu.Controls.Add(this.rbOrangeJuice);
            this.gbMenu.Controls.Add(this.rbCircle);
            this.gbMenu.Controls.Add(this.rbLimonada);
            this.gbMenu.Controls.Add(this.rbSqure);
            this.gbMenu.Controls.Add(this.lblWaffle);
            this.gbMenu.Controls.Add(this.btnAddWaffle);
            this.gbMenu.Controls.Add(this.lblDrinks);
            this.gbMenu.Controls.Add(this.cbChoklate);
            this.gbMenu.Controls.Add(this.btnFinish);
            this.gbMenu.Controls.Add(this.lblPutOn);
            this.gbMenu.Controls.Add(this.cbFruits);
            this.gbMenu.Controls.Add(this.cbCookies);
            this.gbMenu.Controls.Add(this.cbPekan);
            this.gbMenu.Location = new System.Drawing.Point(11, 123);
            this.gbMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenu.Size = new System.Drawing.Size(715, 357);
            this.gbMenu.TabIndex = 50;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "menu";
            // 
            // gbSearchOrder
            // 
            this.gbSearchOrder.Controls.Add(this.btnSearch);
            this.gbSearchOrder.Controls.Add(this.label1);
            this.gbSearchOrder.Controls.Add(this.dtpOrderDate);
            this.gbSearchOrder.Controls.Add(this.txtId);
            this.gbSearchOrder.Controls.Add(this.label2);
            this.gbSearchOrder.Controls.Add(this.dgvShowOrder);
            this.gbSearchOrder.Controls.Add(this.txtNameClient);
            this.gbSearchOrder.Controls.Add(this.btnFinishOrder);
            this.gbSearchOrder.Location = new System.Drawing.Point(1015, 135);
            this.gbSearchOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSearchOrder.Name = "gbSearchOrder";
            this.gbSearchOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSearchOrder.Size = new System.Drawing.Size(515, 440);
            this.gbSearchOrder.TabIndex = 49;
            this.gbSearchOrder.TabStop = false;
            this.gbSearchOrder.Visible = false;
            this.gbSearchOrder.Enter += new System.EventHandler(this.gbSearchOrder_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(365, 133);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 31);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search Order";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "state:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(114, 43);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(0, 20);
            this.lblPayment.TabIndex = 3;
            // 
            // txtClientPay
            // 
            this.txtClientPay.HideSelection = false;
            this.txtClientPay.Location = new System.Drawing.Point(529, 49);
            this.txtClientPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientPay.Name = "txtClientPay";
            this.txtClientPay.Size = new System.Drawing.Size(114, 27);
            this.txtClientPay.TabIndex = 51;
            this.txtClientPay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(665, 48);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(86, 31);
            this.btnPay.TabIndex = 51;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 54;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(114, 49);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(45, 20);
            this.lblClient.TabIndex = 55;
            this.lblClient.Text = "client";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(183, 49);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(62, 20);
            this.lblOrderId.TabIndex = 56;
            this.lblOrderId.Text = "order Id";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(273, 49);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(31, 20);
            this.lblPay.TabIndex = 57;
            this.lblPay.Text = "Pay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPay);
            this.groupBox2.Controls.Add(this.lblOrderId);
            this.groupBox2.Controls.Add(this.lblClient);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.txtClientPay);
            this.groupBox2.Controls.Add(this.lblPayment);
            this.groupBox2.Location = new System.Drawing.Point(27, 633);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(768, 111);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "payment";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 757);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.gbSearchOrder);
            this.Controls.Add(this.gbNewOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblorder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).EndInit();
            this.gbNewOrder.ResumeLayout(false);
            this.gbNewOrder.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.gbSearchOrder.ResumeLayout(false);
            this.gbSearchOrder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblorder;
        private Label lblnewClient;
        private Label lblName;
        private Label lblPhone;
        private TextBox tbname;
        private TextBox tbPhone;
        private CheckBox cbClub;
        private Button btnStartInvite;
        private CheckBox cbChoklate;
        private CheckBox cbFruits;
        private CheckBox cbPekan;
        private CheckBox cbCookies;
        private Label lblPutOn;
        private Button btnAddWaffle;
        private Button btnAddDrink;
        private Button btnFinish;
        private RadioButton rbSqure;
        private RadioButton rbCircle;
        private RadioButton rbCoffee;
        private RadioButton rbShoko;
        private RadioButton rbOrangeJuice;
        private RadioButton rbLimonada;
        private Label label1;
        private TextBox txtState;
        private Label lblWaffle;
        private Label lblDrinks;
        private Button btnNewOrder;
        private Button btnSearchOrder;
        private DateTimePicker dtpOrderDate;
        private TextBox txtNameClient;
        private Label label2;
        private Button btnFinishOrder;
        private DataGridView dgvShowOrder;
        private TextBox txtId;
        private GroupBox gbNewOrder;
        private GroupBox gbSearchOrder;
        private GroupBox gbMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Label label6;
        private Label lblPayment;
        private TextBox txtClientPay;
        private Button btnPay;
        private Label label4;
        private Label label5;
        private Label lblClient;
        private Label lblOrderId;
        private Label lblPay;
        private GroupBox groupBox2;
    }
}