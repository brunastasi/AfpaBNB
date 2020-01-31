using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DaoFavoris : DataAccess
    {
        public DaoFavoris() : base()
        {

        }

        public List<Hebergement> GetFavoris(int idclient, int nbeParameter)
        {
            List<Hebergement> hebergements = null;

            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());


                base.GetDataReader("sp_getFavoris", sqlParameters);


                if (base.sqlDataReader.HasRows)
                    hebergements = new List<Hebergement>();

                while (base.sqlDataReader.Read())
                {
                    int idhebergement = Convert.ToInt32(sqlDataReader["IdHebergement"]);
                    string nom = sqlDataReader["Nom"].ToString();
                    string photo = sqlDataReader["Photo"].ToString();
                    string type = sqlDataReader["Type"].ToString();
                    string description = sqlDataReader["Description"].ToString();


                    Hebergement hebergement = new Hebergement();
                    hebergement.IdHebergement = idhebergement;
                    hebergement.Nom = nom;
                    hebergement.Photo = photo;
                    hebergement.Type = type;
                    hebergement.Description = description;

                    hebergements.Add(hebergement);
                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return hebergements;
        }

        public bool createFavoris(int idclient, int idhebergement, int nbeParameter)
        {
            bool isError = false;
            string errorMsg = "";
            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());
                base.AddParameters("@IdHebergement", idhebergement.ToString());

                base.executeQuery("sp_AddFavoris");

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                isError = true;
                errorMsg = ex.Message;
            }
            return isError;
        }

        public List<Hebergement> DelFavoris(int idclient, int idhebergement)
        {
            List<Hebergement> hebergements = null;

            try
            {
                this.sqlParameters = new SqlParameter[2];
                base.AddParameters("@IdClient", idclient.ToString());
                base.AddParameters("@IdHebergement", idhebergement.ToString());


                base.GetDataReader("sp_DelFavoris", sqlParameters);

                base.sqlDataReader.Close();
                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return hebergements;
        }
    }
}