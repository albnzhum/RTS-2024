﻿using System;

namespace RTS.Units
{
    [Serializable]
    public class Turret : Unit
    {
        public float MinAttackDistance = default;
        public float MaxAttackDistance = default;
        public int Damage = default;
        public int Capacity = default;
        
        public Turret(TurretSO turret) : base(turret)
        {
            MinAttackDistance = turret.MinAttackDistance;
            MaxAttackDistance = turret.MaxAttackDistance;
            Damage = turret.Damage;
            Capacity = turret.Capacity;
        }
    }
}