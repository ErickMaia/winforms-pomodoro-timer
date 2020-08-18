using Pomodoro.Entities;
using Pomodoro.Entities.Enums;
using Pomodoro.Entities.Exceptions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pomodoro
{
    public partial class MainForm : Form {

        private int pomodoroCount = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PomodoroTimer.Status != PomodoroStatus.Stopped)
            {

                PomodoroTimer.TimeCounting = PomodoroTimer.TimeCounting.Subtract(new TimeSpan(0, 0, 1));
                lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");

                if (PomodoroTimer.TimeCounting.TotalSeconds <= 0)
                {
                    PlayBell();

                    if (PomodoroTimer.Status == PomodoroStatus.Pomodoro)
                    {
                        pomodoroCount++;
                        if (pomodoroCount < 4)
                        {
                            PomodoroTimer.Status = PomodoroStatus.ShortBreak;
                            PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.ShortBreakTimeSpan.Ticks);
                        }
                        else
                        {
                            pomodoroCount = 0;
                            PomodoroTimer.Status = PomodoroStatus.LongBreak;
                            PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.LongBreakTimeSpan.Ticks);
                        }
                    }
                    else
                    {
                        PomodoroTimer.Status = PomodoroStatus.Pomodoro;
                        PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.PomodoroTimeSpan.Ticks);
                    }
                }
                UpdateLabelStatus();
            }
            else
            {
                if(lblStatus.ForeColor == Color.DarkGoldenrod)
                {
                    lblStatus.ForeColor = Color.Goldenrod;
                }
                else
                {
                    lblStatus.ForeColor = Color.DarkGoldenrod;
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (PomodoroTimer.Status == PomodoroStatus.Stopped)
            {

                btnSwitchPomodoro.Enabled = true;
                btnSwitchShortBreak.Enabled = true;
                btnSwitchLongBreak.Enabled = true;

                try
                {
                    PomodoroTimer.PomodoroTimeSpan = new TimeSpan(0, int.Parse(txtPomodoro.Text), 0);
                    PomodoroTimer.ShortBreakTimeSpan = new TimeSpan(0, int.Parse(txtShortBreak.Text), 0);
                    PomodoroTimer.LongBreakTimeSpan = new TimeSpan(0, int.Parse(txtLongBreak.Text), 0);
                    PomodoroTimer.TimeCounting = new TimeSpan(0, int.Parse(txtPomodoro.Text), 0);

                    PomodoroTimer.Status = PomodoroStatus.Pomodoro;
                    gpBoxMinutes.Enabled = false;
                    btnAction.Text = "&Stop (Alt + S)";
                    PlayBell();

                }
                catch (DomainException e1)
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show(e1.Message, Application.ProductName);
                    txtPomodoro.Focus();
                    txtPomodoro.SelectAll();
                }catch(Exception e1)
                {
                    MessageBox.Show(e1.Message, Application.ProductName);
                }
            }
            else
            {
                btnSwitchPomodoro.Enabled = false;
                btnSwitchShortBreak.Enabled = false;
                btnSwitchLongBreak.Enabled = false;

                btnAction.Text = "&Start (Alt + S)";
                gpBoxMinutes.Enabled = true;
                PomodoroTimer.StopCounting();
                PlayCancel();
            }
            lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");
            UpdateLabelStatus();

        }

        private void PlayBell()
        {
            SoundPlayer sp1 = new SoundPlayer(Application.StartupPath + @"\sounds\pomodorobell.wav");

            sp1.Play();
        }

        private void PlayCancel()
        {
            SoundPlayer sp1 = new SoundPlayer(Application.StartupPath + @"\sounds\pomodorocancel.wav");
            sp1.Play();

        }

        private void PlaySwitch()
        {
            SoundPlayer sp1 = new SoundPlayer(Application.StartupPath + @"\sounds\pomodoroswitch.wav");
            sp1.Play();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                PomodoroTimer.PomodoroTimeSpan = new TimeSpan(0, 25, 0);
                PomodoroTimer.ShortBreakTimeSpan = new TimeSpan(0, 5, 0);
                PomodoroTimer.LongBreakTimeSpan = new TimeSpan(0, 20, 0);
                PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.PomodoroTimeSpan.Ticks);

                txtPomodoro.Text = PomodoroTimer.PomodoroTimeSpan.TotalMinutes.ToString();
                txtShortBreak.Text = PomodoroTimer.ShortBreakTimeSpan.TotalMinutes.ToString();
                txtLongBreak.Text = PomodoroTimer.LongBreakTimeSpan.TotalMinutes.ToString();
                lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");

            }catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void UpdateLabelStatus()
        {
            switch (PomodoroTimer.Status)
            {
                case PomodoroStatus.Stopped:
                    lblStatus.Text = "Press start to begin";
                    lblStatus.ForeColor = Color.Goldenrod;
                    break;

                case PomodoroStatus.Pomodoro:
                    lblStatus.Text = "Pomodoro";
                    lblStatus.ForeColor = Color.Red;
                    break;

                case PomodoroStatus.ShortBreak:
                    lblStatus.Text = "Short Break";
                    lblStatus.ForeColor = Color.Green;
                    break;

                case PomodoroStatus.LongBreak:
                    lblStatus.Text = "Long Break";
                    lblStatus.ForeColor = Color.Green;
                    break;
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://icons8.com/icons/set/tomato--v2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.", Application.ProductName);
            }
        }

        private void gpBoxMinutes_Enter(object sender, EventArgs e)
        {

        }

        private void txtPomodoro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitchPomodoro_Click(object sender, EventArgs e)
        {
            pomodoroCount = 0;
            PomodoroTimer.Status = PomodoroStatus.Pomodoro;
            PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.PomodoroTimeSpan.Ticks);
            lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");
            UpdateLabelStatus();
            PlaySwitch();
        }

        private void btnSwitchShortBreak_Click(object sender, EventArgs e)
        {
            pomodoroCount = 0;
            PomodoroTimer.Status = PomodoroStatus.ShortBreak;
            PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.ShortBreakTimeSpan.Ticks);
            lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");
            UpdateLabelStatus();
            PlaySwitch();
        }
        private void btnSwitchLongBreak_Click(object sender, EventArgs e)
        {
            pomodoroCount = 0;
            PomodoroTimer.Status = PomodoroStatus.LongBreak;
            PomodoroTimer.TimeCounting = new TimeSpan(PomodoroTimer.LongBreakTimeSpan.Ticks);
            lblTime.Text = PomodoroTimer.TimeCounting.ToString(@"mm\:ss");
            UpdateLabelStatus();
            PlaySwitch();
        }

        
    }
}
