using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.Entities.Enums
{
    public enum PomodoroStatus : int
    {
        Stopped = 0, 
        Pomodoro = 1,
        ShortBreak = 2,
        LongBreak = 3
    }
}
