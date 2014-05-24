using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib.Models;
using System.IO;
namespace client
{
    public interface ILogExport
    {
        /// <summary>
        /// Строка  имени фильтра в диалоге сохранения окна.
        /// </summary>
        string FilterName { get; }
        /// <summary>
        /// Прозводит экспорт в необходимый формат
        /// </summary>
        /// <param name="path">Путь куда будет сохраняться файл.</param>
        /// <param name="messages">Сообщения,которые были экспортированны.</param>
        void ExportToFile(string path, IEnumerable<Message> messages);
    }

    /// <summary>
    /// Реализация экспорта в текстовый формат
    /// </summary>
    class LogExportToTXT : ILogExport
    {
        string ILogExport.FilterName
        {
            get { return "Текстовый файл |*.txt"; }
        }
        void ILogExport.ExportToFile(string path, IEnumerable<Message> messages)
        {


            try
            {
                var file = File.CreateText(path);
                foreach (var msg in messages)
                {

                    file.WriteLine(msg.Stamp + "   " + msg.ClientInfo.Name + "   " + msg.Level + "   " + msg.Text);

                }
                file.Close();
            }
            finally
            {

            }

        }


    }

    /// <summary>
    /// Реализация экспорта в XML формат
    /// </summary>

    class LogExportToXML : ILogExport
    {
        string ILogExport.FilterName
        {
            get { return "XML Файл |*.xml"; }
        }
        void ILogExport.ExportToFile(string path, IEnumerable<Message> messages)
        {
            try
            {
                var file = File.CreateText(path);

                var ser = new System.Xml.Serialization.XmlSerializer(typeof(Message));
                foreach (var msg in messages)
                {

                    ser.Serialize(file, msg);

                }
                file.Close();
            }
            finally
            {

            }

        }




    }

    /// <summary>
    /// Мост организующий экспорт в любой из доступных форматов.
    /// </summary>
    public class LogExporter
    {
        private List<ILogExport> typesOfExport;


        public LogExporter(List<ILogExport> types)
        {
            typesOfExport = types;
        }

        public string Filter
        {
            get
            {
                string s = "";
                for (var i = 0; i < typesOfExport.Count; i++)
                {
                    if (i + 1 == typesOfExport.Count)
                    {
                        s += typesOfExport[i].FilterName;
                    }
                    else
                    {
                        s += typesOfExport[i].FilterName + "|";
                    }
                }

                s = s.PadLeft(s.Length - 1);
                return s;
            }
        }

        public void Export(string path, int index, IEnumerable<Message> messages)
        {
            typesOfExport[index].ExportToFile(path, messages);
        }
    }

}
