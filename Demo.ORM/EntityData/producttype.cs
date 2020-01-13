using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class producttype
    {
           public producttype(){


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
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:上级cid，null代表本身是最上级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string parentcid {get;set;}

           /// <summary>
           /// Desc:等级，1=最上层，2=第二层，3=第二层的子级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int level {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string imgurl {get;set;}

           /// <summary>
           /// Desc:是否删除
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte isdelete {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
