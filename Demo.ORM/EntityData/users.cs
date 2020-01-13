using System;
using System.Linq;
using System.Text;

namespace Demo.ORM.EntityData
{
    ///<summary>
    ///
    ///</summary>
    public partial class users
    {
           public users(){


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
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string code {get;set;}

           /// <summary>
           /// Desc:昵称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:登录密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string l1pwd {get;set;}

           /// <summary>
           /// Desc:交易密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string l2pwd {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string l3pwd {get;set;}

           /// <summary>
           /// Desc:等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string level_cid {get;set;}

           /// <summary>
           /// Desc:对应级别的业绩
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? levelgrade1 {get;set;}

           /// <summary>
           /// Desc:推荐人cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tjusercid {get;set;}

           /// <summary>
           /// Desc:推荐人编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tjusercode {get;set;}

           /// <summary>
           /// Desc:推荐位置
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int tjposition {get;set;}

           /// <summary>
           /// Desc:推荐等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int tjlevel {get;set;}

           /// <summary>
           /// Desc:接点人cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jdusercid {get;set;}

           /// <summary>
           /// Desc:接点人编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jdusercode {get;set;}

           /// <summary>
           /// Desc:接点位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? jdposition {get;set;}

           /// <summary>
           /// Desc:接点等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? jdlevel {get;set;}

           /// <summary>
           /// Desc:是否报单中心
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int isreportcenter {get;set;}

           /// <summary>
           /// Desc:是否区域代理
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte isreportcenterarea {get;set;}

           /// <summary>
           /// Desc:所属报单中心cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reportcentercid {get;set;}

           /// <summary>
           /// Desc:所属报单中心编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reportcentercode {get;set;}

           /// <summary>
           /// Desc:省/直辖市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string provincename {get;set;}

           /// <summary>
           /// Desc:地级市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cityname {get;set;}

           /// <summary>
           /// Desc:县区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string countyname {get;set;}

           /// <summary>
           /// Desc:注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? registertype {get;set;}

           /// <summary>
           /// Desc:注册人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string registerusercid {get;set;}

           /// <summary>
           /// Desc:注册日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? registerdate {get;set;}

           /// <summary>
           /// Desc:注册的业绩（pv）
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? registerlevelgrade1 {get;set;}

           /// <summary>
           /// Desc:注册时等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string registerlevelcid {get;set;}

           /// <summary>
           /// Desc:激活类型
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? activatetype {get;set;}

           /// <summary>
           /// Desc:激活人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string activateusercid {get;set;}

           /// <summary>
           /// Desc:激活日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? activatedate {get;set;}

           /// <summary>
           /// Desc:真实姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string realname {get;set;}

           /// <summary>
           /// Desc:身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string idnumber {get;set;}

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
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string email {get;set;}

           /// <summary>
           /// Desc:QQ
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qq {get;set;}

           /// <summary>
           /// Desc:密保id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? mibao_id {get;set;}

           /// <summary>
           /// Desc:密保答案
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mibaokey {get;set;}

           /// <summary>
           /// Desc:选择的支付比率组合
           /// Default:+
           /// Nullable:True
           /// </summary>           
           public string paymethod {get;set;}

           /// <summary>
           /// Desc:注册时选定商品的总价
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? paymoney {get;set;}

           /// <summary>
           /// Desc:年费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? yearfee {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? islock {get;set;}

           /// <summary>
           /// Desc:是否锁定登录
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? locklogin {get;set;}

           /// <summary>
           /// Desc:锁定阶段网状图
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? lockjdnet {get;set;}

           /// <summary>
           /// Desc:锁定推荐网状图
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? locktjnet {get;set;}

           /// <summary>
           /// Desc:锁定转账
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? locktransfer {get;set;}

           /// <summary>
           /// Desc:锁定提现
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? lockequity {get;set;}

           /// <summary>
           /// Desc:锁定提现
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? lockcash {get;set;}

           /// <summary>
           /// Desc:左值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? leftvalue {get;set;}

           /// <summary>
           /// Desc:右值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? rightvalue {get;set;}

           /// <summary>
           /// Desc:对碰值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? duipengvalue {get;set;}

           /// <summary>
           /// Desc:总业绩
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? totalgrade {get;set;}

           /// <summary>
           /// Desc:获得的总奖金
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? totalbonus {get;set;}

           /// <summary>
           /// Desc:积分
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? point {get;set;}

           /// <summary>
           /// Desc:是否空单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? iskongdan {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userswallet_id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string walletaddress {get;set;}

    }
}
