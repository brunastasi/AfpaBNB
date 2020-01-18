using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DataAccess
    {
        public SqlConnection sqlConnection;
        public SqlDataReader sqlDataReader;
        public SqlParameter[] sqlParameters;
        public string ErrorMsg { get; set; }

        public int nbeParameter { get; set; }
        protected int count;

        public DataAccess()
        {
            // On définit la chaine de connection a la base
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=AfpaBNB;Integrated Security=True";

            // Objet pour se connecter à la base de donnée
            sqlConnection = new SqlConnection(connectionString);

            nbeParameter = 0;
            count = 0;

        }

        public bool GetDataReader(string sqlQuery, SqlParameter[] sqlParameters)
        {
            //Objet pour executer la requête
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlDataReader = null;
            bool isError = false;

            try
            {
                // On se connecte a la BDD
                sqlConnection.Open();

                if (sqlParameters != null && sqlParameters.Length > 0)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                }

                // On éxecute l'opération SQL qui nous renvois un tableau
                // Les données sont stockés dans un objet type DataReader
                sqlDataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                isError = true;
                ErrorMsg = ex.Message;
                throw ex;
            }
            finally
            { 
                            
            }
            count = 0;
            return isError;

        }

        public bool executeQuery(string sqlQuery)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            string errorMsg = "";
            bool isError = false;

            try
            {
                sqlConnection.Open();

                if (sqlParameters != null && sqlParameters.Length > 0)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                }
                sqlCommand.ExecuteNonQuery();
                count = 0;

            }

            catch (Exception ex)
            {
                isError = true;
                errorMsg = ex.Message;
            }
            return isError;

        }

        public void AddParameters(string Nom, string value)
        {
            sqlParameters[count] = new SqlParameter(Nom, value);
            count++;
        }
    }
}