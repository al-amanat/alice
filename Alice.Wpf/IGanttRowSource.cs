using System;

namespace Alice.Wpf
{
    /// <summary>
    /// Declaration of data structure used to display single GanttRow
    /// </summary>
    public interface IGanttRowSource
    {
        /// <summary>
        /// Gets label used to display on GanttBar
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets date used to calculate starting point of GanttBar
        /// </summary>
        DateTime From { get; set; }

        /// <summary>
        /// Gets date used to calculate ending point of GanttBar
        /// </summary>
        DateTime To { get; set; }
    }
}
