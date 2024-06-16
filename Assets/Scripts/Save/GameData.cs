using System.Collections.Generic;
using System.Runtime.Serialization;
using RTS.Buildings;
using RTS.Units;

namespace RTS.Save
{
    [DataContract]
    public class GameData
    {
        [DataMember] public List<Building> Buildings;
        [DataMember] public List<Unit> Units;

        public GameData()
        {
            Buildings = new List<Building>();
            Units = new List<Unit>();
        }
    }
}