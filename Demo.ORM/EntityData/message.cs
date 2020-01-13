using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class message
    {
           public message(){


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
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? ausers_id {get;set;}

           /// <summary>
           /// Desc:留言人用户cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ausers_cid {get;set;}

           /// <summary>
           /// Desc:参与留言用户a编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ausers_code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? busers_id {get;set;}

           /// <summary>
           /// Desc:接收人cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string busers_cid {get;set;}

           /// <summary>
           /// Desc:参与留言用户b编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string busers_code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:接收者是否已读发送者的消息内容
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? adminread {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime lasttime {get;set;}

    }
}
