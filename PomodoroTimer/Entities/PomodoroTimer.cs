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
        public static TimeSpan PomodoroTimeSpan
        {
            get
            {
                return _pomodoroTimeSpan;
            }
            set
            {
                _pomodoroTimeSpan = new TimeSpan(value.Ticks);
            }
        }
        public static TimeSpan ShortBreakTimeSpan
        {
            get
            {
                return _shortBreakTimeSpan;
            }

            set
            {
                _shortBreakTimeSpan = new TimeSpan(value.Ticks);
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
                _longBreakTimeSpan = new TimeSpan(value.Ticks);
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
