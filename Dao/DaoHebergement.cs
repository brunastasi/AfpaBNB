using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DaoHebergement : DataAccess
    {
        public DaoHebergement() : base()
        {

        }

        public List<Hebergement> GetHebergements()
        {
            List<Hebergement> hebergements = null;

            try
            {

                base.GetDataReader("sp_getHebergements", null);

                if (base.sqlDataReader.HasRows)
                    hebergements = new List<Hebergement>();

                while (base.sqlDataReader.Read())
                {
                    int idhebergement = Convert.ToInt32(sqlDataReader["IdHebergement"]);
                    string nom = sqlDataReader["Nom"].ToString();
                    string photo = sqlDataReader["Photo"].ToString();
                    string type = sqlDataReader["Type"].ToString();
                    string description = sqlDataReader["Description"].ToString();
                    int idclient = Convert.ToInt32(sqlDataReader["IdClient"]);



                    Hebergement hebergement = new Hebergement();
                    hebergement.IdHebergement = idhebergement;
                    hebergement.Nom = nom;
                    hebergement.Photo = photo;
                    hebergement.Type = type;
                    hebergement.Description = description;
                    hebergement.IdClient = idclient;

                    hebergement.adresse = new Adresse();
                    hebergement.adresse.Numero = sqlDataReader["Numero"].ToString();
                    hebergement.adresse.Voie = sqlDataReader["Voie"].ToString();
                    hebergement.adresse.CodePostal = Convert.ToInt32(sqlDataReader["CodePostal"]);
                    hebergement.adresse.Ville = sqlDataReader["Ville"].ToString();

                    hebergement.reservation = new Reservation();
                    hebergement.reservation.Prix = Convert.ToDecimal(sqlDataReader["Prix"]);
                    //hebergement.reservation.DateReservation = Convert.ToDateTime(sqlDataReader["DateReservation"]);


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

        public bool createHebergement(int idclient, string nomhebergement, string photo, string type, string description, string nomadresse, string numero, string voie, string ville, string codepostal, int nbeParameter)
        {
            bool isError = false;
            string errorMsg = "";
            base.nbeParameter = nbeParameter;

            try
            {
                this.sqlParameters = new SqlParameter[nbeParameter];
                base.AddParameters("@IdClient", idclient.ToString());

                base.AddParameters("@NomHebergement", nomhebergement.ToString());

                base.AddParameters("@Photo", photo.ToString());
                base.AddParameters("@Type", type);
                base.AddParameters("@Description", description.ToString());

                base.AddParameters("@NomAdresse", nomadresse.ToString());
                base.AddParameters("@Numero", numero.ToString());

                base.AddParameters("@Voie", voie.ToString());
                base.AddParameters("@Ville", ville.ToString());
                base.AddParameters("@CodePostal", codepostal.ToString());

                base.executeQuery("sp_AddHebergement");

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