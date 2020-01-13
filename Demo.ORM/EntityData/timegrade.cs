using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class timegrade
    {
           public timegrade(){


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
           /// Desc:时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string time {get;set;}

           /// <summary>
           /// Desc:2天 3周 4月任务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? grade {get;set;}

           /// <summary>
           /// Desc:发放状态，1是未发放，2是发放中，3是已发放
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
