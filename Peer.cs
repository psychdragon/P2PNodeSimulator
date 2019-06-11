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
        //public Dictionary<int, string> GUIDList;

        public Peer(string ip, string port, int guid)
        {
            IP = ip;
            Port = port;
            GUID = guid;
            /* GUIDList = new Dictionary<int, string>();

            Peer neighbour = ScanPeers(); //Looks for any connected peer to retrieve routing table

            if (neighbour == null)
            {
                GUID = 0;
                GUIDList.Add(GUID, "http://" + IP + ":" + Port);

            }
            else
            {
                GUIDList = neighbour.GUIDList; //copy the routing table from neightbour
                GUID = GUIDList.Count; //assign next GUID to self
                //GUIDList.Add(GUID, "http://" + IP + ":" + Port); 
                neighbour.GUIDList.Add(GUID, "http://" + IP + ":" + Port);
            }
            */

            Console.WriteLine("Peer Created. http://{0}:{1} with GUID {2}", IP, Port, GUID);
        }


        /*
        private Peer ScanPeers()
        {
            Peer nextPeer=null;
            nextPeer = StepScan(IP, 1);
            if (nextPeer==null) StepScan(IP, -1);
            return nextPeer;
        }

        private Peer StepScan(string ip, int inc)
        {
            Peer nextPeer=null;
            string neighbour = NeighbourIP(ip, inc);
            if (ip != neighbour)
            {
                Console.WriteLine("Scanning {0}", neighbour);
                if (pingPeer(neighbour)) return new Peer(neighbour, Port);
                nextPeer = StepScan(neighbour, inc);
            }
            return nextPeer;
        }

        private bool pingPeer(string ip)
        {
            string[] ipList = { "192.168.0.200" };
            if (Array.IndexOf(ipList, ip) > -1)
            {
                Console.WriteLine("found {0}", ip);
                return true; //test only. to be removed.
            }
            return false; //if there is a response from peer, return true;
        }
       

        private string NeighbourIP(string ip, int inc)
        {
            string[] splitIP = ip.Split('.');
            int comp = int.Parse(splitIP[3]);
            if (comp + inc <= 255 && comp + inc >= 0)
                return string.Format("{0}.{1}.{2}.{3}", splitIP[0], splitIP[1], splitIP[2], (comp + inc).ToString());
            return ip;
        }
       */
    }
}
