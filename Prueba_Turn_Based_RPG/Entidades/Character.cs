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

        protected double ATKBase;
        protected double DEFBase;
        protected double AGIBase;
        protected double LCKBase;
        protected double MAGBase;
        protected double REGBase;

        #endregion

        #region Properties


        #endregion

        #region Constructors

        public Character(string name, int lifePoints)
        {
            this.name = name;
            this.lifePoints = lifePoints;
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
