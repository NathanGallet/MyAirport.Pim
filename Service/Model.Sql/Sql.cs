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

        string commandGetBagageByCodeIata = "SELECT B.ID_BAGAGE AS IdBagage, " +
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

        string commandAddBagage = "INSERT INTO BAGAGE VALUES (CODE_IATA, COMPAGNIE, LIGNE, JOUR_EXPLOITATION, ESCALE, CLASSE, ORIGINE_CREATION, DATE_CREATION, ORIGINE_SAFIR, EN_CONTINUATION, EN_TRANSFERT)"+
                                  "VALUES (@codeIata, @compagnie, @ligne, @jourExploi, @escale, @classe, 'D', @dateCrea, 0, 0, 0)";

        string commandBagageRush = "INSERT INTO BAGAGE_A_POUR_PARTICULARITE (ID_BAGAGE, ID_PARTICULARITE)" +
                                   "VALUES(@idBagage, @idBagageParti)";

        public override List<BagageDefinition> GetBagageByCodeIata(string CodeIata)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagageByCodeIata, cnx);
                cmd.Parameters.AddWithValue("@code", CodeIata);
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    BagageDefinition bag = new BagageDefinition();
                    var list = new List<BagageDefinition>();
                    while (reader.Read())
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
                        list.Add(bag);
                    }
                    return list;
                }   
            }
        }

        public override BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override int CreateBagage(BagageDefinition bag)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagageByCodeIata, cnx);
                cmd.Parameters.AddWithValue("@codeIata", bag.CodeIata);
                cmd.Parameters.AddWithValue("@compagnie", bag.Compagnie);
                cmd.Parameters.AddWithValue("@ligne", bag.Ligne);
                cmd.Parameters.AddWithValue("@jourExploi", bag.JourExploitation);
                cmd.Parameters.AddWithValue("@escale", bag.Itineraire);
                cmd.Parameters.AddWithValue("@classe", bag.ClasseBagage);
                cmd.Parameters.AddWithValue("@dateCrea", DateTime.Now);

                cnx.Open();
                bag.IdBagage = Convert.ToInt32(cmd.ExecuteScalar());

                if(bag.Rush == true)
                {
                    SqlCommand cmd2 = new SqlCommand(commandBagageRush, cnx);
                    cmd2.Parameters.AddWithValue("@idBagage", bag.IdBagage);
                    cmd2.Parameters.AddWithValue("idBagageParti", 15);
                    cmd2.ExecuteNonQuery();
                }
                return bag.IdBagage;
            }
        }


        public override RoutageBagage GetInfoRoutage(int IdBagage)
        {
            throw new NotImplementedException();
        }
    }
}
