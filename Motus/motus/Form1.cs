using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motus
{
    public partial class frmMotus : Form
    {

        Byte compteur , nbCols;
        String motCache , motPropose;
        char[] tabMotCache;

        public frmMotus()
        {
            InitializeComponent();

    }

        private void cbxnbLettres_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tbxProposition.Text = "";
            tbxProposition.MaxLength = Convert.ToInt32(cbxnbLettres.SelectedItem);
            
            dgvMotus.RowCount = 7;
            dgvMotus.ColumnHeadersVisible = false;
            dgvMotus.RowHeadersVisible = false;
          
            nbCols = Convert.ToByte(cbxnbLettres.SelectedItem);
            tbxProposition.MaxLength = nbCols;
            dgvMotus.ColumnCount = nbCols;
            dgvMotus.Width = nbCols * 40+3;
            dgvMotus.Height = 7 * 40 + 3;
            for(int i = 0; i < nbCols; i++)
            {
                dgvMotus.Columns[i].Width = 40;
            }
            for (int j = 0; j < 7; j++)
            {
                dgvMotus.Rows[j].Height = 40;
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxProposition_TextChanged(object sender, EventArgs e)
        {
            if (tbxProposition.TextLength == Convert.ToInt32(cbxnbLettres.SelectedItem))
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void frmMotus_Load(object sender, EventArgs e)
        {
            dgvMotus.ClearSelection();
            for (int i = 0; i < 2; i++)
            {
                Single nbLettres;
                nbLettres = (8+i);
                cbxnbLettres.Items.Add(nbLettres);
            }
            cbxnbLettres.SelectedIndex = 0;
            
            tbxProposition.CharacterCasing = CharacterCasing.Upper;
        }

        private void tbxProposition_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (((int)e.KeyCode >= 1 && (int)e.KeyCode <= 7)
            || ((int)e.KeyCode >= 9 && (int)e.KeyCode <= 36)
            || ((int)e.KeyCode >= 40 && (int)e.KeyCode <= 45)
            || ((int)e.KeyCode >= 47 && (int)e.KeyCode <= 64)
            || ((int)e.KeyCode == 38)
            || ((int)e.KeyCode > 90))
            {
                e.SuppressKeyPress = true;
            }

        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            tbxProposition.Enabled = true;
            btnNouvellePartie.Enabled = false;
            btnAnnuler.Enabled = true;
            cbxnbLettres.Enabled = false;
            lblLose.Text = "";
            

            string path = "..\\..\\..\\" ;
            string nomFichier = "mots" + cbxnbLettres.SelectedItem + ".txt";
            path = path + nomFichier;
            Random tirage = new Random();

            int nbMots = File.ReadAllLines(path).Count();

            string[] lesLignes = File.ReadAllLines(path);

            int positionMot = tirage.Next(0, nbMots);

            motCache = lesLignes[positionMot];


            MessageBox.Show(motCache);
            compteur = 0;
            dgvMotus.DataSource = null;
             
            for(int i = 0; i < 7; i++)
            {
                for(int j=0;j< nbCols; j++)
                {                   
                    dgvMotus[j,i].Value = "";
                    dgvMotus[j, i].Style.BackColor = Color.White;

                }
            }
            dgvMotus[0, 0].Value = motCache[0];
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbxProposition.Enabled = false;
            btnValider.Enabled = false;
            btnAnnuler.Enabled = false;
            tbxProposition.Text = " ";
            btnNouvellePartie.Enabled = true;
            cbxnbLettres.Enabled = true;
            lblLose.Text = "Partie annulée." ;
        }

        private void dgvMotus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Boolean victoire = false;
            motPropose = tbxProposition.Text;
            char[] tabMotPropose  ;
            
            char[] tabLettrePrise;

            tabMotPropose = motPropose.ToCharArray();
            tabMotCache = motCache.ToCharArray();
            tabLettrePrise = motCache.ToCharArray();
            tbxProposition.Text = "";
            


            for(int j=0; j <nbCols; j++)
            {
                dgvMotus[j, compteur].Value = motPropose[j];

                if (tabMotPropose[j] == tabLettrePrise[j])
                {
                    tabLettrePrise[j] = Convert.ToChar(0);
                    tabMotPropose[j] = Convert.ToChar(1);
                    dgvMotus[j, compteur].Style.BackColor = Color.Red;
                }            
            }

            for (int j = 0; j < nbCols; j++)
            {
                for (int i = 0; i < nbCols; i++)
                {
                    if (tabMotPropose[j] == tabLettrePrise[i])
                    {
                        tabLettrePrise[i] = Convert.ToChar(0);
                        tabMotPropose[j] = Convert.ToChar(1);
                        dgvMotus[j, compteur].Style.BackColor = Color.Yellow;
                    }
                }
            }



            if (motCache == motPropose)
            {
                victoire = true;
                lblLose.Text = "Victoire, vous avez bien trouvé le mot: " + motCache;
                btnNouvellePartie.Enabled = true;
            }
            


            if (compteur == 7)
            {
                btnValider.Enabled = false;
            }
            if (compteur == 6 && victoire == false)
            {
                lblLose.Text = "Vous avez perdu, le mot était: " + motCache;
                btnNouvellePartie.Enabled = true;
            }


           compteur++;

            //dgvMotus[0,0].Value = motCache;
        }
    }
 }

