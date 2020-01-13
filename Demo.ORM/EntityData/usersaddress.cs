using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class usersaddress
    {
           public usersaddress(){


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
           /// Desc:用户cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string area_cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string provincename {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cityname {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string countyname {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:收件人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recipient {get;set;}

           /// <summary>
           /// Desc:邮编
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zipcode {get;set;}

           /// <summary>
           /// Desc:是否默认
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool isdefault {get;set;}

           /// <summary>
           /// Desc:是否删除
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool isdelete {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
