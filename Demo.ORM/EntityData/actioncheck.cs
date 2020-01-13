using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class actioncheck
    {
           public actioncheck(){


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
           /// Desc:记录用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:操作类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:时间？
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string shijian {get;set;}

           /// <summary>
           /// Desc:所在ip
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
