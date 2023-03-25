using JSON_Processing.Classes.WepPage;

namespace JSON_Processing.Services.Contracts
{
    public interface IWebPageService: IJsonProcessor<WebPage>
    {
        List<string> GetAllDashboardPages();
        List<string> GetAllLayoutPages(string layoutId);

    }
}
