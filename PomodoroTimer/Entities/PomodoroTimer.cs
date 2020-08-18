using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomodoro.Entities.Enums;
using Pomodoro.Entities.Exceptions;

namespace Pomodoro.Entities
{
    public static class PomodoroTimer
    {
        private static TimeSpan _pomodoroTimeSpan;
        private static TimeSpan _shortBreakTimeSpan;
        private static TimeSpan _longBreakTimeSpan;
        public static TimeSpan PomodoroTimeSpan {
            get
            {
                return _pomodoroTimeSpan;
            }
            set { 
                if (value.TotalMinutes > 50)
                {
                    throw new DomainException("Maximum pomodoro time span: 50 minutes");
                }
                else
                {
                    _pomodoroTimeSpan = new TimeSpan(value.Ticks);
                }
            } 
        }
        public static TimeSpan ShortBreakTimeSpan
        {
            get {
                return _shortBreakTimeSpan;
            }

            set {
                if (value.TotalMinutes > 10)
                {
                    throw new DomainException("Maximum short break time span: 10 minutes");
                }
                else
                {
                    _shortBreakTimeSpan = new TimeSpan(value.Ticks);
                }
            }
        }
        public static TimeSpan LongBreakTimeSpan
        {
            get
            {
                return _longBreakTimeSpan;
            }

            set
            {
                if (value.TotalMinutes > 30)
                {
                    throw new DomainException("Maximum long break time span: 30 minutes");
                }
                else
                {
                    _longBreakTimeSpan = new TimeSpan(value.Ticks);
                }
            }
        }
        public static PomodoroStatus Status { get; set; } = PomodoroStatus.Stopped;
        public static TimeSpan TimeCounting { get; set; } = new TimeSpan(PomodoroTimeSpan.Ticks);


        public static void StopCounting()
        {
            Status = PomodoroStatus.Stopped;
            TimeCounting = new TimeSpan(PomodoroTimeSpan.Ticks);
        }

       
    }
}
