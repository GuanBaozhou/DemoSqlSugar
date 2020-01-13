using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class product
    {
           public product(){


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
           /// Desc:所属分类
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string producttype_cid {get;set;}

           /// <summary>
           /// Desc:品牌
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? brand {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:显示价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? price0 {get;set;}

           /// <summary>
           /// Desc:销售价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? price {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? price1 {get;set;}

           /// <summary>
           /// Desc:积分
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? point {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string paymethod {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pic {get;set;}

           /// <summary>
           /// Desc:信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:库存数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? inventorynum {get;set;}

           /// <summary>
           /// Desc:已售数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? salesnum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? weight {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string specifications {get;set;}

           /// <summary>
           /// Desc:注册可用
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public bool? isregister {get;set;}

           /// <summary>
           /// Desc:购物可用
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public bool? isbuy {get;set;}

           /// <summary>
           /// Desc:是否最热
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ishot {get;set;}

           /// <summary>
           /// Desc:是否优秀
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isgood {get;set;}

           /// <summary>
           /// Desc:是否最新
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isnew {get;set;}

           /// <summary>
           /// Desc:是否特殊
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isspecial {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? isdelete {get;set;}

           /// <summary>
           /// Desc:是否下架
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? islock {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string shoping {get;set;}

    }
}
