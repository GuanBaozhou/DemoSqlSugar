using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class sendyzm
    {
           public sendyzm(){


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
           /// Nullable:True
           /// </summary>           
           public string cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mobile_no {get;set;}

           /// <summary>
           /// Desc:发送的手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:动作
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:验证码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string yzm {get;set;}

           /// <summary>
           /// Desc:短信内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string res {get;set;}

           /// <summary>
           /// Desc:验证状态，0：未认证，1：已认证
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? stutas {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
