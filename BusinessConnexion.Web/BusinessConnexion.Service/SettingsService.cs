using BusinessConnexion.EntityFrameWork;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BusinessConnexion.Service
{
    class SettingsService
    {
        private readonly static BcxConnexionEntities context = new BcxConnexionEntities();
        public static IEnumerable<SelectListItem> GetTask()
        {
            var query = context.DataLookUp.Where(x=>x.DataLockId == 1).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return new SelectList(query, "Value", "Text");
        }
    }
}
