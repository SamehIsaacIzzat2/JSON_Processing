using JSON_Processing.Classes;
using JSON_Processing.Services.Contracts;

namespace JSON_Processing.Services
{
    public class DomainModelService : JsonProcessor<DomainModel>, IDomainModelService
    {

        private const string m_directoryPath = "C:\\Users\\Sameh Isaac\\Downloads\\6126\\6126\\PROJECT_NAME\\PROJECT_NAME_MainModule\\Core\\DomainModel\\DomainModels";

        public DomainModelService() : base(m_directoryPath, ".diagram.json")
        {

        }

        public List<string> GetAllAttributes()
        {
            List<string> attributesNames = new List<string>();

            List<string> filesNames = GetFilesInFolder();

            foreach (string fileName in filesNames)
            {
                var domainModel = SerializeJsonFile(fileName);

                foreach (var domainSourceBinding in domainModel.DomainSourceBindings)
                {
                    if (domainSourceBinding?.Entity?.Attributes == null)
                    {
                        continue;
                    }
                    foreach (var attribute in domainSourceBinding?.Entity?.Attributes)
                    {
                        if (!string.IsNullOrEmpty(attribute.Name))
                        {
                            attributesNames.Add(attribute.Name);
                        }
                    }
                }
            }

            return attributesNames;
        }

    }
}
