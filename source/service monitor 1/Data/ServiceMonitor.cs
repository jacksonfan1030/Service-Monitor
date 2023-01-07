using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Threading;

namespace service_monitor_1.Data
{
    public class ServiceMonitor
    {
        public string Monitor(string url)
        {
            //偵測主程式
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream datastream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(datastream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            string response1 = response.StatusDescription;
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            datastream.Close();
            response.Close();
            return response1;
            //return responseFromServer;

        }
    }
}