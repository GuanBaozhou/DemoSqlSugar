using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class country
    {
           public country(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:newid()
           /// Nullable:False
           /// </summary>           
           public string cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string value {get;set;}

           /// <summary>
           /// Desc:英文
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string English {get;set;}

           /// <summary>
           /// Desc:中文简称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Chinese {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string fanti {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
