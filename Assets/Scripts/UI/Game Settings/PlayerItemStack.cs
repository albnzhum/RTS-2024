using System;
using UnityEngine;

namespace RTS.UI
{
    [Serializable]
    public class PlayerItemStack
    {
        [SerializeField] private Player _player;

        public Player Player => _player;

        public PlayerItemStack()
        {
            _player = null;
        }

        public PlayerItemStack(PlayerItemStack stack)
        {
            _player = stack.Player;
        }

        public PlayerItemStack(Player player)
        {
            _player = player;
        }
    }
}