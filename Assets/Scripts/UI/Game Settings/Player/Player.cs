using System;
using UnityEngine;

namespace RTS.UI
{
    [Serializable]
    public class Player
    {
        private string _name;
        private Color _color;
        private bool isMainPlayer = false;

        public string Name => _name;
        public Color Color
        {
            get => _color;
            set => _color = value;
        }

        public bool IsMainPlayer => isMainPlayer;

        public Player(string name, Color color, bool _isMainPlayer = false)
        {
            _name = name;
            _color = color;
            isMainPlayer = _isMainPlayer;
        }
    }
}