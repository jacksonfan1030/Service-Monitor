namespace service_monitor_1.Data
{
    public class MonitorService
    {
        public string DoMonitor(string url)
        {
            //呼叫功能類別
            ServiceMonitor servicemonitor = new ServiceMonitor();

            //進行偵測
            string result = servicemonitor.Monitor(url);

            //回傳結果
            return result;
        }
    }
}
