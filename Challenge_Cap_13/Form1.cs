using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_Cap_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DalHelper.CriarBancoSQLite();
            DalHelper.CriarTabelaSQlite();
            InitializeComponent();
        }

        private void loginPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var salt = Guid.NewGuid().ToString();
            var psw = Password.Hash(registerPsw.Text + salt);
            DalHelper.Add(registerUser.Text, psw, salt);
            MessageBox.Show("Ok!");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var pswForm = loginPsw.Text;

            var a = DalHelper.GetUser(loginUser.Text);
            if(a.Item1 != null && a.Item1 == Password.Hash(pswForm+a.Item2))
            {
                MessageBox.Show("Valid!");
            }
            else{
                MessageBox.Show("Invalid!");
            }


        }
    }
}
