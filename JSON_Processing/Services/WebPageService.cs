using JSON_Processing.Classes;
using JSON_Processing.Classes.WepPage;
using JSON_Processing.Services.Contracts;

namespace JSON_Processing.Services
{
    public class WebPageService :  JsonProcessor<WebPage>, IWebPageService
    {

        private const string m_directoryPath = "C:\\Users\\Sameh Isaac\\Downloads\\6126\\6126\\PROJECT_NAME\\PROJECT_NAME_MainModule\\WebClient\\Pages\\Pages";
      
        public WebPageService(): base(m_directoryPath, ".page.json")
        {

        }

        public List<string> GetAllDashboardPages()
        {
           List<string> dashboardPages= new List<string>();

           List<string> filesNames= GetFilesInFolder();

            foreach (string fileName in filesNames)
            {
                var webPage = SerializeJsonFile(fileName);

                if (!string.IsNullOrEmpty(webPage.Title) && webPage.Title.ToLower().Contains("dashboard"))
                {
                    dashboardPages.Add(webPage.Title);
                }
            }

            return dashboardPages;
        }
        
        public List<string> GetAllLayoutPages(string layoutId)
        {
           List<string> pages = new List<string>();

           List<string> filesNames= GetFilesInFolder();

            foreach (string fileName in filesNames)
            {
                var webPage = SerializeJsonFile(fileName);

                if (!string.IsNullOrEmpty(webPage.LayoutId) && webPage.LayoutId == layoutId)
                {
                    pages.Add(webPage.Title);
                }
            }

            return pages;
        }
    }
}
