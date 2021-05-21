using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum HeroClass
    {
        Warrior,
        Archer,
        Mage,
    }
    public enum LogicState
    {
        Alive = 1,
        Defeated = 0,
        Dead = -1
    }
    public enum Tier
    {
        Common ,
        Rare = 10,
        Epic = 30,
        Legendary = 60
    }

    public enum WarriorWeapon
    {
        Sword,
        WarAxe,
        WarHammer,
    }

    public struct StatsBase
    {
        public double ATKBase;
        public double DEFBase;
        public double AGIBase;
        public double LCKBase;
        public double MAGBase;
        public double RESBase;
    }

    public struct LevelData
    {
        public int level;
        public int exp;
        public int expToNextLevel;
    }
}

