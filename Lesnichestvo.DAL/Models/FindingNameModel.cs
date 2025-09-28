namespace Lesnichestvo.DAL.Models
{
    public class FindingNameModel
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FieldName { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
    }
}
