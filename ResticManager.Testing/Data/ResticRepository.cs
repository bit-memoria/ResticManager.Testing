namespace ResticManager.Testing.Data
{
    public class ResticRepository : ResticStorageMetadataBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int SnapshotCount { get; set; }
        public int KeyCount { get; set; }
        public double DeduplicationRatio { get; set; }
    }
}
