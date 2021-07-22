using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemy : Character
    {
        #region Atributes
        #endregion

        #region Properties
        #endregion

        #region Constructors
       /*
        public Enemy(string name, int lifePoints, StatsBase statsBase)
                   : base(name, lifePoints, statsBase)
        {
        }
       */
        #endregion

        #region Methods
        public static bool isPartyDown(List<Enemy> party)
        {
            bool ret = true;
            if (party != null)
            {
                foreach (Enemy aux in party)
                {
                    if (aux.EstadoLogico == LogicState.Alive)
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }
        #endregion

        #region Operators
        #endregion


    }
}
