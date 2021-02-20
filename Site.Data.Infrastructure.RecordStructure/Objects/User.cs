namespace Site.Data.Infrastructure.RecordStructure.Objects
{
    public class User<TKey> : RecordBase<TKey>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public bool IsValidated { get; set; }
    }
}