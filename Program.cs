using System;

namespace P2PNodeSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peer peer1 = new Peer("192.168.0.100", "9988");
            PeerNet peerNet = new PeerNet();
            peerNet.AddPeer("192.168.0.100", "9988");
            peerNet.AddPeer("192.168.0.200", "9988");
            peerNet.AddPeer("192.168.0.250", "9988");
            peerNet.AddPeer("192.168.0.50", "9988");
        }
    }
}
