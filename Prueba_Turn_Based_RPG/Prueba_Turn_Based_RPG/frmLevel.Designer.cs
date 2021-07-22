
namespace Prueba_Turn_Based_RPG
{
    partial class frmLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel));
            this.picBoxLevelBackground = new System.Windows.Forms.PictureBox();
            this.gBoxAction = new System.Windows.Forms.GroupBox();
            this.btnAction3 = new System.Windows.Forms.Button();
            this.btnAction2 = new System.Windows.Forms.Button();
            this.btnAction1 = new System.Windows.Forms.Button();
            this.btnAction0 = new System.Windows.Forms.Button();
            this.rtBoxBattleInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLevelBackground)).BeginInit();
            this.gBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxLevelBackground
            // 
            this.picBoxLevelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLevelBackground.BackgroundImage")));
            this.picBoxLevelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLevelBackground.Location = new System.Drawing.Point(-1, 0);
            this.picBoxLevelBackground.Name = "picBoxLevelBackground";
            this.picBoxLevelBackground.Size = new System.Drawing.Size(800, 350);
            this.picBoxLevelBackground.TabIndex = 0;
            this.picBoxLevelBackground.TabStop = false;
            this.picBoxLevelBackground.Click += new System.EventHandler(this.picBoxLevelBackground_Click);
            // 
            // gBoxAction
            // 
            this.gBoxAction.BackColor = System.Drawing.Color.SlateGray;
            this.gBoxAction.Controls.Add(this.btnAction3);
            this.gBoxAction.Controls.Add(this.btnAction2);
            this.gBoxAction.Controls.Add(this.btnAction1);
            this.gBoxAction.Controls.Add(this.btnAction0);
            this.gBoxAction.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAction.Location = new System.Drawing.Point(-1, 349);
            this.gBoxAction.Name = "gBoxAction";
            this.gBoxAction.Size = new System.Drawing.Size(800, 100);
            this.gBoxAction.TabIndex = 1;
            this.gBoxAction.TabStop = false;
            this.gBoxAction.Text = "Action";
            // 
            // btnAction3
            // 
            this.btnAction3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAction3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction3.Location = new System.Drawing.Point(600, 26);
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Size = new System.Drawing.Size(192, 60);
            this.btnAction3.TabIndex = 3;
            this.btnAction3.Text = "Escape";
            this.btnAction3.UseVisualStyleBackColor = false;
            // 
            // btnAction2
            // 
            this.btnAction2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAction2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction2.Location = new System.Drawing.Point(402, 26);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(192, 60);
            this.btnAction2.TabIndex = 2;
            this.btnAction2.Text = "Items";
            this.btnAction2.UseVisualStyleBackColor = false;
            // 
            // btnAction1
            // 
            this.btnAction1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAction1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction1.Location = new System.Drawing.Point(204, 26);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(192, 60);
            this.btnAction1.TabIndex = 1;
            this.btnAction1.Text = "Defend";
            this.btnAction1.UseVisualStyleBackColor = false;
            // 
            // btnAction0
            // 
            this.btnAction0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAction0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction0.Location = new System.Drawing.Point(6, 26);
            this.btnAction0.Name = "btnAction0";
            this.btnAction0.Size = new System.Drawing.Size(192, 60);
            this.btnAction0.TabIndex = 0;
            this.btnAction0.Text = "Attack";
            this.btnAction0.UseVisualStyleBackColor = false;
            // 
            // rtBoxBattleInfo
            // 
            this.rtBoxBattleInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtBoxBattleInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtBoxBattleInfo.Location = new System.Drawing.Point(12, 12);
            this.rtBoxBattleInfo.Name = "rtBoxBattleInfo";
            this.rtBoxBattleInfo.Size = new System.Drawing.Size(770, 50);
            this.rtBoxBattleInfo.TabIndex = 2;
            this.rtBoxBattleInfo.Text = "";
            // 
            // frmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.rtBoxBattleInfo);
            this.Controls.Add(this.gBoxAction);
            this.Controls.Add(this.picBoxLevelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLevel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevel_FormClosed);
            this.Load += new System.EventHandler(this.frmLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLevelBackground)).EndInit();
            this.gBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLevelBackground;
        private System.Windows.Forms.GroupBox gBoxAction;
        private System.Windows.Forms.RichTextBox rtBoxBattleInfo;
        private System.Windows.Forms.Button btnAction0;
        private System.Windows.Forms.Button btnAction3;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnAction1;
    }
}