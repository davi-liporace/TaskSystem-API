using System.ComponentModel;

namespace TaskSistem_API.Enums
{
    public enum TaskStatus
    {
        [Description("To do")]
        ToDo = 1,
        [Description("Doing")]
        Doing= 2,
        [Description("Completed")]
        Completed = 3,
    }
}
