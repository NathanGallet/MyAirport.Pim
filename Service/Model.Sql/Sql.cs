using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using System.Data.SqlClient;

namespace MyAirport.Pim.Model
{
    public class Sql : AbstractDefinition
    {

        string strcnx = ConfigurationManager.ConnectionStrings["Client.Formlhm.Properties.Settings.DbConnect"].ConnectionString;

        string commandGetBagage = "SELECT B.ID_BAGAGE AS IdBagage, " +
                                  "B.CODE_IATA AS CodeIata, " +
                                  "B.COMPAGNIE AS Compagnie, " +
                                  "B.LIGNE AS Ligne, " +
                                  "B.CLASSE AS LigneAlpha, " +
                                  "B.JOUR_EXPLOITATION AS JourExploitation, " +
                                  "CONCAT( B.ESCALE, B.DESTINATION ) AS Itineraire, " +
                                  "IIF( B.CONTINUATION = 'N', cast(0 as BIT), cast(1 as BIT) ) AS Continuation, " +
                                  "IIF( BAP.ID_PARTICULARITE = 15, cast(1 as BIT), cast(0 as BIT) ) AS Rush " +
                                  "FROM [MyAirport].[dbo].[BAGAGE] B " +
                                  "LEFT JOIN [MyAirport].[dbo].[VOL] V ON B.ID_VOL = V.ID_VOL " +
                                  "LEFT JOIN [MyAirport].[dbo].[BAGAGE_A_POUR_PARTICULARITE] BAP ON B.ID_BAGAGE = BAP.ID_BAGAGE " +
                                  "LEFT JOIN [MyAirport].[dbo].[BAGAGE_PARTICULARITE] BP ON BP.ID_PART = BAP.ID_PARTICULARITE " +
                                  "WHERE B.CODE_IATA = @code;";

        /*string commandAddBagage = "INSERT INTO BAGAGE VALUES " +
                                  "('@companie', '@ligne' ,'@jourExploitation', '@itineraire', '@classeBagage'"; */


        public override BagageDefinition GetBagageByCodeIata(string CodeIata)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagage, cnx);
                cmd.Parameters.AddWithValue("@code", CodeIata);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    BagageDefinition bag = new BagageDefinition();
                    if (reader.Read())
                    {
                        bag.IdBagage = reader.GetInt32(0);
                        bag.Compagnie = reader["Compagnie"].ToString();
                        bag.Ligne = Convert.ToInt32(reader["Ligne"]);
                        bag.JourExploitation = Convert.ToInt32(reader["JourExploitation"]);
                        bag.Itineraire = reader.GetString(reader.GetOrdinal("Itineraire"));
                        bag.ClasseBagage = reader["LigneAlpha"] is DBNull ? 'Y' : Convert.ToChar(reader["LigneAlpha"]);
                        bag.CodeIata = reader.GetString(reader.GetOrdinal("CodeIata"));
                        bag.Continuation = reader[reader.GetOrdinal("Continuation")].ToString() == "Y" ? true : false;
                        bag.Rush = reader.GetFieldValue<bool>(reader.GetOrdinal("Rush"));

                        //prendre en compte le rush. BdD : [dbo].[BAGAGE_A_POUR_PARTICULARITE] jointure
                    }
                    if (reader.Read())
                    {
                        throw new ApplicationException("Le résultats devrait être unique, trop de résultats retournées !");
                    }

                    return bag;
                }   
            }
        }

        public override int CreateBagage(BagageDefinition bag)
        {
            throw new NotImplementedException();
        }


        public override RoutageBagage GetInfoRoutage(int IdBagage)
        {
            throw new NotImplementedException();
        }

        public override BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
