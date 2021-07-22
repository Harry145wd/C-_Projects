
namespace Prueba_Turn_Based_RPG
{
    partial class frmLevelsMap
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelsMap));
            this.btnCherryForestLevel = new System.Windows.Forms.Button();
            this.btnPassageCavesLevel = new System.Windows.Forms.Button();
            this.btnLittleVillageLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCherryForestLevel
            // 
            this.btnCherryForestLevel.BackColor = System.Drawing.Color.LightPink;
            this.btnCherryForestLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCherryForestLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCherryForestLevel.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCherryForestLevel.Location = new System.Drawing.Point(63, 27);
            this.btnCherryForestLevel.Name = "btnCherryForestLevel";
            this.btnCherryForestLevel.Size = new System.Drawing.Size(114, 34);
            this.btnCherryForestLevel.TabIndex = 0;
            this.btnCherryForestLevel.Text = "1 - Cherry Forest";
            this.btnCherryForestLevel.UseVisualStyleBackColor = false;
            this.btnCherryForestLevel.Click += new System.EventHandler(this.btnCherryForestLevel_Click);
            // 
            // btnPassageCavesLevel
            // 
            this.btnPassageCavesLevel.BackColor = System.Drawing.Color.Peru;
            this.btnPassageCavesLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassageCavesLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassageCavesLevel.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassageCavesLevel.Location = new System.Drawing.Point(133, 166);
            this.btnPassageCavesLevel.Name = "btnPassageCavesLevel";
            this.btnPassageCavesLevel.Size = new System.Drawing.Size(119, 34);
            this.btnPassageCavesLevel.TabIndex = 1;
            this.btnPassageCavesLevel.Text = "2 - Passage Caves";
            this.btnPassageCavesLevel.UseVisualStyleBackColor = false;
            this.btnPassageCavesLevel.Click += new System.EventHandler(this.btnPassageCavesLevel_Click);
            // 
            // btnLittleVillageLevel
            // 
            this.btnLittleVillageLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLittleVillageLevel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLittleVillageLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLittleVillageLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLittleVillageLevel.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLittleVillageLevel.Location = new System.Drawing.Point(329, 166);
            this.btnLittleVillageLevel.Name = "btnLittleVillageLevel";
            this.btnLittleVillageLevel.Size = new System.Drawing.Size(119, 34);
            this.btnLittleVillageLevel.TabIndex = 2;
            this.btnLittleVillageLevel.Text = "3 - Little Village";
            this.btnLittleVillageLevel.UseVisualStyleBackColor = false;
            this.btnLittleVillageLevel.Click += new System.EventHandler(this.btnLittleVillageLevel_Click);
            // 
            // frmLevelsMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 489);
            this.Controls.Add(this.btnLittleVillageLevel);
            this.Controls.Add(this.btnPassageCavesLevel);
            this.Controls.Add(this.btnCherryForestLevel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLevelsMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLevelsMap_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevelsMap_FormClosed);
            this.Load += new System.EventHandler(this.frmLevelsMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCherryForestLevel;
        private System.Windows.Forms.Button btnPassageCavesLevel;
        private System.Windows.Forms.Button btnLittleVillageLevel;
    }
}

