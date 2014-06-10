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


    public class ClientInfoModule:ClientInfo
    {


        [NotMapped]
        public SqlConnection Connection { get; set; }

        public ClientInfoModule(SqlConnection connnetion)
        {
            Connection = connnetion;
        }
        public ClientInfo find(Guid guid)
        {


            var gate = new ClientGateway(Connection);
            gate.find(guid);
            return gate.Client;
        }


        public IEnumerable<ClientInfo> findAll()
        {

            var query = "SELECT [Extent1].[ClientInfoId] AS [ClientInfoId], [Extent1].[Guid] AS [Guid], [Extent1].[Name] AS [Name] FROM [dbo].[ClientInfoes] AS [Extent1]";
            var command = new SqlCommand(query, Connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            var result = command.ExecuteReader();
            var ClientInfo = new ClientInfo();
            var ret = new List<ClientInfo>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    ClientInfo = ClientInfoMapper.get(result);
                    ret.Add(ClientInfo);
                }

            }
            else
            {
                return null;
            }
            return ret;


        }



        public void deleteClient(ClientInfo client)
        {

            var gate = new ClientGateway(Connection);
            gate.Client = client;
            gate.delete();
        }

        public void deleteClient()
        {
            deleteClient(this);
        }


        public void addClient(ClientInfo client)
        {

            var gate = new ClientGateway(Connection);
            gate.Client = client;
            gate.insert();
        }

    }



    public class ClientGateway
    {

        public ClientGateway(SqlConnection con)
        {
            Connection = con;
        }

        public SqlConnection Connection { get; set; }


        public ClientInfo Client { get; set; }
        public void delete()
        {
           

            var query = "DELETE FROM [dbo].[ClientInfoes] WHERE [dbo].[ClientInfoes].[Guid] = @Guid";
            var command = new SqlCommand(query, Connection);
            var Param1 = new SqlParameter("@Guid", SqlDbType.VarChar);
    
            Param1.Value = Client.Guid;
            
            command.Dispose();
            Connection.Close();
            
        }

        public void insert()
        {
            
            Connection.Open();
            var query = "INSERT INTO [dbo].[ClientInfoes] VALUES (0,@Guid,@Name)";
            var command = new SqlCommand(query, Connection);
            var Param1 = new SqlParameter("@Guid", SqlDbType.VarChar);
            var Param2 = new SqlParameter("@Name", SqlDbType.VarChar);
            Param1.Value = Client.Guid;
            Param2.Value = Client.Name;
            command.Dispose();
            Connection.Close();
            

        }

        public void find(Guid guid)
        {
            Connection.Open();
            var query = "SELECT [Extent1].[ClientInfoId] AS [ClientInfoId], [Extent1].[Guid] AS [Guid], [Extent1].[Name] AS [Name] FROM [dbo].[ClientInfoes] AS [Extent1] WHERE [Extent1].[Guid] =@Guid";
            var command = new SqlCommand(query, Connection);
            var Param1 = new SqlParameter("@Guid", SqlDbType.VarChar);
            Param1.Value = guid.ToString();


            command.Parameters.Add(Param1);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            var result = command.ExecuteReader();
            ClientInfo ClientInfo = null;

            if (result.HasRows)
            {
                while (result.Read())
                {
                    ClientInfo = ClientInfoMapper.get(result);
                }

            }
            else
            {
                Client = null;
            }
            Client = ClientInfo;
            Connection.Close();
        }
        public void update()
        {
            //Connection.Open();
            //var query = "INSERT INTO [dbo].[ClientInfoes] VALUES (0,@Guid,@Name)";
            //var command = new SqlCommand(query, Connection);
            //var Param1 = new SqlParameter("@Guid", SqlDbType.VarChar);
            //var Param2 = new SqlParameter("@Name", SqlDbType.VarChar);
            //Param1.Value = Client.Guid;
            //Param2.Value = Client.Name;
            //command.Dispose();
            //Connection.Close();

        }
    }
     

    public class ClientInfoMapper
    {
        static public  ClientInfo get( SqlDataReader result)
        {
            var ClientInfo = new ClientInfo();
            ClientInfo.ClientInfoId = result.GetInt32(0);
            string r = result.GetString(1);
            Guid g = new Guid(r);


            ClientInfo.MinLevel = 0;
            ClientInfo.Search = true;
            ClientInfo.Contains = "";
            ClientInfo.Name = result.GetString(2);
            return ClientInfo;
        }

    }
}
