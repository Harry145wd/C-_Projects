using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Weapon : Equipment
    {
        #region Atributes
        protected HeroClass heroClass;
        protected int ATK;
        protected int WGH;
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public Weapon(string name, int id, Tier tier, int value, HeroClass heroClass, int ATK, int WGH) : base (name, id, tier,value)
        {
            this.heroClass = heroClass;
            this.ATK = ATK;
            this.WGH = WGH;
        }
        #endregion

        #region Methods
        #endregion

        #region Operators
        #endregion
    }
}
