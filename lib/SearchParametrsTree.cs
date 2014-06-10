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
  public  abstract class SearchParametrs
    {
      /// <summary>
      /// Список детей параметра, каждый  каждый уровень вниз ,добавляет логическое и, вширь - логическое или
      /// </summary>
        public List<SearchParametrs> Children { get; private set; } 
      public SearchParametrs()
      {
          Children = new List<SearchParametrs>();
      }

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

     

   
     

       public abstract IEnumerable<Models.Message> Search(IEnumerable<Models.Message> raw_msgs);

    }

  public class HasGuidParam:SearchParametrs
  {
      /// <summary>
      /// Имеет указанный Guid
      /// </summary>
      public Guid? HasGuid { get; set; }
     public HasGuidParam(Guid guid)
      {
          HasGuid = guid;
      }

      public override IEnumerable<Models.Message> Search(IEnumerable<Models.Message> raw_msgs)
      {
          return from m in raw_msgs where  m.ClientInfo != null && m.ClientInfo.Guid == HasGuid.ToString() select m;
      }
  }

    public class HasMinimumLevelParam:SearchParametrs
    {
        /// <summary>
        /// Минимальный уровень
        /// </summary>
        public int MinLevel { get; set; }

        public HasMinimumLevelParam(int level)
        {
            MinLevel= level;
        }

        public override IEnumerable<Models.Message> Search(IEnumerable<Models.Message> raw_msgs)
        {
            return from m in raw_msgs where m.Level >= MinLevel select m;
        }

    }

    public class NoParam:SearchParametrs
    {
        public override IEnumerable<Models.Message> Search(IEnumerable<Models.Message> raw_msgs)
        {
            return raw_msgs;
        }
    }

    public class ContainsParam:SearchParametrs
    {
        /// <summary>
        /// Содержит подстроку
        /// </summary>
        public string Contains { get; set; }

        public ContainsParam(string str)
        {
            Contains = str;
        }

        public override IEnumerable<Models.Message> Search(IEnumerable<Models.Message> raw_msgs)
        {
            return from m in raw_msgs where m.Text.Contains(Contains) select m;
        }
    }
}
