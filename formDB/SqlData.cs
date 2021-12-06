using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace formDB
{
    class SqlData
    {
        //declaration des objets sql 
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        // declaratio de methode conncter
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken) 
            {
                con.ConnectionString = @"Data Source=DESKTOP-ELA70I7\SQLEXPRESS;Initial Catalog=DOSSIER;Integrated Security=True";
                con.Open();
            }
        }
        //declration de deconnecter 
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //public void LOADDATA()
        //{
        //    cmd.CommandText = "select * from INFO";
        //    cmd.Connection = con;
        //    dr = cmd.ExecuteReader();
        //    dt.Load(dr);

        //}
//        public int existe(string CIN1)
//        {
//            int cpt;
//            cmd.CommandText = "select count(CIN) FROM INFO WHERE CIN ='" + CIN1 + "'";
//            cmd.Connection = con;
//            cpt = (int)cmd.ExecuteScalar();
//            return cpt;
//        }
//        public bool AJOUTER(string CIN1, string NOM1, string PRENOM1)
//        {
//            if (existe(CIN1) == 0)
//            {

//                cmd.CommandText = "insert into INFO values ('" + CIN1 + "','" + NOM1 + "','" + PRENOM1 + "')";
//                cmd.Connection = con;
//                cmd.ExecuteNonQuery();
//                return true;
//            }
//            return false;
//        }
//        public bool SUPRIMER(string CIN1)
//        {
//            if (existe(CIN1) == 0)
//            {

//                cmd.CommandText = "DELETE from INFO where CIN='" + CIN1 + "')";
//                cmd.Connection = con;
//                cmd.ExecuteNonQuery();
//                return true;
//            }
//            return false;
//        }
//        public bool MODIFIER(string CIN1, string NOM1, string PRENOM1)
//        {
//            if (existe(CIN1) == 0)
//            {

//                cmd.CommandText = "UPdate INFO   set CIN='" + CIN1 + "',NOM='" + NOM1 + "',PRENOM'" + PRENOM1 + "'";
//                cmd.Connection = con;
//                cmd.ExecuteNonQuery();
//                return true;
//            }
//            return false;
//        }
    }
}
