using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class xiangying
    {
           public xiangying(){


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
           /// Desc:操作类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string value {get;set;}

           /// <summary>
           /// Desc:网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
