using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib.Models
{
    /// <summary>
    /// Модель представления сообщения от программ
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// Поле содержит в себе укзатель на информацию о приложении-пользователе
        /// <see cref="ClientInfo"/>
        /// </summary>
        public ClientInfo ClientInfo { get; set; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Время сообщения
        /// </summary>
        public DateTime Stamp { get; set; }
        /// <summary>
        /// Уровень важности сообщения, больше - важнеее.
        /// </summary>
        public int Level { get; set; }



           
    }


}
