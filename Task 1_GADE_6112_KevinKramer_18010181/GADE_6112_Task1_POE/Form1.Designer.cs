namespace GADE_6112_Task1_POE
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblRnd = new System.Windows.Forms.Label();
            this.gBoxBattle = new System.Windows.Forms.GroupBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(785, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(785, 117);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblRnd
            // 
            this.lblRnd.AutoSize = true;
            this.lblRnd.Location = new System.Drawing.Point(782, 27);
            this.lblRnd.Name = "lblRnd";
            this.lblRnd.Size = new System.Drawing.Size(58, 17);
            this.lblRnd.TabIndex = 1;
            this.lblRnd.Text = "Round :";
            // 
            // gBoxBattle
            // 
            this.gBoxBattle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gBoxBattle.Location = new System.Drawing.Point(13, 13);
            this.gBoxBattle.Name = "gBoxBattle";
            this.gBoxBattle.Size = new System.Drawing.Size(684, 523);
            this.gBoxBattle.TabIndex = 2;
            this.gBoxBattle.TabStop = false;
            this.gBoxBattle.Text = "Battlefield";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(731, 191);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(179, 313);
            this.rtbInfo.TabIndex = 3;
            this.rtbInfo.Text = "";
            this.rtbInfo.TextChanged += new System.EventHandler(this.rtbInfo_TextChanged);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 500;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 548);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.gBoxBattle);
            this.Controls.Add(this.lblRnd);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Game Play";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblRnd;
        private System.Windows.Forms.GroupBox gBoxBattle;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Timer MainTimer;
    }
}

