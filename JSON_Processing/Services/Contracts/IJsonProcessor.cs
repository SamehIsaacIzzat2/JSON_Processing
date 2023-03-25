using JSON_Processing.Classes;

namespace JSON_Processing.Services.Contracts
{
    public interface IJsonProcessor<T>
    {
        public T SerializeJsonFile(string filePath);

        public List<string> GetFilesInFolder();
    }
}
