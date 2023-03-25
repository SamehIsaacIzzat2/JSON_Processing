namespace JSON_Processing.Classes.Domain
{
    public class EntityAttribute
    {
        public string Name { get; set; }
        //public string Alias { get; set; }
        //public string Value { get; set; }
        //public Validation Validation { get; set; }
    }
    public class Validation
    {
        public bool? IsUnique { get; set; }
        public bool? IsRequired { get; set; }
        public bool? HaveValidation { get; set; }
        public string? AttributeId { get; set; }
        public bool? IsRequiredMessage { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreationDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModificationDate { get; set; }
        public string? DeletedBy { get; set; }
        public string? DeletionDate { get; set; }
        public string? Id { get; set; }

    }
}
