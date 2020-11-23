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
            Box b6 = new Box(6, "5 carrefour de apex", 18, 9);
            Box b7 = new Box(7, "1 Rue du Valhalla", 48,65);
            Box b8 = new Box(8, "45 rue des chouxFleurs", 78, 2);
            Box b9 = new Box(9,"95 alle de la sonnerie",96,4);
            Box b10 = new Box(10,"7 rue du soixantedixmoinsun",2,6);
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
            Compartiment co1 = new Compartiment(1, 15, 65, b10);
            Compartiment co2 = new Compartiment(2, 14, 65, b10);
            Compartiment co3 = new Compartiment(3, 13, 45, b9);
            Compartiment co4 = new Compartiment(4, 12, 45, b8);
            Compartiment co5 = new Compartiment(5, 11, 65, b7);
            Compartiment co6 = new Compartiment(6, 10, 45, b7);
            Compartiment co7 = new Compartiment(7, 9, 65, b8);
            Compartiment co8 = new Compartiment(8, 8, 64, b6);
            Compartiment co9 = new Compartiment(9, 7, 55, b10);
            Compartiment co10 = new Compartiment(10, 6, 65, b1);
            Compartiment co11 = new Compartiment(11, 5, 35, b4);
            Compartiment co12 = new Compartiment(12, 4, 25, b5);
            Compartiment co13 = new Compartiment(13, 3, 15, b3);
            Compartiment co14 = new Compartiment(14, 2, 95, b2);
            Compartiment co15 = new Compartiment(15, 1, 605, b2);
            Compartiment co16 = new Compartiment(16, 16, 165, b1);
            Compartiment co17 = new Compartiment(17, 17, 5, b3);
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

        }
    }
}
