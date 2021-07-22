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
    public partial class frmLevelsMap : Form
    {
        public frmMenu menu;
        public int howManyLevels;
        public bool[] levelsCompleitionState;
        public frmLevelsMap()
        {
            InitializeComponent();
            this.howManyLevels = 3;
            levelsCompleitionState = new bool[3];
            for(int i = 0; i<3; i++)
            {
                levelsCompleitionState[i]=false;
            }

        }

        public frmLevelsMap(frmMenu menu) : this()
        {
            this.menu = menu;
        }

        public frmLevelsMap(frmMenu menu, int howManyLevels) : this(menu)
        {
            this.howManyLevels = howManyLevels;
        }


        private void frmLevelsMap_Load(object sender, EventArgs e)
        {
            this.menu.Hide();
        }

        private void frmLevelsMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmLevelsMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menu.Show();
        }

        private void btnCherryForestLevel_Click(object sender, EventArgs e)
        {
            frmLevel level = new frmLevel(this,0);
            level.Show();
        }

        private void btnPassageCavesLevel_Click(object sender, EventArgs e)
        {
            if (levelsCompleitionState[0])
            {
                frmLevel level = new frmLevel(this,1);
                level.Show();
            }
            else
            {
                MessageBox.Show("We have to complete the previous level before, rushy head!","Hey!",MessageBoxButtons.OK);
            }
        }

        private void btnLittleVillageLevel_Click(object sender, EventArgs e)
        {
            if (levelsCompleitionState[1])
            {
                frmLevel level = new frmLevel(this,2);
                level.Show();
            }
            else
            {
                MessageBox.Show("We have to complete the previous level before, rushy head!", "Hey!", MessageBoxButtons.OK);
            }
        }
    }
}
