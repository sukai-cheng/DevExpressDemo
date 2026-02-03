using DevExpressDemo.Common;
using DevExpressDemo.Model;
using SqlSugar;

namespace DevExpressDemo.Respository
{
    public class DeviceInfoRepo
    {

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <returns></returns>
        public List<DeviceInfo> GetDeviceList()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var sqlSugarClient = databaseContext.DB;
            var query = sqlSugarClient.Queryable<DeviceInfo>();
            List<DeviceInfo> result = query.Where(t => t.DeviceType == "color")
                .OrderBy(t => t.DeviceName, OrderByType.Asc).ToList();

            return result;
        }

        // 分页 Repo 方法
        public List<DeviceInfo> GetDeviceList(int pageIndex, int pageSize, out int totalCount)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var sqlSugarClient = databaseContext.DB;

            int count = 0;

            // SqlSugar 的分页查询：ToPageList(页码, 每页条数, ref 总条数)
            var result = sqlSugarClient.Queryable<DeviceInfo>()
                .Where(t => t.DeviceType == "color")
                .OrderBy(t => t.DeviceName, OrderByType.Asc)
                .ToPageList(pageIndex, pageSize, ref count);

            totalCount = count;
            return result;
        }


        /// <summary>
        /// 获取设备名称列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetDeviceNameList()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var sqlSugarClient = databaseContext.DB;
            var query = sqlSugarClient.Queryable<DeviceInfo>();
            List<string> result = query.Where(t => t.DeviceType == "color")
                .OrderBy(t => t.DeviceName, OrderByType.Asc).Select(a => a.DeviceName).ToList();

            return result;
        }

        /// <summary>
        /// 根据设备号查询
        /// </summary>
        /// <param name="deviceName">设备号</param>
        /// <returns></returns>
        public DeviceInfo GetMachineByName(string deviceName)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var sqlSugarClient = databaseContext.DB;
            var query = sqlSugarClient.Queryable<DeviceInfo>();
            if (!string.IsNullOrEmpty(deviceName.ToString()))
            {
                query = query.Where(u => u.DeviceName == deviceName);
            }

            return query.First();

        }

        /// <summary>
        /// 根据IP查询
        /// </summary>
        /// <param name="deviceIp">设备号</param>
        /// <returns></returns>
        public DeviceInfo GetMachineByIpAddress(string deviceIp)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            var sqlSugarClient = databaseContext.DB;
            var query = sqlSugarClient.Queryable<DeviceInfo>();
            if (!string.IsNullOrEmpty(deviceIp.ToString()))
            {
                query = query.Where(u => u.DeviceIp == deviceIp);
            }

            return query.First();

        }
    }
}
