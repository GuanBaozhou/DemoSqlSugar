using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class logistics
    {
           public logistics(){


           }
           /// <summary>
           /// Desc:自增列
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
           /// Desc:物流公司名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:物流电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tel {get;set;}

           /// <summary>
           /// Desc:物流联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contacter {get;set;}

           /// <summary>
           /// Desc:物流公司官网
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:是否删除
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? isdelete {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
