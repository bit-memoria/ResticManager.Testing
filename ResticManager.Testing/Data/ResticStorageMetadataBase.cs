namespace ResticManager.Testing.Data
{
    public class ResticStorageMetadataBase
    {
        public long TotalFileCount { get; set; }
        public long TotalBlobCount { get; set; }
        public long TotalOriginSize { get; set; }
        public long TotalUncompressedSize { get; set; }
        public long TotalCompressedSize { get; set; }
        public double CompressionRatio { get; set; }
        public int CompressionProgress { get; set; }
        public double CompressionSpaceSaving { get; set; }
    }
}
