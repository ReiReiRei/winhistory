using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{

    /// <summary>
    /// Описывает параметры,которые могут быть применены для фильтрации IEnumerable Model.Message
    /// </summary>
  public  class SearchParametrs
    {
      /// <summary>
      /// Список детей параметра, каждый  каждый уровень вниз ,добавляет логическое и, вширь - логическое или
      /// </summary>
        public List<SearchParametrs> Children { get; private set; }

        //public SearchParametrs Parent;
       
      /// <summary>
      /// Добавляет дочеренее древо параметров
      /// </summary>
      /// <param name="child">Новое дочернее древо параметров</param>
        public void AddChild(SearchParametrs child)
        {
            //child.Parent = this;
            Children.Add(child);
        }
      
      /// <summary>
      /// Конструктор по умолчанию
      /// </summary>
        public SearchParametrs()
        {
            Children = new List<SearchParametrs>();
            HasGuid = null;
            MinLevel = 0;
            
           

        }
     
        /// <summary>
        /// Минимальный уровень
        /// </summary>
        public int MinLevel { get; set; }
        /// <summary>
        /// Содержит подстроку
        /// </summary>
        public string Contains { get; set; }
        /// <summary>
        /// Имеет указанный Guid
        /// </summary>
        public Guid? HasGuid { get; set; }
       


       



    }
}
