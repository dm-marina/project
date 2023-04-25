using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdersApplication
{
    public partial class CreateOrder : Form
    {
        private Order _order;
        public CreateOrder(int id)
        {
            InitializeComponent();
            _order = new Order(id);
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            orderIdLabel.Text = _order.id.ToString();
        }

        private void addItemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderItemsCheckedListBox.CheckedItems.Count != 0)
                {
                    for (int checkedItem = 0; checkedItem <= 
                        orderItemsCheckedListBox.CheckedItems.Count - 1; checkedItem++)
                    {
                        _order.AddItem
                            (orderItemsCheckedListBox.CheckedItems[checkedItem].ToString());
                    }

                }
                totalItemsLabel.Text = _order.TotalItems.ToString();
            }
            catch
            {
                MessageBox.Show("Error adding items.","Items error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}