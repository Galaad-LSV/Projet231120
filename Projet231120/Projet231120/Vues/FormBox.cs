using Projet231120.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet231120.Vues
{
    public partial class FormBox : Form
    {
        public FormBox()
        {
            InitializeComponent();
        }

        private void FormBox_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string param1 = cboVille.Text;
            Ville param2 = null;

            foreach (Ville uneVille in Ville.CollClassesVille)
            {
                if (uneVille.Id.ToString() == param1)
                {
                    param2 = uneVille;
                }
            }
            this.RemplirDGV(param2);
        }

        private void RemplirDGV(Ville param)
        {
            DataTable d1 = new DataTable();

            d1.Columns.Add("Id", typeof(int));
            d1.Columns.Add("Adresse", typeof(string));
            d1.Columns.Add("Ville", typeof(string));
            d1.Columns.Add("Code Postal", typeof(int));

            dgvBox.Refresh();

            foreach (Models.Box unBox in param.GetAllBox())
            {
                foreach(Models.Ville uneVille in Ville.CollClassesVille)
                {
                    d1.Rows.Add(unBox.Id, unBox.Adresse, uneVille.Nom, uneVille.CodePostal);
                }
               
            }
            dgvBox.DataSource = d1;
        }
    }
}
