namespace CalendarControl.ViewComponents.ViewModels
{
    public enum DisplayMode
    {
        Day, WorkWeek, CalendarWeek, Next7Days, Month, List
    }

    public class TimesheetControlViewModel
    {
        public DisplayMode DisplayMode { get; set; }
    }
}
