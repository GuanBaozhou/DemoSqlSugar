using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class mailbox
    {
           public mailbox(){


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
           /// Desc:发信人cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string fromusers_cid {get;set;}

           /// <summary>
           /// Desc:发信人用户名
           /// Default:客服(System)
           /// Nullable:True
           /// </summary>           
           public string fromusers_code {get;set;}

           /// <summary>
           /// Desc:发信人是否忽略
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool fromusersignore {get;set;}

           /// <summary>
           /// Desc:收信人cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tousers_cid {get;set;}

           /// <summary>
           /// Desc:收信人用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tousers_code {get;set;}

           /// <summary>
           /// Desc:收信人是否忽略
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool tousersignore {get;set;}

           /// <summary>
           /// Desc:收信人已读
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool isread {get;set;}

           /// <summary>
           /// Desc:主题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string maintitle {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
