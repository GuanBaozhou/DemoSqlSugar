using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class shopcart
    {
           public shopcart(){


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
           /// Desc:产品cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string product_cid {get;set;}

           /// <summary>
           /// Desc:产品名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string product_name {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal price {get;set;}

           /// <summary>
           /// Desc:积分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? point {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int count {get;set;}

           /// <summary>
           /// Desc:用户cid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

    }
}
