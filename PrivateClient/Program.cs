﻿using System.Net;

namespace PrivateClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ConnectToServer(IPAddress.Parse("172.16.5.142"), 8080);
        }
    }
}
