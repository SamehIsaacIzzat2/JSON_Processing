namespace JSON_Processing.Classes
{
    public class DomainModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<DomainSourceBinding> DomainSourceBindings { get; set; }

    }
}
