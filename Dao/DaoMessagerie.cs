using AFPABNB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AFPABNB.Dao
{
    public class DaoMessagerie : DataAccess
    {
        public DaoMessagerie() : base()
        {

        }

        public List<Messagerie> GetMessage(int idexpediteur, int iddestinataire)
        {
            List<Messagerie> messageries = null;

            try
            {
                this.sqlParameters = new SqlParameter[2];
                base.AddParameters("@IdExpediteur", idexpediteur.ToString());
                base.AddParameters("@IdDestinataire", iddestinataire.ToString());

                //List<SqlParameter> sqlParameters = new List<SqlParameter>();
                //sqlParameters.Add(new SqlParameter("@IdExpediteur", idexpediteur));
                //sqlParameters.Add(new SqlParameter("@IdDestinataire", iddestinataire));


                base.GetDataReader("sp_getMessages", sqlParameters.ToArray());

                if (base.sqlDataReader.HasRows)
                    messageries = new List<Messagerie>();

                while (base.sqlDataReader.Read())
                {
                    DateTime date = Convert.ToDateTime(sqlDataReader["Date"]);
                    int idMessagerie = Convert.ToInt32(sqlDataReader["IdMessagerie"]);
                    int idExpediteur = Convert.ToInt32(sqlDataReader["IdExpediteur"]);
                    int idDestinataire = Convert.ToInt32(sqlDataReader["IdDestinataire"]);
                    string messages = sqlDataReader["Messages"].ToString();
                    
                    bool statut = Convert.ToBoolean(sqlDataReader["Statut"]);

                    Messagerie messagerie = new Messagerie();
                    messagerie.IdExpediteur = idExpediteur;
                    messagerie.IdDestinataire = idDestinataire;
                    messagerie.Messages = messages;
                    messagerie.Date = date;
                    messagerie.Statut = statut;

                    messageries.Add(messagerie);
                }

                base.sqlDataReader.Close();
                base.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
            }

            return messageries;
        }

        public bool createMessage(int idexpediteur, int iddestinataire, string messages, string date, bool statut)
        {
            bool isError = false;
            string errorMsg = "";

            try
            {
                this.sqlParameters = new SqlParameter[5];
                base.AddParameters("@IdExpediteur", idexpediteur.ToString());
                base.AddParameters("@IdDestinataire", iddestinataire.ToString());
                base.AddParameters("@Messages", messages.ToString());
                base.AddParameters("@Date", date.ToString());
                base.AddParameters("@Statut", statut.ToString());

                base.executeQuery("sp_AjouterMessage");

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