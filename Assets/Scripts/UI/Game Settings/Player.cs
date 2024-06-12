using System;
using UnityEngine;

namespace RTS.UI
{
    [Serializable]
    public class Player
    {
        private string _name;
        private Color _color;

        public string Name => _name;
        public Color Color
        {
            get => _color;
            set => _color = value;
        }

        public Player(string name, Color color)
        {
            _name = name;
            _color = color;
        }
    }
}