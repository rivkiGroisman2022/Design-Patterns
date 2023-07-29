using DesigenPatternsAvigailAndRivkiKafirerya.Worker;
using DesignPatternsAvigailAndRivkiCafiterya;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    public partial class Form1 : Form
    {
        Order newOrder = null;
        Client client = null;
        List<List<int>> productsOrder = new();
        List<CheckBox> waffleDecorator = new();
        List<RadioButton> drinks = new();
        List<Order> findO = new();
        public Form1()
        {
            InitializeComponent();
            waffleDecorator.Add(cbFruits);
            waffleDecorator.Add(cbPekan);
            waffleDecorator.Add(cbCookies);
            waffleDecorator.Add(cbChoklate);
            drinks.Add(rbShoko);
            drinks.Add(rbCoffee);
            drinks.Add(rbLimonada);
            drinks.Add(rbOrangeJuice);
            gbNewOrder.Visible = false;
            groupBox2.Visible = false;
        }

        private void btnStartInvite_Click(object sender, EventArgs e)
        {
            Debug.Write("StartInvite on Form1");
            client = new(tbname.Text, tbPhone.Text, cbClub.Checked);
            gbMenu.Visible = true;
            btnFinish.Enabled = false;
        }

        private void ClearDrink()
        {
            Debug.Write("ClearDrink on Form1");
            rbCoffee.Checked = false;
            rbLimonada.Checked = false;
            rbOrangeJuice.Checked = false;
            rbShoko.Checked = false;
        }
        private void ClearClient()
        {
            Debug.Write("ClearClient on Form1");
            tbname.Text = null;
            tbPhone.Text = null;
            cbClub.Checked = false;
        }
        private void ClearWaffle()
        {
            Debug.Write("ClearWaffle on Form1");
            rbCircle.Checked = false;
            rbSqure.Checked = false;
            cbChoklate.Checked = false;
            cbCookies.Checked = false;
            cbFruits.Checked = false;
            cbPekan.Checked = false;
        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            Debug.Write("AddDrink on Form1");
            List<int> drink = new();
            drink.Add((int)ProductEnum.drink);
            bool checkIfChoose = false;
            foreach (var item in drinks)
            {
                if (item.Checked)
                {
                    checkIfChoose = true;
                    switch (item.Text)
                    {
                        case "shoko":
                            drink.Add((int)ProductEnum.hotDrink);
                            drink.Add((int)ProductEnum.shoko);
                            break;
                        case "coffee":
                            drink.Add((int)ProductEnum.hotDrink);
                            drink.Add((int)ProductEnum.coffee);
                            break;
                        case "orangeJuice":
                            drink.Add((int)ProductEnum.coldDrink);
                            drink.Add((int)ProductEnum.orangeJuice);
                            break;
                        case "limonada":
                            drink.Add((int)ProductEnum.coldDrink);
                            drink.Add((int)ProductEnum.limonada);
                            break;
                    }
                }
            }
            if (!checkIfChoose)
            {
                return;
            }
            productsOrder.Add(drink);
            btnFinish.Enabled = true;
            ClearDrink();
        }

        private void btnAddWaffle_Click(object sender, EventArgs e)
        {
            Debug.Write("AddWaffle on Form1");
            List<int> waffle = new();
            waffle.Add((int)ProductEnum.waffale);
            if (rbCircle.Checked)
            {
                waffle.Add((int)ProductEnum.circle);
            }
            else
            { waffle.Add((int)ProductEnum.square); }
            foreach (var item in waffleDecorator)
            {
                if (item.Checked)
                {
                    switch (item.Text)
                    {
                        case "chocolate":
                            waffle.Add((int)ProductEnum.chocolate);
                            break;
                        case "fruit":
                            waffle.Add((int)ProductEnum.fruit);
                            break;
                        case "cookies":
                            waffle.Add((int)ProductEnum.cookies);
                            break;
                        case "pekan":
                            waffle.Add((int)ProductEnum.pekan);
                            break;
                    }
                }
            }
            productsOrder.Add(waffle);
            btnFinish.Enabled = true;
            ClearWaffle();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Debug.Write("Finish on Form1");
            newOrder = new(client, productsOrder);
            // newOrder.SetState();
            Restaurant restaurant = Restaurant.GetInstance();
            restaurant.MyForm = this;
            restaurant.GeteWaiter().GetOrder(newOrder);
            SaveOrder(newOrder);
            ClearClient();
            gbNewOrder.Visible = false;
        }
        private void SaveOrder(Order saveOrder)
        {
            Debug.Write("SaveOrder on Form1");
            Restaurant restaurant = Restaurant.GetInstance();
            restaurant.MyComputer.Save(saveOrder);
        }

        public void State(string state)
        {
            Debug.Write("State on Form1");
            state = state + "\n";
            txtState.Text = txtState.Text + state;
        }
        public void ShowPayment(string client, double pay, int orderId)
        {
            Debug.WriteLine("ShowPayment on Form1");
            /* lblClient.Text = client;
             lblOrderId.Text = orderId.ToString();
             lblPay.Text = pay.ToString();*/
            MessageBox.Show($"pament for client {client}, order {orderId.ToString()} is {pay.ToString()}");
            Restaurant restaurant = Restaurant.GetInstance();
            restaurant.UpdateOrder(orderId);
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Debug.Write("NewOrder on Form1");
            gbNewOrder.Visible = true;
            btnStartInvite.Enabled = false;
            gbMenu.Visible = false;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            Debug.Write("SearchOrder on Form1");
            gbSearchOrder.Visible = true;
            // btnFinishOrder.Enabled = false;
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in findO)
            {
                if (item.Id == int.Parse(txtId.Text))
                {
                    newOrder = item.Clone();
                }
            }
            SaveOrder(newOrder);
            Restaurant restaurant = Restaurant.GetInstance();
            restaurant.MyForm = this;
            restaurant.GeteWaiter().GetOrder(newOrder);
            txtId.Text = null;
            dgvShowOrder.DataSource = null;
            txtNameClient.Text = null;
            gbSearchOrder.Visible = false;
        }
        private void tbname_TextChanged(object sender, EventArgs e)
        {
            if (tbname.Text != " ")
            {
                btnStartInvite.Enabled = true;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblPay.Text == txtClientPay.Text)
            {
                Restaurant restaurant = Restaurant.GetInstance();
                restaurant.UpdateOrder(int.Parse(lblOrderId.Text));
            }
            else
            {
                MessageBox.Show("not good give more/less money");
            }
            lblPay.Text = null;
            lblOrderId.Text = null;
            lblClient.Text = null;
            txtClientPay.Text = null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = Restaurant.GetInstance();
            findO = restaurant.MyComputer.FindOrders(txtNameClient.Text, dtpOrderDate.Value);
            dgvShowOrder.DataSource = null;
            dgvShowOrder.DataSource = findO;
        }

        #region by mistake
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbSearchOrder_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void lblPutOn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}