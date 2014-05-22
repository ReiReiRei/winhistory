using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
