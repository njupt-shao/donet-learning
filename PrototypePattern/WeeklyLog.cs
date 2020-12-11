using System;

namespace PrototypePattern
{
    public class WeeklyLog
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public WeeklyLog Clone()
        {
            return this.MemberwiseClone() as WeeklyLog;
        }
    }
}
