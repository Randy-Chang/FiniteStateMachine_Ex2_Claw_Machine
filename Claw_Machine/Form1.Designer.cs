namespace Claw_Machine
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPlayTimes = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.plGameZone = new System.Windows.Forms.Panel();
            this.pbObject2 = new System.Windows.Forms.PictureBox();
            this.pbObject1 = new System.Windows.Forms.PictureBox();
            this.pbClaw = new System.Windows.Forms.PictureBox();
            this.plBlackButton = new System.Windows.Forms.Panel();
            this.pbObject0 = new System.Windows.Forms.PictureBox();
            this.MainState = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.plGameZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObject0)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbPlayTimes);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(217, 16);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(70, 21);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time : 0";
            // 
            // lbPlayTimes
            // 
            this.lbPlayTimes.AutoSize = true;
            this.lbPlayTimes.Location = new System.Drawing.Point(81, 16);
            this.lbPlayTimes.Name = "lbPlayTimes";
            this.lbPlayTimes.Size = new System.Drawing.Size(110, 21);
            this.lbPlayTimes.TabIndex = 3;
            this.lbPlayTimes.Text = "PlayTimes : 0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // plGameZone
            // 
            this.plGameZone.Controls.Add(this.pbObject2);
            this.plGameZone.Controls.Add(this.pbObject1);
            this.plGameZone.Controls.Add(this.pbClaw);
            this.plGameZone.Controls.Add(this.plBlackButton);
            this.plGameZone.Controls.Add(this.pbObject0);
            this.plGameZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGameZone.Location = new System.Drawing.Point(0, 0);
            this.plGameZone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.plGameZone.Name = "plGameZone";
            this.plGameZone.Size = new System.Drawing.Size(500, 300);
            this.plGameZone.TabIndex = 1;
            // 
            // pbObject2
            // 
            this.pbObject2.Image = ((System.Drawing.Image)(resources.GetObject("pbObject2.Image")));
            this.pbObject2.Location = new System.Drawing.Point(257, 224);
            this.pbObject2.Name = "pbObject2";
            this.pbObject2.Size = new System.Drawing.Size(77, 60);
            this.pbObject2.TabIndex = 4;
            this.pbObject2.TabStop = false;
            // 
            // pbObject1
            // 
            this.pbObject1.BackColor = System.Drawing.Color.Transparent;
            this.pbObject1.Image = ((System.Drawing.Image)(resources.GetObject("pbObject1.Image")));
            this.pbObject1.Location = new System.Drawing.Point(131, 212);
            this.pbObject1.Name = "pbObject1";
            this.pbObject1.Size = new System.Drawing.Size(75, 72);
            this.pbObject1.TabIndex = 3;
            this.pbObject1.TabStop = false;
            // 
            // pbClaw
            // 
            this.pbClaw.Image = ((System.Drawing.Image)(resources.GetObject("pbClaw.Image")));
            this.pbClaw.Location = new System.Drawing.Point(0, 0);
            this.pbClaw.Name = "pbClaw";
            this.pbClaw.Size = new System.Drawing.Size(74, 74);
            this.pbClaw.TabIndex = 0;
            this.pbClaw.TabStop = false;
            // 
            // plBlackButton
            // 
            this.plBlackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plBlackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBlackButton.Location = new System.Drawing.Point(0, 285);
            this.plBlackButton.Name = "plBlackButton";
            this.plBlackButton.Size = new System.Drawing.Size(500, 15);
            this.plBlackButton.TabIndex = 2;
            // 
            // pbObject0
            // 
            this.pbObject0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbObject0.Location = new System.Drawing.Point(88, 212);
            this.pbObject0.Name = "pbObject0";
            this.pbObject0.Size = new System.Drawing.Size(14, 73);
            this.pbObject0.TabIndex = 5;
            this.pbObject0.TabStop = false;
            // 
            // MainState
            // 
            this.MainState.Enabled = true;
            this.MainState.Tick += new System.EventHandler(this.MainState_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 353);
            this.Controls.Add(this.plGameZone);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plGameZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbObject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObject0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel plGameZone;
        private System.Windows.Forms.PictureBox pbClaw;
        private System.Windows.Forms.Panel plBlackButton;
        private System.Windows.Forms.Label lbPlayTimes;
        private System.Windows.Forms.Timer MainState;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbObject1;
        private System.Windows.Forms.PictureBox pbObject2;
        private System.Windows.Forms.PictureBox pbObject0;
    }
}

