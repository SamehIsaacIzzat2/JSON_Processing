namespace JSON_Processing.Classes.Domain
{
    public class Entity
    {
        public string Name { get; set; }
        //public string MappedTable { get; set; }
        public List<EntityAttribute>? Attributes { get; set; }
    }
}
