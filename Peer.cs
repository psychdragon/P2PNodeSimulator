using System;
using System.Collections.Generic;
using System.Text;

namespace P2PNodeSimulator
{
    class Peer
    {
        public int GUID { set; get; }
        public string IP { set; get; }
        public string Port { set; get; }
        

        public Peer(string ip, string port, int guid)
        {
            IP = ip;
            Port = port;

            ScanNet(ip,1);
            //ScanNet(ip,-1);
            GUID = guid;
            Console.WriteLine("Sim Peer Created - http://{0}:{1} with GUID {2}", IP, Port, GUID);
        }

        private void ScanNet(string ip, int inc)
        {
            string neighbour = NeighbourIP(ip, inc);
            if (neighbour != null)
            {
                Console.WriteLine("Scanning {0}", neighbour);
                inc = 0 - inc;
                if (inc > 0) inc++;
                ScanNet(ip,inc);

            }
            

            //for (int i = inc+1; i < 255; i++) ScanNet(ip, i-inc);
            //for (int i = inc-1; i >0 ; i--) ScanNet(ip, i - inc);



        }

        private string NeighbourIP(string ip, int inc)
        {
            string[] subNets = ip.Split('.');
            int nextSubnet = int.Parse(subNets[3]) + inc;
            if ((inc>0 && nextSubnet<=255) || (inc<0 && nextSubnet>=0))
              return string.Format("{0}.{1}.{2}.{3}", subNets[0], subNets[1], subNets[2], nextSubnet);
            //nextSubnet = int.Parse(subNets[2] + inc);
            
            return null;
        }


       
    }
}
