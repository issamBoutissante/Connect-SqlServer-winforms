using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace connectionToDataBase
{
    internal partial class Form1 : Form
    {
        readonly string dataBase = "data sourc e= . ; database = Volavion; integrated security = SSPI";
        SqlConnection mon_Connection;
        public Form1()
        {
            InitializeComponent();
            mon_Connection = new SqlConnection(dataBase);

            Afficher_Etat();
        }

        private void Ouvrire_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                mon_Connection.Open();
                Afficher_Etat();
            }
            catch
            {
                Console.WriteLine("il ya un problem");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mon_Connection.State.ToString() != "Open") return;
                mon_Connection.Close();
                Afficher_Etat();
        }
        private void Afficher_Etat()
        {
            Etat_de_Connection.Text = "L'etat de connection est : "+mon_Connection.State;
        }
    }
}
