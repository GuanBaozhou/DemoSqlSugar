using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class balance
    {
           public balance(){


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
           /// Desc:开始id
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? usergrade_id1 {get;set;}

           /// <summary>
           /// Desc:结束id
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? usergrade_id2 {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? mindate {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? maxdate {get;set;}

           /// <summary>
           /// Desc:发放时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? granttime {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int type {get;set;}

           /// <summary>
           /// Desc:期数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int issue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? displaytime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string state {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
