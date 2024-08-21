using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Areas.Admin.Pages.RotaPage
{
         public class PrintRotaModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public PrintRotaModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }


        public UserRota UserRota { get; set; } = default!;
        public List<UserTimeSheet> UserTimeSheets { get; set; } = default!;
        public string DateTitle { get; set; } = string.Empty;
        public int CurrentYear { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentWeek { get; set; }
        public int CurrentDay { get; set; }

        public int? RouteYear { get; set; }
        public int? RouteMonth { get; set; }
        public int? RouteWeek { get; set; }
        public int? RouteDay { get; set; }
        public string PreviousWeek { get; set; }
        public string PreviousWeekTitle { get; set; }
        public string NextWeek { get; set; }
        public string NextWeekTitle { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id, string date = null, string searchdate = null)
        {



            if (id == null || _context.UserRotas == null)
            {
                return NotFound();
            }

            var userclient = await _context.UserRotas.FirstOrDefaultAsync(m => m.Id == id);
            if (userclient == null)
            {
                return NotFound();
            }
            else
            {
                UserRota = userclient;
            }

            IQueryable<UserTimeSheet> query = _context.UserTimeSheets
         .Include(x => x.User)
         .Include(x => x.TimeSheet)
         .Where(m => m.PostCode == userclient.PostCode && m.TimesheetAcceptance == UniCare.Data.Model.Enum.TimesheetAcceptance.Accepted);

            DateTime now = DateTime.Now;
            if (date != null)
            {

                now = DateTime.Parse(date).AddDays(1);
            }

            if (searchdate != null)
            {
                now = DateTime.Parse(searchdate);
            }
            if (searchdate != null)
            {

                DateTitle = now.ToString("ddd dd MMM, yyyy");
                query = query
                 .Where(ob => ob.Date.Year == now.Year && ob.Date.Month == now.Month && ob.Date.Day == now.Day)
                 .AsQueryable();


            }
            else if (date != null)
            {
                DateTime startOfWeek = now.AddDays(-1 * Convert.ToInt32(now.DayOfWeek)).AddDays(1);
                DateTime endOfWeek = startOfWeek.AddDays(5);

                DateTitle = $"Week {startOfWeek.ToString("dd MMM yyyy")} - {endOfWeek.ToString("dd MMM yyyy")}";
                query = query
                  .Where(ob => startOfWeek <= ob.Date && ob.Date < endOfWeek)
                 .AsQueryable();

            }
            else
            {
                DateTitle = now.ToString("ddd dd MMM, yyyy");
                query = query
                    .Where(ob => ob.Date.Year == now.Year && ob.Date.Month == now.Month && ob.Date.Day == now.Day)
                    .AsQueryable();
            }


            UserTimeSheets = await query.OrderByDescending(x => x.Date).ToListAsync();
            DateTime mondayOfLastWeek = now.AddDays(-(int)now.DayOfWeek - 6);
            DateTime mondayOfNextWeek = now.AddDays(-(int)now.DayOfWeek + 8);
            PreviousWeek = mondayOfLastWeek.Date.ToString("dd MMMM yyyy");
            NextWeek = mondayOfNextWeek.Date.ToString("dd MMMM yyyy");
            PreviousWeekTitle = "Previous " + mondayOfLastWeek.Date.ToString("dd MMMM") + " to " + mondayOfLastWeek.Date.AddDays(4).ToString("dd MMMM");
            NextWeekTitle = "Next " + mondayOfNextWeek.Date.ToString("dd MMMM") + " to " + mondayOfNextWeek.Date.AddDays(4).ToString("dd MMMM");

            return Page();
        }

        private static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstMonday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstMonday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            if (firstWeek <= 1)
            {
                weekOfYear -= 1;
            }
            return firstMonday.AddDays(weekOfYear * 7);
        }
    }

}
