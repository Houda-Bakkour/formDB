using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlData d = new SqlData();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RemplirGrid()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = " select * from INFO";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirGrid();


        }
        public void VIDER(Control f)
        {
            foreach(Control ct in f.Controls)
            {
                if(ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct); 
                }
            }
        }
        public int existe()
        {
            int cpt;
            d.cmd.CommandText = "select count(CIN) FROM INFO WHERE CIN ='" + CINtxt.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int) d.cmd.ExecuteScalar();
            return cpt;
        }
        public bool AJOUTER()
        {
            if (existe() == 0)
            {

                d.cmd.CommandText = "insert into INFO values ('" + CINtxt.Text + "','" + NOMtxt.Text + "','" + PRENOMtxt.Text + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public bool SUPRIMER()
        {
            if (existe() == 0)
            {

                d.cmd.CommandText = "DELETE from INFO where CIN='" + CINtxt.Text + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public bool MODIFIER()
        {
            if (existe() == 0)
            {

                d.cmd.CommandText = "UPdate INFO   set CIN='" + CINtxt.Text + "',NOM='" + NOMtxt.Text + "',PRENOM'" + PRENOMtxt.Text + "'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    


private void BTMann_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous annuler l'operation ", "confirmation ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }


        }
        
        


        private void BTMaj_Click(object sender, EventArgs e)
        {

            
            if (CINtxt.Text == " " || NOMtxt.Text == " " || PRENOMtxt.Text == " ")
                {
                    MessageBox.Show(" merci de remplir tout les champs ");
                    return;
                }
            if (AJOUTER() == true)
            {
                MessageBox.Show(" ce students est ajouter avec succes ");
                RemplirGrid();

            }
            else
            {
                MessageBox.Show(" ce sstudent existe deja  ");
            }


        }

        private void BTMsup_Click(object sender, EventArgs e)
        {

            if (CINtxt.Text == " ")
            
                {
                    MessageBox.Show(" merci de remplir le champs ");
                    return;
                }
                if (SUPRIMER() == true)
                {
                    MessageBox.Show(" ce student est supprimer avec succes ");
                    RemplirGrid();

                }
                else
                {
                    MessageBox.Show(" ce studesnt n'existe pas  ");
                }

            



        }

        private void BTMmod_Click(object sender, EventArgs e)
        {
            if (CINtxt.Text == " " || PRENOMtxt.Text == " " || NOMtxt.Text == " ")
            {
                MessageBox.Show(" merci de remplir tout les champs ");
                return;
            }
            if (MODIFIER() == true)
            {
                MessageBox.Show(" ce student est modifier avec succes ");
                RemplirGrid();

            }
            else
            {
                MessageBox.Show(" ce student n'existe pas  ");
            }

        }
    }

        //pour avoir si student est deja ajouter ou non

    
}
    }
}
