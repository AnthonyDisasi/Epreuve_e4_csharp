using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rallyeLecture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TableEnseignant tableEnseignant = new TableEnseignant();
            Boolean access = tableEnseignant.Access(login.Text, password.Text);
            if (access)
            {
                Form1 form1 = new Form1();
                    form1.Show();
            }
            else
            {
                MessageBox.Show("Accces Refusé","Info Connexion");
            }
          
        }
    }
}
