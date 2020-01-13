using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class content
    {
           public content(){


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
           /// Desc:文章类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string newstype_cid {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:简介
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string introduction {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? t1 {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? t2 {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
