using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib.Models;
using System.Data.SqlClient;
using System.Data;

namespace lib
{
    

    /// <summary>
    /// Класс реализующий  взаимодействия программы-пользователя и системы логирования.
    /// Определяет основные примитивные операциии.
    /// 
    /// </summary>
    /// 

    public class WinHistory
    {

        private static WinHistoryDbContext db = new WinHistoryDbContext();

        private readonly ClientInfo Client;
        
        private WinHistory() { }
      
        /// <summary>
        /// Приватный конструктор, не даёт на прямую создавать экземпляр класса, для этого следует использовать статический метод Login <see cref="Login"/>
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="name"></param>
        private WinHistory(Guid guid, string name)
        {
            ClientInfo User;
            var Users = (from client in db.Clients where client.Guid == guid.ToString() select client);
            if (Users.Count() == 0)
            {

                User = new ClientInfo();
                User.Guid = guid.ToString();
                User.Name = name;
                db.Clients.Add(User);
                db.SaveChanges();
            }
            else
            {
                User = Users.First();
            }
            Client = User;



        }


        /// <summary>
        /// Функция служит для авторизации программ-пользователей
        ///
        /// </summary>
        /// <param name="guid">Уникальный Guid программы</param>
        /// <param name="name">Имя прогрммы,которое будет показано пользователю </param>
        /// <returns>Возвращает экземпляр класса</returns>
        public static WinHistory Login(Guid guid, string name)
        {
            return new WinHistory(guid, name);
        }

        /// <summary>
        /// Отправляет сообщение от программы-пользователя  в лог
        /// </summary>
        /// <param name="message"> Текст сообщения </param>
        /// <param name="level"> Уровень важности сообщения </param>
        public void Send(string message, int level)
        {
            var msg = new Message();
            msg.ClientInfo = Client;
            msg.Text = message;
            msg.Level = level;
            msg.Stamp = DateTime.Now;
            db.Messages.Add(msg);
            db.SaveChanges();
        }



        /// <summary>
        /// Отправляет сообщение с нулевым уровнем важности <seealso cref="Send(string,int)"/>
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            Send(message, 0);
        }


        ///// <summary>
        ///// Возвращает все сообщения из лога по всем программам .
        ///// </summary>
        ///// <returns></returns>
        ///// 

        //public IEnumerable<Message> Receive()
        //{

        //    return Receive(0);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="level">Минимульный уровень ошибки</param>
        ///// <returns>Возвращает все сообщения из лога с соотвествующими уровнями ошибки</returns>
        //public  IEnumerable<Message> Receive(int level)
        //{
        //    var messages = from msg in db.Messages where  msg.Level >= level select msg;
        //    return messages;
        //}
       
        
        ///// <summary>
        ///// Возвращает все сообщения из лога по конкретной программе.
        ///// </summary>
        ///// <param name="guid">Уникальный guid программы</param>
        ///// <returns></returns>
        //public IEnumerable<Message> Receive(Guid guid)
        //{
        //    return Receive(guid, 0);
        //}

        ///// <summary>
        /////Возвращает все сообщения из лога с соответсвующими уровнями ошибки по конкретной программе. 
        ///// </summary>
        ///// <param name="guid">Уникальный guid программы</param>
        ///// <param name="level">Минмильный уровень сообщения</param>
        ///// <returns></returns>
        //public IEnumerable<Message> Receive(Guid guid, int level)
        //{
        //    var messages = from msg in db.Messages where msg.ClientInfo.Guid == guid.ToString() && msg.Level >= level select msg;
        //    return messages;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="contains">Со</param>
        ///// <returns></returns>
        //public IEnumerable<Message> Receive(string contains)
        //{
        //    var messages = from msg in db.Messages where msg.Text.Contains(contains) select msg;
        //    return messages;
        //}


        /// <summary>
        /// Возвращает список программ-клиентов,которые зарегистрированы в библиотеке
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClientInfo> ReceiveClients()
        {
            return from clients in db.Clients select clients;
        }

        /// <summary>
        /// Возвращает  сообщения из лога
        /// </summary>
        /// <param name="paramets">Древо параметров поиска</param>
        /// <returns></returns>
        public IEnumerable<Message> Receive(SearchParametrs paramets)
        {


            var raw_msgs = (from msg in db.Messages
                            select msg).ToList();
            if(paramets.Children == null || paramets.Children.Count() == 0)
            {
                return raw_msgs;
            }
            var all_msgs = new List<Message>();
            foreach( var par in paramets.Children)
            {
                all_msgs = all_msgs.Concat(Receive(par, raw_msgs)).ToList();
            }
            return all_msgs; 

        }
        /// <summary>
        /// Возвращает сообщения из лога, но отбор идёи не из базыэ,а из какого-либо IEnumerable источника
        /// </summary>
        /// <param name="paramets">Древо параметров поиска</param>
        /// <param name="alreadyRecievd">Источник данных из которого происходит отбор сообщений</param>
        /// <returns></returns>
        public IEnumerable<Message> Receive(SearchParametrs paramets, IEnumerable<Message> alreadyRecievd)
        {
            var raw_msgs = paramets.Search(alreadyRecievd);
            if (paramets.Children == null || paramets.Children.Count() == 0)
            {
                return raw_msgs;
            }
            var all_msgs = new List<Message>();
            foreach (var par in paramets.Children)
            {
                all_msgs = all_msgs.Concat(Receive(par, raw_msgs)).ToList();
            }
            return all_msgs; 

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid">Уникальный guid программы</param>
        /// <returns>Возвращает информацию о программе клиенте </returns>
        public ClientInfo ReciveClientInfo(Guid guid)
        {
            return (from clients in db.Clients where clients.Guid == guid.ToString() select clients).Single();
        }

        public ClientInfo ReciveClientInfoBAD(Guid guid)
        {
            var connection = new SqlConnection();
           var query = "{SELECT [Extent1].[ClientInfoId] AS [ClientInfoId], [Extent1].[Guid] AS [Guid], [Extent1].[Name] AS [Name] FROM [dbo].[ClientInfoes] AS [Extent1] WHERE [Extent1].[Guid] =@Name";
            var command = new SqlCommand(query,connection);
            var  Param1 = new SqlParameter("@Name", SqlDbType.VarChar);
            Param1.Value = guid.ToString();
            command.Parameters.Add(Param1);
           SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            var result = command.ExecuteReader();
            var ClientInfo = new ClientInfo();
            
            if(result.HasRows)
            {
                while(result.Read())
                {
                    ClientInfo.ClientInfoId = result.GetInt32(0);
                    string r = result.GetString(1);
                    Guid g = new Guid();
                   
                        if(!(Guid.TryParse(r, out g)))
                        {
                            return null;
                        }
                   
                 
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


        


    }

}
