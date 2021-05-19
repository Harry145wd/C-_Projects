using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventory
    {
        #region Atributes
        protected int slots;
        protected int maxWeapons;
        protected int maxArmor;
        protected List<Weapon> weapons;
        #endregion

        #region Properties
        public List<Weapon> Weapons 
        {
            get
            {
                return this.weapons;
            }
            set
            {
                if(value.Count<=this.MaxWeapons)
                {
                    this.weapons = value;
                }
            }
        }

        public int Slots
        {
            get { return this.slots; }
            set { this.slots = value; }
        }

        public int MaxWeapons
        {
            get 
            { 
                return this.maxWeapons; 
            }
            set 
            {
                if(value < this.Slots)
                {
                    this.maxWeapons = value;
                }
                else
                {
                    this.maxWeapons = this.Slots;
                }
            }
        }
        #endregion

        #region Constructors
        public Inventory(List<Weapon> weapons,int maxWeapons,int slots)
        {
            this.slots = slots;
            this.weapons = weapons;
            this.MaxWeapons = maxWeapons;
        }
        #endregion

        #region Methods
        #endregion

        #region Operators
        #endregion
    }
}
