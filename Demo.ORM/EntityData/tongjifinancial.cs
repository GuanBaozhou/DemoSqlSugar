using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class tongjifinancial
    {
           public tongjifinancial(){


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
           /// Desc:总拨币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalbobi {get;set;}

           /// <summary>
           /// Desc:总营业额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalyingyee {get;set;}

           /// <summary>
           /// Desc:总业绩
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalgrade {get;set;}

           /// <summary>
           /// Desc:总奖金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totalbonus {get;set;}

           /// <summary>
           /// Desc:销售奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus1 {get;set;}

           /// <summary>
           /// Desc:领导奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus2 {get;set;}

           /// <summary>
           /// Desc:复消奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus3 {get;set;}

           /// <summary>
           /// Desc:分红奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus4 {get;set;}

           /// <summary>
           /// Desc:报单费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus5 {get;set;}

           /// <summary>
           /// Desc:产品积分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus6 {get;set;}

           /// <summary>
           /// Desc:专卖店推荐奖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bonus7 {get;set;}

           /// <summary>
           /// Desc:扣税
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? kousui {get;set;}

           /// <summary>
           /// Desc:转复消
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? fuxiao {get;set;}

           /// <summary>
           /// Desc:利润总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? totallirun {get;set;}

           /// <summary>
           /// Desc:拨比值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bobilvalue {get;set;}

           /// <summary>
           /// Desc:会员总数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sumnumber {get;set;}

           /// <summary>
           /// Desc:实单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? shidan {get;set;}

           /// <summary>
           /// Desc:空单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? kongdan {get;set;}

           /// <summary>
           /// Desc:服务中心进货总金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? reportmoney {get;set;}

           /// <summary>
           /// Desc:订单总数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sunorder {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? displaytime {get;set;}

           /// <summary>
           /// Desc:(getdate())
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

    }
}
