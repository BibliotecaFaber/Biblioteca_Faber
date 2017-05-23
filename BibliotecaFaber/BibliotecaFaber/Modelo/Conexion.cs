using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber.Modelo {
    class Conexion {
        private SQLiteConnection sqlite;

        public Conexion() {
            sqlite = new SQLiteConnection(@"Data Source=C:\db\biblio.db");
        }
        public DataTable getQuery(string query) {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            } catch (SQLiteException ex) {
                //Add your exception code here.
                MessageBox.Show ("Exception: " + ex);
            }
            sqlite.Close();
            return dt;
        }

        public void sendQuery(string query) {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                cmd.ExecuteNonQuery();
            } catch (SQLiteException ex) {
                //Add your exception code here.
                MessageBox.Show ("El cliente ya se encuentra en la base de datos.");
            }
            sqlite.Close();
        }

    }
}
