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

namespace Projet231120.Vues
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBox from1 = new FormBox();
            from1.Show();
            this.Hide();
        }

        private void compartimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compartiment from1 = new Compartiment();
            from1.Show();
            this.Hide();
        }

        private void colisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colis from1 = new Colis();
            from1.Show();
            this.Hide();
        }

        private void livreurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livreur from1 = new Livreur();
            from1.Show();
            this.Hide();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client from1 = new Client();
            from1.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
