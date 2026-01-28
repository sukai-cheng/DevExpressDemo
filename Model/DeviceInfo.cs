using SqlSugar;
using System.ComponentModel;

namespace DevExpressDemo.Model
{
    /// <summary>
    /// 设备信息表
    /// </summary>
    [SugarTable("device_info")]
    public class DeviceInfo
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "device_id")]
        [Description("设备ID")]
        public int DeviceId { get; set; }

        /// <summary>
        /// 设备IP地址
        /// </summary>
        [SugarColumn(ColumnName = "device_ip", Length = 255, IsNullable = false)]
        [Description("设备IP地址")]
        public string DeviceIp { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [SugarColumn(ColumnName = "device_name", Length = 255, IsNullable = false)]
        [Description("设备名称")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [SugarColumn(ColumnName = "device_detail", Length = 255)]
        [Description("设备信息")]
        public string DeviceDetail { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [SugarColumn(ColumnName = "device_type", Length = 255)]
        [Description("设备类型")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        [SugarColumn(ColumnName = "topic", Length = 255)]
        [Description("主题")]
        public string Topic { get; set; }

        /// <summary>
        /// 重写ToString方法，便于调试和打印
        /// </summary>
        public override string ToString()
        {
            return $"设备ID:{DeviceId}, 名称:{DeviceName}, IP:{DeviceIp}, 类型:{DeviceType}";
        }
    }
}
