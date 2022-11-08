using HomeAccountant.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeAccountant.Controllers
{
    public class StatusController : ControllerBase
    {
        private readonly CommonInfo _commonInfo;
        public StatusController()
        {
            _commonInfo = new CommonInfo(
                Environment.MachineName,
                (Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly())!.GetName().Name,
                DateTime.Now,
                (Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly())?.GetName().Version?.ToString());
        }

        public CommonInfo Index()
        {
            return _commonInfo;
        }
    }
}
