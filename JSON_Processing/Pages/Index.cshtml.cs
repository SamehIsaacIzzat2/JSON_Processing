using JSON_Processing.Services;
using JSON_Processing.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSON_Processing.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDomainModelService _domainModelService;
        private readonly IWebPageService _webPageService;

        public IndexModel(ILogger<IndexModel> logger, IWebPageService webPageService, IDomainModelService domainModelService)
        {
            _logger = logger;
            _webPageService = webPageService;
            _domainModelService = domainModelService;
        }

        public void OnGet()
        {
            /*  
                About Performance, based ont the lifetime of the files
                we can store the results and re - calcute them to be ready for users
            */

            /* 
                if they get changed frequently we should use a scheduler e.g. HangFire to process then store results 
                to be pre-calculated and ready for users 
                not valid anymore
             */

            /*
             * https://www.newtonsoft.com/json/help/html/Performance.htm
             * I will research for is deserializing Zip files better ? because size of zip file is significantly small
             * I use stream
             * use strong types
             * get only the needed fiels into memory 
             * only bring one file into memory at a time
             * 
             */

            //var result = _domainModelService.GetAllAttributes();

            var dashboards = _webPageService.GetAllDashboardPages();

            var layoutPages = _webPageService.GetAllLayoutPages("4f0d550f-5c9d-4cbd-8414-701c0caa29fa");

        }
    }
}