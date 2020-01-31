using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DaoReservation : DataAccess
    {
        public DaoReservation() : base()
        {

        }

        public List<Hebergement> GetReservation(int idclient, int nbeParameter)
        {
            List<Hebergement> hebergements = null;

            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());


                base.GetDataReader("sp_getReservation", sqlParameters);


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

        public bool createReservation(int idclient, int idhebergement, int nbeParameter)
        {
            bool isError = false;
            string errorMsg = "";
            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());
                base.AddParameters("@IdHebergement", idhebergement.ToString());

                base.executeQuery("sp_AddReservation");

                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                isError = true;
                errorMsg = ex.Message;
            }
            return isError;
        }

        public List<Hebergement> DelReservation(int idclient, int idhebergement)
        {
            List<Hebergement> hebergements = null;

            try
            {
                this.sqlParameters = new SqlParameter[2];
                base.AddParameters("@IdClient", idclient.ToString());
                base.AddParameters("@IdHebergement", idhebergement.ToString());


                base.GetDataReader("sp_DelReservation", sqlParameters);

                base.sqlDataReader.Close();
                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return hebergements;
        }

        public bool createAvis(int idclient, int idhebergement, decimal note, string commentaire, bool etat, int nbeParameter)
        {
            bool isError = false;
            string errorMsg = "";
            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());
                base.AddParameters("@IdHebergement", idhebergement.ToString());
                base.AddParameters("@Note", note.ToString());
                base.AddParameters("@Commentaire", commentaire.ToString());
                base.AddParameters("@Etat", etat.ToString());

                base.executeQuery("sp_AddAvi");

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