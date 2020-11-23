﻿using Projet231120.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet231120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ville v1 = new Ville(1, "Lannion", 22300);
            Ville v2 = new Ville(2, "Quimper", 29000);
            Ville v3 = new Ville(3, "Rennes", 35000);
            Ville v4 = new Ville(4,"Paris",75000);
            Ville v5 = new Ville(5,"Plugufan",2970);
            Box b1 = new Box(1, "3 rue des potiers0", 15, 45);
            Box b2 = new Box(2, "35 rue Charles DeGaulle", 45, 85);
            Box b3 = new Box(3, "130 route de bénodet", 16, 23);
            Box b4 = new Box(4, "11 rue des chateuax", 96, 45);
            Box b5 = new Box(5, "13 rue du Vendrdi", 135, 15);

            Colis c1 = new Colis(1, "15");
            Colis c2 = new Colis(2, "23");
            Colis c3 = new Colis(3, "54");
            Colis c4 = new Colis(4, "95");
            Colis c5 = new Colis(5, "250");
            Colis c6 = new Colis(6, "145");
            Colis c7 = new Colis(7, "159");
            Colis c8 = new Colis(8, "155");
            Colis c9 = new Colis(9, "1");
            Colis c10 = new Colis(10, "26");
            Colis c11 = new Colis(11, "45");
            Colis c12 = new Colis(12, "12");
            Colis c13 = new Colis(13, "56");
            Colis c14 = new Colis(14, "5");
            Colis c15 = new Colis(15, "19");
            Compartiment co1 = new Compartiment(1, 15, 65, b1);
            Compartiment co2 = new Compartiment(2, 14, 65, b1);
            Compartiment co3 = new Compartiment(3, 13, 45, b2);
            Compartiment co4 = new Compartiment(4, 12, 45, b2);
            Compartiment co5 = new Compartiment(5, 11, 65, b3);
            Compartiment co6 = new Compartiment(6, 10, 45, b3);
            Compartiment co7 = new Compartiment(7, 9, 65, b4);
            Client p1 = new Professionnel(15, 18, "Lusven",1,"Galaad","impasse du pommier blanc",v2,15,48);
            Client p2 = new Individuel(15, "Trottmann", 3, "Florent", "CharlesDeGaule", v5, 15, 46);
            Client p3 = new Professionnel(85, 15, "Garnier", 2, "Malo", "VersRennes", v3, 48, 85);
            Client p4 = new Individuel(55, "Herve", 4, "Quentin", "AuLycée", v1, 74, 12);
            Client p5 = new Professionnel(52, 15, "Besnard", 5, "Damien", "AuLycée", v1, 45, 62);
            Livreur l1 = new Livreur(1, "Corson", "Kylian");
            Livreur l2 = new Livreur(2, "Henaff", "Melvin");
            Livreur l3 = new Livreur(3,"Marmonnier","Adrien");
            Livreur l4 = new Livreur(4, "Girardin", "Raoul");
            v1.LesBox.Add(b1);
            v2.LesBox.Add(b2);
            v1.LesBox.Add(b3);
            v2.LesBox.Add(b4);
            v3.LesBox.Add(b5);
            v3.LesBox.Add(b1);
            v4.LesBox.Add(b2);
            v4.LesBox.Add(b3);
            v5.LesBox.Add(b4);
            v5.LesBox.Add(b5);

            co1.LesColis.Add(c1);
            co1.LesColis.Add(c2);
            co2.LesColis.Add(c3);
            co2.LesColis.Add(c4);
            co3.LesColis.Add(c5);
            co3.LesColis.Add(c6);
            co4.LesColis.Add(c7);
            co4.LesColis.Add(c8);
            co5.LesColis.Add(c9);
            co5.LesColis.Add(c10);
            co6.LesColis.Add(c11);
            co6.LesColis.Add(c12);
            co7.LesColis.Add(c13);
            co7.LesColis.Add(c14);

            b1.LesCompartiments.Add(co1);
            b1.LesCompartiments.Add(co2);
            b2.LesCompartiments.Add(co3);
            b2.LesCompartiments.Add(co4);
            b3.LesCompartiments.Add(co5);
            b3.LesCompartiments.Add(co6);
            b4.LesCompartiments.Add(co7);

            b1.LesLivreur.Add(l1);
            b1.LesLivreur.Add(l2);
            b2.LesLivreur.Add(l3);
            b2.LesLivreur.Add(l3);
            b3.LesLivreur.Add(l2);
            b3.LesLivreur.Add(l1);
            b4.LesLivreur.Add(l4);

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {

        }
        private void RemplirDGV(Ville param)
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("ID", typeof(int));
            d1.Columns.Add("Nom", typeof(string));
            d1.Columns.Add("Code Postal", typeof(int));
            dgvBox.Refresh();
            foreach(Ville unVille in Ville.GetAllVille)
            {
                new Ville(d1.Rows.Add())
            }
        }
    }
}
