using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class levelchange
    {
           public levelchange(){


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
           /// Desc:用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_code {get;set;}

           /// <summary>
           /// Desc:升级前等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string fromlevel_cid {get;set;}

           /// <summary>
           /// Desc:升级后等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string tolevel_cid {get;set;}

           /// <summary>
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? checkeddate {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int type {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:管理员回复
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarkforadmin {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
