using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace OrdersApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(OrderIdTextBox.Text);

            // TODO: Save last order added in configuration file
            Configuration orderConfig = ConfigurationManager.OpenExeConfiguration
                (ConfigurationUserLevel.None);
            AppSettingsSection appSection = orderConfig.AppSettings;
            int lastOrder = id;

            appSection.Settings["LastOrderAdded"].Value = lastOrder.ToString();
            orderConfig.Save();
            ConfigurationManager.RefreshSection("appSettings");

            // TODO: Display last order added
            LastOrderLabel.Text = ConfigurationManager.AppSettings["LastOrderAdded"];

            OrderIdTextBox.Text = "";
            CreateOrder form = new CreateOrder(id);
            form.Show(this);
        }

       
    }
}