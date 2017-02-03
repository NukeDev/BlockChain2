﻿namespace BlockChain
{
    public class CHeader
    {
        public ulong BlockNumber;
        public string Hash;
        public string PreviusBlockHash;

        public CHeader(ulong BlockNumber, string Hash, string PreviusBlockHash)
        {
            this.BlockNumber = BlockNumber;
            this.Hash = Hash;
            this.PreviusBlockHash = PreviusBlockHash;
        }
    }
}