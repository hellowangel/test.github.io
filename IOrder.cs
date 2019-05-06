using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYInterface
{

    public interface IOrder
    {
        void FirstSubmitOrder(FirstSubmitSupplierEntity model);

        void SecondSubmitOrder(SecondSubmitSupplierEntity model);

        

        
    }

    /// <summary>
    /// 订单提交需要的参数
    /// </summary>
    public class FirstSubmitSupplierEntity
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 订单面值
        /// </summary>
        public int ParValue { get; set; }
        /// <summary>
        /// 供货商编码
        /// </summary>
        public int SupplierID { get; set; }

        /// <summary>
        /// 号码
        /// </summary>
        public string  MobileNumber { get; set; }
        /// <summary>
        /// 订单提交超时时间-超过当前时间就换供货商继续提交
        /// </summary>
        public int TimeOut { get; set; }

        
    }

    public class SecondSubmitSupplierEntity
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerifCode { get; set; }
    }
}
