using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class taskrecord
    {
           public taskrecord(){


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
           /// Desc:任务类型，0是秒任务，1是天，2是周，3是月
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int type {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:时间，天任务是哪一天，周任务是哪一周
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string time {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
