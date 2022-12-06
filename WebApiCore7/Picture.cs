namespace WebApiCore7
{
    public class Picture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Hash { get; set; }
        public byte[]? PicData { get; set; }
    }
}
