using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Controllers
{
    public class BaseController : ControllerBase
    {
        public DatabaseConection databaseConection { get; private set; }

        public BaseController()
        {
            if (databaseConection == null)
                databaseConection = new DatabaseConection();
        }
    }
}
