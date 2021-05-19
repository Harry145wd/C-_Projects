using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Hero : Character
    {
        #region Atributes
        protected Weapon equippedWeapon;
        protected LevelData levelData;
        #endregion

        #region Properties


        public override Inventory Inventory
        {
            get { return this.inventory; }
            set 
            {
                if (value.MaxWeapons > 1)
                {
                    value.MaxWeapons = 1;
                    //eliminar las armas de mas
                }
                this.inventory = value;      
            }
        }
        public LevelData LevelData
        {
            get
            {
                return this.levelData;
            }
            set 
            {
                this.Level = value.level;
                this.Exp = value.exp;
                this.levelData.expToNextLevel = this.ExpToNextLevel;
            }
        }
        public int Level
        {
            get { return this.levelData.level; }
            set 
            {
            if(value>0)
                {
                    this.levelData.level = value;
                }
                else
                {
                    this.levelData.level = 1;
                }
            }
        }
        public int Exp
        {
            get { return this.levelData.exp; }
            set 
            { 
                if(value>-1)
                {
                    if(value<this.ExpToNextLevel)
                    {
                        this.levelData.exp = value;
                    }
                    else 
                    {
                        this.Exp = value - this.ExpToNextLevel;
                        this.Level += 1;
                    }
                        
                }
                else
                {
                    this.levelData.exp = 0;
                }
            }
        }
        public int ExpToNextLevel
        {
            get { return this.Level * 1000; } 
        }

        public Weapon EquippedWeapon
        {
            get 
            {
                return this.Inventory.Weapons[0];
            }
            set
            {
                this.Inventory.Weapons[0] = value;
            }
        }
        #endregion

        #region Constructors
        public Hero(string name, int lifePoints, StatsBase statsBase, Inventory inventory,LevelData levelData)
             : base(name, lifePoints, statsBase)
        {
            this.Inventory = inventory;
            this.LevelData = levelData;

        }
        #endregion

        #region Methods
        
        #endregion

        #region Operators
        #endregion

    }
}
