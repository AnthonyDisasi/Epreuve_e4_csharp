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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TableNiveau niveau = new TableNiveau();
            for(int i = 0; i < niveau.GetAll().Count; i++)
            {
                niveauLabel.Items.Add(niveau.GetAll()[i].GetNiveauScolaire());
                niveauLabel.Tag = niveau.GetAll()[i].GetId(); ;
            }
        

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void parcourirButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
          
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            parcourirLabel.Text = openFileDialog1.FileName;
        }

        private void LancerIntegration_Click(object sender, EventArgs e)
        { 
            PassWordType choixPass;
            lesEleves lesEleves = new lesEleves();
            TableEleve tableEleve = new TableEleve();
            TableClasse tableClasse = new TableClasse();
           Classe classe = new Classe(1,Convert.ToInt32(niveauLabel.Tag.ToString()), anneeScolaire.Text);
            tableClasse.Insert(classe);
            if (Aleatoire.Checked == true)
                choixPass = PassWordType.Aleatoire;
            else
            {
                choixPass = PassWordType.Construit;
            }
            lesEleves.LoadCsv(choixPass,parcourirLabel.Text);
            lesEleves.CreateCsvPasswordFile();
            for(int i = 0; i < lesEleves.GetEleves().Count();i++)
            {
                tableEleve.Insert(lesEleves.GetEleves()[i]);
            }
            MessageBox.Show("reussi");
            
           // TableEnseignant tableEnseignant = new TableEnseignant();
            //Enseignant unEnseignant = tableEnseignant.GetByLogin("ranikharsa@outlook.fr");
            //TableClasse tableClasse=new Classe(unEnseignant.GetId(),niveauLabel)
        }

   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
