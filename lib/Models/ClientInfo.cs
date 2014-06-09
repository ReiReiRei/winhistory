using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace lib.Models
{






    
    
    /// <summary>
    /// Класс - модель определяющая информацию о пориложении-пользователе.
    /// Каждый пользователь - какое-то приложение,которое использует нашу библиотеку для логирования действий. 
    /// </summary>
    public class ClientInfo
    {
        public static ClientInfo getClientInfoById(int id)
        {
            var connection = new SqlConnection();
            var query = "SELECT [Extent1].[ClientInfoId] AS [ClientInfoId], [Extent1].[Guid] AS [Guid], [Extent1].[Name] AS [Name] FROM [dbo].[ClientInfoes] AS [Extent1] WHERE [Extent1].[ClientInfoId] =@Id";
            var command = new SqlCommand(query, connection);
            var Param1 = new SqlParameter("@id", SqlDbType.Int);


            command.Parameters.Add(Param1);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            var result = command.ExecuteReader();
            var ClientInfo = new ClientInfo();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    ClientInfo.ClientInfoId = result.GetInt32(0);
                    string r = result.GetString(1);
                    Guid g = new Guid(r);


                    ClientInfo.MinLevel = 0;
                    ClientInfo.Search = true;
                    ClientInfo.Contains = "";
                    ClientInfo.Name = result.GetString(2);
                }

            }
            else
            {
                return null;
            }
            return ClientInfo;


        }

        public static void Delete(int id)
        {
   
            command.Dispose();
            
        }
         
        public void insertInDb()
        {
            var connection = new SqlConnection();
            var query = "INSERT INTO [dbo].[ClientInfoes] VALUES (0,@Guid,@Name)";
            var command = new SqlCommand(query, connection);
            var Param1 = new SqlParameter("@Guid", SqlDbType.VarChar);
            var Param2 = new SqlParameter("@Name", SqlDbType.VarChar);
            Param1.Value = this.Guid;
            Param2.Value = this.Name;
            command.Dispose();
            

        }


      
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public int ClientInfoId { get; set; }
        /// <summary>
        /// Строковое представление Guid,является уникальным для каждого приложения
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// Имя,которое будет оторажаться для данной программы в обзоре лога.
        /// Присваивается при первой авторизации приложения,дальше не меняется
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фильтр минимульного уровня сообщения
        /// </summary>
        [NotMapped]
        public int MinLevel { get; set; }

        /// <summary>
        /// Фильтр содержания в подстроки в соощении
        /// </summary>
        [NotMapped]
        public string Contains { get; set; }

        /// <summary>
        /// Фильтр участия программы-клиента в поиске сообщений
        /// </summary>
        [NotMapped]
        public bool Search { get; set; }

    }
}
