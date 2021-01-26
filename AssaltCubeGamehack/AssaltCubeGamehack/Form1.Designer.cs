namespace AssaltCubeGamehack
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.SelectProccessLBL = new System.Windows.Forms.Label();
            this.HealthBT = new System.Windows.Forms.Button();
            this.AmmoBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PlayerDataBox = new System.Windows.Forms.GroupBox();
            this.AngleLBL = new System.Windows.Forms.Label();
            this.PositionLBL = new System.Windows.Forms.Label();
            this.BulletproofLBL = new System.Windows.Forms.Label();
            this.AmmoLBL = new System.Windows.Forms.Label();
            this.HealtthLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.HealthHLBL = new System.Windows.Forms.Label();
            this.AmmoHLBL = new System.Windows.Forms.Label();
            this.PlayerDataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLBL.Location = new System.Drawing.Point(215, 35);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(567, 65);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "Realrealize\'s GameHack";
            this.TitleLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectProccessLBL
            // 
            this.SelectProccessLBL.AutoSize = true;
            this.SelectProccessLBL.Location = new System.Drawing.Point(154, 130);
            this.SelectProccessLBL.Name = "SelectProccessLBL";
            this.SelectProccessLBL.Size = new System.Drawing.Size(145, 12);
            this.SelectProccessLBL.TabIndex = 1;
            this.SelectProccessLBL.Text = "프로세스를 선택해주세요.";
            // 
            // HealthBT
            // 
            this.HealthBT.Location = new System.Drawing.Point(156, 193);
            this.HealthBT.Name = "HealthBT";
            this.HealthBT.Size = new System.Drawing.Size(111, 23);
            this.HealthBT.TabIndex = 2;
            this.HealthBT.Text = "Health Hack";
            this.HealthBT.UseVisualStyleBackColor = true;
            this.HealthBT.Click += new System.EventHandler(this.HealthBT_Click);
            // 
            // AmmoBT
            // 
            this.AmmoBT.Location = new System.Drawing.Point(156, 228);
            this.AmmoBT.Name = "AmmoBT";
            this.AmmoBT.Size = new System.Drawing.Size(111, 23);
            this.AmmoBT.TabIndex = 2;
            this.AmmoBT.Text = "Ammo Hack";
            this.AmmoBT.UseVisualStyleBackColor = true;
            this.AmmoBT.Click += new System.EventHandler(this.AmmoBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(733, 325);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(75, 23);
            this.ExitBT.TabIndex = 2;
            this.ExitBT.Text = "닫기";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);// 프로세스를 선택했을 때 어떤 행동을 할지 정하는 얘
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);//클릭했을 때 프로세스 목록이 보여주도록
            // 
            // PlayerDataBox
            // 
            this.PlayerDataBox.Controls.Add(this.AngleLBL);
            this.PlayerDataBox.Controls.Add(this.PositionLBL);
            this.PlayerDataBox.Controls.Add(this.BulletproofLBL);
            this.PlayerDataBox.Controls.Add(this.AmmoLBL);
            this.PlayerDataBox.Controls.Add(this.HealtthLBL);
            this.PlayerDataBox.Location = new System.Drawing.Point(547, 144);
            this.PlayerDataBox.Name = "PlayerDataBox";
            this.PlayerDataBox.Size = new System.Drawing.Size(261, 136);
            this.PlayerDataBox.TabIndex = 4;
            this.PlayerDataBox.TabStop = false;
            this.PlayerDataBox.Text = "Player Data";
            // 
            // AngleLBL
            // 
            this.AngleLBL.AutoSize = true;
            this.AngleLBL.Location = new System.Drawing.Point(125, 28);
            this.AngleLBL.Name = "AngleLBL";
            this.AngleLBL.Size = new System.Drawing.Size(41, 12);
            this.AngleLBL.TabIndex = 0;
            this.AngleLBL.Text = "Angle:";
            this.AngleLBL.Click += new System.EventHandler(this.AmmoLBL_Click);
            // 
            // PositionLBL
            // 
            this.PositionLBL.AutoSize = true;
            this.PositionLBL.Location = new System.Drawing.Point(125, 60);
            this.PositionLBL.Name = "PositionLBL";
            this.PositionLBL.Size = new System.Drawing.Size(31, 12);
            this.PositionLBL.TabIndex = 0;
            this.PositionLBL.Text = "Pos:";
            this.PositionLBL.Click += new System.EventHandler(this.AmmoLBL_Click);
            // 
            // BulletproofLBL
            // 
            this.BulletproofLBL.AutoSize = true;
            this.BulletproofLBL.Location = new System.Drawing.Point(16, 95);
            this.BulletproofLBL.Name = "BulletproofLBL";
            this.BulletproofLBL.Size = new System.Drawing.Size(68, 12);
            this.BulletproofLBL.TabIndex = 0;
            this.BulletproofLBL.Text = "Bulletproof:";
            this.BulletproofLBL.Click += new System.EventHandler(this.AmmoLBL_Click);
            // 
            // AmmoLBL
            // 
            this.AmmoLBL.AutoSize = true;
            this.AmmoLBL.Location = new System.Drawing.Point(16, 60);
            this.AmmoLBL.Name = "AmmoLBL";
            this.AmmoLBL.Size = new System.Drawing.Size(46, 12);
            this.AmmoLBL.TabIndex = 0;
            this.AmmoLBL.Text = "Ammo:";
            this.AmmoLBL.Click += new System.EventHandler(this.AmmoLBL_Click);
            // 
            // HealtthLBL
            // 
            this.HealtthLBL.AutoSize = true;
            this.HealtthLBL.Location = new System.Drawing.Point(16, 28);
            this.HealtthLBL.Name = "HealtthLBL";
            this.HealtthLBL.Size = new System.Drawing.Size(44, 12);
            this.HealtthLBL.TabIndex = 0;
            this.HealtthLBL.Text = "Health:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HealthHLBL
            // 
            this.HealthHLBL.AutoSize = true;
            this.HealthHLBL.Location = new System.Drawing.Point(288, 198);
            this.HealthHLBL.Name = "HealthHLBL";
            this.HealthHLBL.Size = new System.Drawing.Size(57, 12);
            this.HealthHLBL.TabIndex = 5;
            this.HealthHLBL.Text = "동작 안함";
            // 
            // AmmoHLBL
            // 
            this.AmmoHLBL.AutoSize = true;
            this.AmmoHLBL.Location = new System.Drawing.Point(288, 233);
            this.AmmoHLBL.Name = "AmmoHLBL";
            this.AmmoHLBL.Size = new System.Drawing.Size(57, 12);
            this.AmmoHLBL.TabIndex = 5;
            this.AmmoHLBL.Text = "동작 안함";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 427);
            this.Controls.Add(this.AmmoHLBL);
            this.Controls.Add(this.HealthHLBL);
            this.Controls.Add(this.PlayerDataBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.AmmoBT);
            this.Controls.Add(this.HealthBT);
            this.Controls.Add(this.SelectProccessLBL);
            this.Controls.Add(this.TitleLBL);
            this.Name = "Form1";
            this.Text = "AssaultCube GameHack";
            this.PlayerDataBox.ResumeLayout(false);
            this.PlayerDataBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.Label SelectProccessLBL;
        private System.Windows.Forms.Button HealthBT;
        private System.Windows.Forms.Button AmmoBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox PlayerDataBox;
        private System.Windows.Forms.Label AmmoLBL;
        private System.Windows.Forms.Label HealtthLBL;
        private System.Windows.Forms.Label AngleLBL;
        private System.Windows.Forms.Label PositionLBL;
        private System.Windows.Forms.Label BulletproofLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label HealthHLBL;
        private System.Windows.Forms.Label AmmoHLBL;
    }
}

