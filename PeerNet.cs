using System;
using System.Collections.Generic;
using System.Text;

namespace P2PNodeSimulator
{
    class PeerNet
    {
        public List<Peer> Peers;

        public PeerNet()
        {
            Peers = new List<Peer>();
        }

        public void AddPeer(string ip,string port)
        {
            Peers.Add(new Peer(ip, port,Peers.Count));
        }
    }
}
