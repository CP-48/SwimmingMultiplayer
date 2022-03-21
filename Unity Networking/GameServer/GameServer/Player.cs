using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class Player
    {
        public int id;
        public string userName;

        public Player(int _id, string _userName)
        {
            id = _id;
            userName = _userName;
        }
    }
}
