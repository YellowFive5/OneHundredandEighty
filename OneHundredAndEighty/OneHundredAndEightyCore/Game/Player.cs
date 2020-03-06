﻿#region Usings

#endregion

namespace OneHundredAndEightyCore.Game
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }
        public string NickName { get; }

        public Player(string name, string nickName, int id = -1)
        {
            Id = id;
            Name = name;
            NickName = nickName;
        }

        public override string ToString()
        {
            return $"{Name} '{NickName}'";
        }
    }
}