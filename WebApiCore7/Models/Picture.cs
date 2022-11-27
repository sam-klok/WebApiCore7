namespace WebApiCore7.Models
{
    public class Picture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Hash { get; set; }
        public Byte[]? PicData { get; set; }
    }
}
