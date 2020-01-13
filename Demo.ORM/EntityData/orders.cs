using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class orders
    {
           public orders(){


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
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string orderno {get;set;}

           /// <summary>
           /// Desc:支付类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string paytype {get;set;}

           /// <summary>
           /// Desc:用户
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string usersaddress_cid {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string acceptname {get;set;}

           /// <summary>
           /// Desc:收货人电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accepttel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zipcode {get;set;}

           /// <summary>
           /// Desc:省/直辖市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string prov {get;set;}

           /// <summary>
           /// Desc:地级市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string city {get;set;}

           /// <summary>
           /// Desc:县/区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string country {get;set;}

           /// <summary>
           /// Desc:收货地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string acceptaddress {get;set;}

           /// <summary>
           /// Desc:留言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:订单总价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? amount {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:支付时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? paymenttime {get;set;}

           /// <summary>
           /// Desc:快递名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string expressname {get;set;}

           /// <summary>
           /// Desc:物流编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string expressno {get;set;}

           /// <summary>
           /// Desc:运费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? expressfee {get;set;}

           /// <summary>
           /// Desc:发货时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? expresstime {get;set;}

           /// <summary>
           /// Desc:完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? completetime {get;set;}

           /// <summary>
           /// Desc:管理员回复
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string adminremark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string logistics_cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? logistics_money {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string warehouse_cid {get;set;}

           /// <summary>
           /// Desc:服务器返回信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string serverreturnmessage {get;set;}

    }
}
