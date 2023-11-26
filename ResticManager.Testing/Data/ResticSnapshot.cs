namespace ResticManager.Testing.Data
{
    public class ResticSnapshot : ResticStorageMetadataBase
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string ShortGuid { get; set; }
        public string? Original { get; set; }
        public string? Parent { get; set; }
        public DateTime Time { get; set; }
        public string[] Paths { get; set; }
        public string? Hostname { get; set; }
        public string? Username { get; set; }
        public string[] Tags { get; set; }
        public string? ProgramVersion { get; set; }
    }
}
