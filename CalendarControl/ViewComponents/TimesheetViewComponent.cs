using CalendarControl.ViewComponents.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace CalendarControl.ViewComponents
{
    public class TimesheetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(TimesheetControlViewModel? model = null)
        {
            model ??= new TimesheetControlViewModel()
            {
                DisplayMode = DisplayMode.Day
            };
            return await RenderComponentAsync(model);
        }

        private async Task<IViewComponentResult> RenderComponentAsync(TimesheetControlViewModel viewModel)
        {
            await Task.CompletedTask;
            return View(viewModel);
        }
    }
}
