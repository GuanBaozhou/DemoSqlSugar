using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class messagebody
    {
           public messagebody(){


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
           /// Desc:消息主表cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string message_cid {get;set;}

           /// <summary>
           /// Desc:发送此条消息的人，a或者b
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sender {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int senderid {get;set;}

           /// <summary>
           /// Desc:消息内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:接收者是否已读发送者的消息内容
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool isread {get;set;}

           /// <summary>
           /// Desc:a是否忽略
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? aisignore {get;set;}

           /// <summary>
           /// Desc:b是否忽略
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? bisignore {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
