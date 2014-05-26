using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib.Models;

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


        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает все сообщения из лога по всем программам .</returns>
        /// 

        public IEnumerable<Message> Receive()
        {

            return Receive(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level">Минимульный уровень ошибки</param>
        /// <returns>Возвращает все сообщения из лога с соотвествующими уровнями ошибки</returns>
        public  IEnumerable<Message> Receive(int level)
        {
            var messages = from msg in db.Messages where  msg.Level >= level select msg;
            return messages;
        }
       
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="guid">Уникальный guid программы</param>
        /// <returns> Возвращает все сообщения из лога по конкретной программе.</returns>
        public IEnumerable<Message> Receive(Guid guid)
        {
            return Receive(guid, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid">Уникальный guid программы</param>
        /// <param name="level">Минмильный уровень сообщения</param>
        /// <returns>Возвращает все сообщения из лога с соответсвующими уровнями ошибки по конкретной программе.</returns>
        public IEnumerable<Message> Receive(Guid guid, int level)
        {
            var messages = from msg in db.Messages where msg.ClientInfo.Guid == guid.ToString() && msg.Level >= level select msg;
            return messages;
        }


        public IEnumerable<Message> Receive(string contains)
        {
            var messages = from msg in db.Messages where msg.Text.Contains(contains) select msg;
            return messages;
        }


        /// <summary>
        /// </summary>
        /// <returns>Возвращает список программ-клиентов,которые зарегистрированы в библиотеке</returns>
        public IEnumerable<ClientInfo> ReceiveClients()
        {
            return from clients in db.Clients select clients;
        }


        public IEnumerable<Message> Receive(SearchParametrs paramets)
        {

            var raw_msgs = (from msg in db.Messages where msg.Level > paramets.MinLevel && msg.Text.Contains(paramets.Contains) && ( (!paramets.HasGuid.HasValue)  || paramets.HasGuid.Value.ToString() == msg.ClientInfo.Guid ) select msg).ToList();
            if(paramets.Children == null || paramets.Children.Count() == 0)
            {
                return raw_msgs;
            }
            var result = new List<IEnumerable<Message>>();
            foreach( var par in paramets.Children)
            {
                result.Add(Receive(par, raw_msgs));
            }
            var msgs = from r in result select 

        }
        public IEnumerable<Message> Receive(SearchParametrs paramets, IEnumerable<Message> alreadyRecievd)
        {

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



    }

}
