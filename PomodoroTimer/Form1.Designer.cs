namespace Pomodoro
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.gpBoxMinutes = new System.Windows.Forms.GroupBox();
            this.txtLongBreak = new System.Windows.Forms.TextBox();
            this.txtShortBreak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPomodoro = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSwitchPomodoro = new System.Windows.Forms.Button();
            this.btnSwitchShortBreak = new System.Windows.Forms.Button();
            this.btnSwitchLongBreak = new System.Windows.Forms.Button();
            this.gpBoxMinutes.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(145, 213);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(246, 54);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(209, 289);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(119, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "&Start (Alt + S)";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // gpBoxMinutes
            // 
            this.gpBoxMinutes.Controls.Add(this.txtLongBreak);
            this.gpBoxMinutes.Controls.Add(this.txtShortBreak);
            this.gpBoxMinutes.Controls.Add(this.label2);
            this.gpBoxMinutes.Controls.Add(this.label3);
            this.gpBoxMinutes.Controls.Add(this.label1);
            this.gpBoxMinutes.Controls.Add(this.txtPomodoro);
            this.gpBoxMinutes.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxMinutes.Location = new System.Drawing.Point(70, 20);
            this.gpBoxMinutes.Name = "gpBoxMinutes";
            this.gpBoxMinutes.Size = new System.Drawing.Size(396, 88);
            this.gpBoxMinutes.TabIndex = 9;
            this.gpBoxMinutes.TabStop = false;
            this.gpBoxMinutes.Text = "Time intervals (in minutes)";
            this.gpBoxMinutes.Enter += new System.EventHandler(this.gpBoxMinutes_Enter);
            // 
            // txtLongBreak
            // 
            this.txtLongBreak.Location = new System.Drawing.Point(240, 42);
            this.txtLongBreak.Name = "txtLongBreak";
            this.txtLongBreak.Size = new System.Drawing.Size(72, 18);
            this.txtLongBreak.TabIndex = 3;
            // 
            // txtShortBreak
            // 
            this.txtShortBreak.Location = new System.Drawing.Point(162, 42);
            this.txtShortBreak.Name = "txtShortBreak";
            this.txtShortBreak.Size = new System.Drawing.Size(72, 18);
            this.txtShortBreak.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Short Break";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Long Break";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pomodoro";
            // 
            // txtPomodoro
            // 
            this.txtPomodoro.Location = new System.Drawing.Point(83, 42);
            this.txtPomodoro.Name = "txtPomodoro";
            this.txtPomodoro.Size = new System.Drawing.Size(72, 18);
            this.txtPomodoro.TabIndex = 1;
            this.txtPomodoro.TextChanged += new System.EventHandler(this.txtPomodoro_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblStatus.Location = new System.Drawing.Point(9, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(518, 52);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Press start to begin";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 327);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tomato icon by Icons8";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSwitchPomodoro
            // 
            this.btnSwitchPomodoro.Enabled = false;
            this.btnSwitchPomodoro.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchPomodoro.Location = new System.Drawing.Point(51, 114);
            this.btnSwitchPomodoro.Name = "btnSwitchPomodoro";
            this.btnSwitchPomodoro.Size = new System.Drawing.Size(141, 23);
            this.btnSwitchPomodoro.TabIndex = 11;
            this.btnSwitchPomodoro.Text = "Switch to Pomodoro";
            this.btnSwitchPomodoro.UseVisualStyleBackColor = true;
            this.btnSwitchPomodoro.Click += new System.EventHandler(this.btnSwitchPomodoro_Click);
            // 
            // btnSwitchShortBreak
            // 
            this.btnSwitchShortBreak.Enabled = false;
            this.btnSwitchShortBreak.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchShortBreak.Location = new System.Drawing.Point(198, 114);
            this.btnSwitchShortBreak.Name = "btnSwitchShortBreak";
            this.btnSwitchShortBreak.Size = new System.Drawing.Size(141, 23);
            this.btnSwitchShortBreak.TabIndex = 12;
            this.btnSwitchShortBreak.Text = "Switch to Short Break";
            this.btnSwitchShortBreak.UseVisualStyleBackColor = true;
            this.btnSwitchShortBreak.Click += new System.EventHandler(this.btnSwitchShortBreak_Click);
            // 
            // btnSwitchLongBreak
            // 
            this.btnSwitchLongBreak.Enabled = false;
            this.btnSwitchLongBreak.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchLongBreak.Location = new System.Drawing.Point(345, 114);
            this.btnSwitchLongBreak.Name = "btnSwitchLongBreak";
            this.btnSwitchLongBreak.Size = new System.Drawing.Size(141, 23);
            this.btnSwitchLongBreak.TabIndex = 13;
            this.btnSwitchLongBreak.Text = "Switch to Long Break";
            this.btnSwitchLongBreak.UseVisualStyleBackColor = true;
            this.btnSwitchLongBreak.Click += new System.EventHandler(this.btnSwitchLongBreak_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 345);
            this.Controls.Add(this.btnSwitchLongBreak);
            this.Controls.Add(this.btnSwitchShortBreak);
            this.Controls.Add(this.btnSwitchPomodoro);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpBoxMinutes);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpBoxMinutes.ResumeLayout(false);
            this.gpBoxMinutes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox gpBoxMinutes;
        private System.Windows.Forms.TextBox txtLongBreak;
        private System.Windows.Forms.TextBox txtShortBreak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPomodoro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSwitchPomodoro;
        private System.Windows.Forms.Button btnSwitchShortBreak;
        private System.Windows.Forms.Button btnSwitchLongBreak;
    }
}

