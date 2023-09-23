﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersHub.RealtimeNetworking.Server
{
    public class Data
    {

        public class Player
        {
            public long id = 0;
            public string username = string.Empty;
            public int client = 0;
            public bool ready = false;
            public int team = 0;
        }

        public enum RoomType
        {
            HOST_MANAGED = 1
        }

        public class Room
        {
            public string id = string.Empty;
            public RoomType type = RoomType.HOST_MANAGED;
            public bool started = false;
            public int sceneIndex = 0;
            public long hostID = 0;
            public string hostUsername = string.Empty;
            public string password = string.Empty;
            public int maxPlayers = 100;
            public List<Player> players = new List<Player>();
        }

    }
}