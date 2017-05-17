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
        public DataTable selectQuery(string query) {
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
            }
            sqlite.Close();
            return dt;
        }
    }
}
