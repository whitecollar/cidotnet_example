using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;

    using System;
    using System.IO;

        var root = Directory.GetCurrentDirectory();
        var dotenv = Path.Combine(root, ".env");
        DotEnv.Load(dotenv);


var getip = getIP();
Console.WriteLine("Your IP Address is :" + getip );
String hostName = Dns.GetHostName();
Console.WriteLine("Computer name :" + hostName);

static string getIP()
{
    var myhost = Dns.GetHostEntry(Dns.GetHostName());
    foreach (var ipaddr in myhost.AddressList)
    {
        if (ipaddr.AddressFamily == AddressFamily.InterNetwork)
        {
            return ipaddr.ToString();
        }
    }
    throw new Exception("No network adapters with an IPv4 address was found");
}


 try
        {
            
            using (var sr = new StreamReader(".env"))
            {
               
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }


    public static class DotEnv
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(
                    '=',
                    StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }