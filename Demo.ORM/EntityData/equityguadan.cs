using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class equityguadan
    {
           public equityguadan(){


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
           public string serialno {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string users_cid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string users_code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string users_mobile {get;set;}

           /// <summary>
           /// Desc:挂单类型，1=买，2=卖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? type {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? auto {get;set;}

           /// <summary>
           /// Desc:收款人的银行cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string usersbank_cid {get;set;}

           /// <summary>
           /// Desc:银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bank {get;set;}

           /// <summary>
           /// Desc:支行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string subbank {get;set;}

           /// <summary>
           /// Desc:卡号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cardcode {get;set;}

           /// <summary>
           /// Desc:户主
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cardusername {get;set;}

           /// <summary>
           /// Desc:买单要进入的货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? intowallettype_id {get;set;}

           /// <summary>
           /// Desc:购买数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? count {get;set;}

           /// <summary>
           /// Desc:剩余数量,插入的时候和购买数量一样 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? rest {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? price {get;set;}

           /// <summary>
           /// Desc:总价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? mustmoney {get;set;}

           /// <summary>
           /// Desc:支付方式比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string paymethod {get;set;}

           /// <summary>
           /// Desc:状态，0=等待匹配，1=交易中，2=交易完成，-1=交易失败，-2=已撤销
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short status {get;set;}

           /// <summary>
           /// Desc:优先级
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? pritime {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? addtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string state {get;set;}

           /// <summary>
           /// Desc:0代表可以撤销，1代表不可以
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? ischexiao {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? baozhenjing {get;set;}

    }
}
