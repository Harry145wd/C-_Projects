using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Character
    {
        #region Atributes

        protected string name;
        protected int lifePoints;
        protected Inventory inventory;
        protected EstadoLogico estadoLogico;
        protected StatsBase statsBase; 
       

        #endregion

        #region Properties
        public string Name
        {
            get;
            set;
        }
        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
            set
            { 
            if(value >-1)
                {
                    this.lifePoints = value;
                }
            else
                {
                    this.lifePoints = 0;
                }
            }
        }
        public virtual Inventory Inventory
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
        public EstadoLogico EstadoLogico
        {
            get;
            set;
        }
        public StatsBase StatsBase
        {
            get
            {
                return this.statsBase;
            }
            set
            {
                if (value.ATKBase > 0)
                {
                    this.statsBase.ATKBase = value.ATKBase;
                }
                else
                {
                    this.statsBase.ATKBase = 1;
                }
                //ATK
                if (value.DEFBase > 0)
                {
                    this.statsBase.DEFBase = value.DEFBase;
                }
                else
                {
                    this.statsBase.DEFBase = 1;
                }
                //DEF
                if (value.AGIBase > 0)
                {
                    this.statsBase.AGIBase = value.AGIBase;
                }
                else
                {
                    this.statsBase.AGIBase = 1;
                }
                //AGI
                if (value.LCKBase > 0)
                {
                    this.statsBase.LCKBase = value.LCKBase;
                }
                else
                {
                    this.statsBase.LCKBase = 1;
                }
                //LCK
                if (value.MAGBase > 0)
                {
                    this.statsBase.MAGBase = value.MAGBase;
                }
                else
                {
                    this.statsBase.MAGBase = 1;
                }
                //MAG
                if (value.RESBase > 0)
                {
                    this.statsBase.RESBase = value.RESBase;
                }
                else
                {
                    this.statsBase.RESBase = 1;
                }
                //RES

            }
        }
        #endregion

        #region Constructors

        public Character(string name, int lifePoints, StatsBase statsBase)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            this.StatsBase = statsBase;
            this.EstadoLogico = EstadoLogico.Alive;
        }

        #endregion

        #region Methods

        protected string Attack(object target, int attackType)
        {
            return "";
        }


        #endregion

        #region Operators

        #endregion

    }
}
