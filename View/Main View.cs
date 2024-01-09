using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triplegSystem.Controller;

namespace triplegSystem.View
{
    public partial class Main_View : Form
    {
        MainController mainController = new MainController();
        public Main_View()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            var isRegistered = mainController.ChekIsRegistered(username, password);
            if (isRegistered )
            {
                LoginView l = new LoginView();
                l.Show();
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
