using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DaoClient : DataAccess
    {
        public DaoClient() : base()
        {

        }

        public Client GetClient(string login, string password)
        {
            bool isError = false;
            string errorMsg = "";

            Client client = null;


            try
            {

                this.sqlParameters = new SqlParameter[2];
                base.AddParameters("@Login", login);
                base.AddParameters("@Password", password);

                //SqlParameter[] sqlParameters = new SqlParameter[2];

                //SqlParameter paramLogin = new SqlParameter();
                //paramLogin.ParameterName = "@login";
                //paramLogin.Value = login;
                //sqlParameters[0] = paramLogin;

                //SqlParameter paramPassword = new SqlParameter();
                //paramPassword.ParameterName = "@password";
                //paramPassword.Value = password;
                //sqlParameters[1] = paramPassword;


                base.GetDataReader("sp_getClient", sqlParameters);

                if (base.sqlDataReader.HasRows)
                {
                    client = new Client();
                }


                while (base.sqlDataReader.Read())
                {
                    int idclient = (int)sqlDataReader["IdClient"];
                    string nom = sqlDataReader["Nom"].ToString();
                    string prenom = sqlDataReader["Prenom"].ToString();

                    client.IdClient = idclient;
                    client.Nom = nom;
                    client.Prenom = prenom;

                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                isError = true;
                errorMsg = ex.Message;
                throw ex;
            }

            return client;
        }

        public bool createClient(string nom, string prenom, string numero, string voie, string ville, string codepostal, string telephone, string login, string password, string email, string type, int nbeParameter)
        {
            bool isError = false;
            string errorMsg = "";
            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@Nom", nom);
                base.AddParameters("@Prenom", prenom);
                base.AddParameters("@Login", login);
                base.AddParameters("@Password", password);
                base.AddParameters("@Email", email);
                base.AddParameters("@Type", type);
                base.AddParameters("@Telephone", telephone);

                base.AddParameters("@NomAdresse", "test");
                base.AddParameters("@Numero", numero);
                base.AddParameters("@Voie", voie);
                base.AddParameters("@Ville", ville);
                base.AddParameters("@CodePostal", codepostal);

                base.executeQuery("sp_AddClient");

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                isError = true;
                errorMsg = ex.Message;
            }
            return isError;
        }
    }
}