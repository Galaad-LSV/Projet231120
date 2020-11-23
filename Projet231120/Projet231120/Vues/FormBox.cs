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
            Ville v1 = new Ville(1, "Lannion", 22300);
            Ville v2 = new Ville(2, "Quimper", 29000);
            Ville v3 = new Ville(3, "Rennes", 35000);
            Ville v4 = new Ville(4, "Paris", 75000);
            Ville v5 = new Ville(5, "Plugufan", 2970);
            Models.Box b1 = new Models.Box(1, "3 rue des potiers0", 15, 45);
            Models.Box b2 = new Models.Box(2, "35 rue Charles DeGaulle", 45, 85);
            Models.Box b3 = new Models.Box(3, "130 route de bénodet", 16, 23);
            Models.Box b4 = new Models.Box(4, "11 rue des chateuax", 96, 45);
            Models.Box b5 = new Models.Box(5, "13 rue du Vendrdi", 135, 15);
            Models.Box b6 = new Models.Box(6, "5 carrefour de apex", 18, 9);
            Models.Box b7 = new Models.Box(7, "1 Rue du Valhalla", 48, 65);
            Models.Box b8 = new Models.Box(8, "45 rue des chouxFleurs", 78, 2);
            Models.Box b9 = new Models.Box(9, "95 alle de la sonnerie", 96, 4);
            Models.Box b10 = new Models.Box(10, "7 rue du soixantedixmoinsun", 2, 6);
            Models.Colis c1 = new Models.Colis(1, "15");
            Models.Colis c2 = new Models.Colis(2, "23");
            Models.Colis c3 = new Models.Colis(3, "54");
            Models.Colis c4 = new Models.Colis(4, "95");
            Models.Colis c5 = new Models.Colis(5, "250");
            Models.Colis c6 = new Models.Colis(6, "145");
            Models.Colis c7 = new Models.Colis(7, "159");
            Models.Colis c8 = new Models.Colis(8, "155");
            Models.Colis c9 = new Models.Colis(9, "1");
            Models.Colis c10 = new Models.Colis(10, "26");
            Models.Colis c11 = new Models.Colis(11, "45");
            Models.Colis c12 = new Models.Colis(12, "12");
            Models.Colis c13 = new Models.Colis(13, "56");
            Models.Colis c14 = new Models.Colis(14, "5");
            Models.Colis c15 = new Models.Colis(15, "19");
            Models.Compartiment co1 = new Models.Compartiment(1, 15, 65, b10);
            Models.Compartiment co2 = new Models.Compartiment(2, 14, 65, b10);
            Models.Compartiment co3 = new Models.Compartiment(3, 13, 45, b9);
            Models.Compartiment co4 = new Models.Compartiment(4, 12, 45, b8);
            Models.Compartiment co5 = new Models.Compartiment(5, 11, 65, b7);
            Models.Compartiment co6 = new Models.Compartiment(6, 10, 45, b7);
            Models.Compartiment co7 = new Models.Compartiment(7, 9, 65, b8);
            Models.Compartiment co8 = new Models.Compartiment(8, 8, 64, b6);
            Models.Compartiment co9 = new Models.Compartiment(9, 7, 55, b10);
            Models.Compartiment co10 = new Models.Compartiment(10, 6, 65, b1);
            Models.Compartiment co11 = new Models.Compartiment(11, 5, 35, b4);
            Models.Compartiment co12 = new Models.Compartiment(12, 4, 25, b5);
            Models.Compartiment co13 = new Models.Compartiment(13, 3, 15, b3);
            Models.Compartiment co14 = new Models.Compartiment(14, 2, 95, b2);
            Models.Compartiment co15 = new Models.Compartiment(15, 1, 605, b2);
            Models.Compartiment co16 = new Models.Compartiment(16, 16, 165, b1);
            Models.Compartiment co17 = new Models.Compartiment(17, 17, 5, b3);
            Models.Client p1 = new Models.Professionnel(15, 18, "Lusven", 1, "Galaad", "impasse du pommier blanc", v2, 15, 48);
            Models.Client p2 = new Models.Individuel(15, "Trottmann", 3, "Florent", "CharlesDeGaule", v5, 15, 46);
            Models.Client p3 = new Models.Professionnel(85, 15, "Garnier", 2, "Malo", "VersRennes", v3, 48, 85);
            Models.Client p4 = new Models.Individuel(55, "Herve", 4, "Quentin", "AuLycée", v1, 74, 12);
            Models.Client p5 = new Models.Professionnel(52, 15, "Besnard", 5, "Damien", "AuLycée", v1, 45, 62);
            Models.Livreur l1 = new Models.Livreur(1, "Corson", "Kylian");
            Models.Livreur l2 = new Models.Livreur(2, "Henaff", "Melvin");
            Models.Livreur l3 = new Models.Livreur(3, "Marmonnier", "Adrien");
            Models.Livreur l4 = new Models.Livreur(4, "Girardin", "Raoul");
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
