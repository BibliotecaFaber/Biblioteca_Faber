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
        private SQLiteConnection Sqlite;

        public Conexion() {
            Sqlite = new SQLiteConnection(@"Data Source=C:\db\biblio.db");
        }

        

        public DataTable getQuery(string query) {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try {
                SQLiteCommand cmd;
                Sqlite.Open();  //Initiate connection to the db
                cmd = Sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            } catch (SQLiteException ex) {
                //Add your exception code here.
                MessageBox.Show ("Exception: " + ex);
            }
            Sqlite.Close();
            return dt;
        }

        public void sendQuery(string query) {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try {
                SQLiteCommand cmd;
                Sqlite.Open();  //Initiate connection to the db
                cmd = Sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                cmd.ExecuteNonQuery();
            } catch (SQLiteException ex) {
                //Add your exception code here.
                if (query.Contains ("INSERT") && query.Contains ("CLIENTE")) {
                    MessageBox.Show ("El cliente ya se encuentra en la base de datos.");
                } else if (query.Contains ("INSERT") && query.Contains ("LIBRO")) {
                    MessageBox.Show ("El libro ya se encuentra en la base de datos.");
                } else if (query.Contains ("INSERT") && query.Contains ("PRESTAMO")) {
                    MessageBox.Show ("El prestamo ya se encuentra en la base de datos.");
                } else if (query.Contains ("UPDATE") && query.Contains ("CLIENTE")) {
                    MessageBox.Show ("No se ha podido realizar la modificación al cliente" +
                        " porque no existe en la base de datos.");
                } else if (query.Contains ("UPDATE") && query.Contains ("LIBRO")) {
                    MessageBox.Show ("No se ha podido realizar la modificación al libro" +
                        " porque no existe en la base de datos.");
                } else if (query.Contains ("UPDATE") && query.Contains ("PRESTAMO")) {
                    MessageBox.Show ("No se ha podido modificar el prestamo porque no existe" +
                        " en la base de datos.");
                } else if (query.Contains ("DELETE") && query.Contains ("CLIENTE")) {
                    MessageBox.Show ("No se ha podido eliminar el cliente porque " +
                        "no se encuentra en la base de datos.");
                } else if (query.Contains ("DELETE") && query.Contains ("LIBRO")) {
                    MessageBox.Show ("No se ha podido eliminar el libro.");
                } else if (query.Contains ("DELETE") && query.Contains ("PRESTAMO")) {
                    MessageBox.Show ("No se ha podido eliminar el prestamo.");
                }
            }
            Sqlite.Close();
        }

    }
}
