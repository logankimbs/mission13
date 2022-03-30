using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mission13.Models;

namespace mission13.Components
{
    public class FilterTeamsComponent : ViewComponent
    {
        private BowlersDbContext _context { get; set; }

        public FilterTeamsComponent(BowlersDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Teams = RouteData?.Values["teamName"] ?? "";

            var teams = _context.Bowlers.Select(bowler => bowler.Team.TeamName).Distinct().OrderBy(team => team);

            return View(teams);
        }
    }
}
