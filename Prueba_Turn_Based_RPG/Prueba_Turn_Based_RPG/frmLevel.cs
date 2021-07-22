using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Prueba_Turn_Based_RPG
{
    public partial class frmLevel : Form
    {
        public frmLevelsMap levelsMap;
        public int levelPosition;
        public List<Hero> heroes;
        public List<Enemy> enemies;
        public frmLevel()
        {
            InitializeComponent();
            this.heroes = new List<Hero>();
            this.enemies = new List<Enemy>();
            this.heroes.Add(new Warrior());
            this.enemies.Add(new Enemy());
            this.enemies[0].EstadoLogico = LogicState.Dead;
        }
        public frmLevel(frmLevelsMap levelsMap) : this()
        {
            this.levelsMap = levelsMap;
        }
        public frmLevel(frmLevelsMap levelsMap, int levelPosition) : this(levelsMap)
        {
            this.levelPosition = levelPosition;
        }

        public bool haveWeWonThisLevel(List<Hero> heroes, List<Enemy> enemies)
        {
            bool ret = false;
            if (heroes!=null && enemies!= null &&!Hero.isPartyDown(heroes) && Enemy.isPartyDown(enemies))
            {
                ret = true;
            }
            return ret;
        }

        private void frmLevel_Load(object sender, EventArgs e)
        {
            this.levelsMap.Hide();
            //this.picBoxCharacter.Parent = this.picBoxLevelBackground;
            //this.picBoxEnemy.Parent = this.picBoxLevelBackground;
        }

        private void frmLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.haveWeWonThisLevel(this.heroes, this.enemies))
            {
                this.levelsMap.levelsCompleitionState[this.levelPosition] = true;
            }
        }
        private void frmLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.levelsMap.Show();
        }

        private void picBoxLevelBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
