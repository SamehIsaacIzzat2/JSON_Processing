using JSON_Processing.Classes;

namespace JSON_Processing.Services.Contracts
{
    public interface IDomainModelService : IJsonProcessor<DomainModel>
    {
        List<string> GetAllAttributes();

    }
}
