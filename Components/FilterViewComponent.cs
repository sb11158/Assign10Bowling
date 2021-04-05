using Assign10Bowling.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign10Bowling.Components
{
    public class FilterViewComponent : ViewComponent 
    {
        private BowlingLeagueContext context;
        public FilterViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x)
                );
        }
    }
}
