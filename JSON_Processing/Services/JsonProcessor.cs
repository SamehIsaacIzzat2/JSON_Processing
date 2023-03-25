using JSON_Processing.Classes;
using JSON_Processing.Services.Contracts;
using Newtonsoft.Json;

namespace JSON_Processing
{
    public class JsonProcessor<T> : IJsonProcessor<T>
    {
        private readonly string DIRECTORY_PATH;//= 
        private readonly string FULL_EXTENTION;//= 

        public JsonProcessor(string directoryPath, string fullExtention= ".json")
        {
            DIRECTORY_PATH = directoryPath;
            FULL_EXTENTION = fullExtention;
        }

        public T SerializeJsonFile(string filePath)
        {
            //ToDo async
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                T domainModel = (T)serializer.Deserialize(file, typeof(T));

                return domainModel;
            }

        }

        public List<string> GetFilesInFolder()
        { 
            List<string> filePaths = new List<string>();

            DirectoryInfo directory = new DirectoryInfo(DIRECTORY_PATH);  

            //TODO: check if this would causes any performance issues 
            FileInfo[] Files = directory.GetFiles($"*{FULL_EXTENTION}"); 

            foreach (FileInfo file in Files)
            {
                 filePaths.Add(file.FullName);
            }

            return filePaths;
        }

    }
}
