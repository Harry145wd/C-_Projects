using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipment
    {
        #region Atributes
        protected static int lastId;
        protected string name;
        protected int id;
        protected Tier tier;
        protected int value;
        #endregion

        #region Properties
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value<= lastId)
                {
                    this.id = Equipment.lastId + 1;
                }
                else
                {
                    this.id = value;
                }
                Equipment.lastId = this.id;
            }
        }

        public Tier Tier 
        {
            get
            {
                return this.tier;
            }
            set
            {
                this.tier = value;
            }
        }

        public int Value
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        static Equipment()
        {
            Equipment.lastId = 1;
        }
        public Equipment(string name,int id, Tier tier, int value)
        {
            this.name = name;
            this.ID = id;
            this.Tier = tier;
            this.Value = value;

        }
        #endregion

        #region Methods
        #endregion

        #region Operators
        #endregion
    }
}
