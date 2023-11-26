using System.Diagnostics;
using System.Text.Json;
using System.Text;
using ResticManager.Testing.Data.ResticClient;

namespace ResticManager.Testing.Services
{
    public class ResticClientService
    {
        
        // await ResticClientService.GetRepositoryData();
        public static async Task<List<SnapshotModel>?> GetRepositoryData()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "restic",
                    RedirectStandardOutput = true,
                    Arguments = "snapshots --json"
                }
            };

            process.Start();

            var _jsonOutput = await process.StandardOutput.ReadToEndAsync();

            if (_jsonOutput == null) return null;

            var _ms = new MemoryStream(Encoding.UTF8.GetBytes(_jsonOutput));
            var _repositorySnapshots = await JsonSerializer.DeserializeAsync<List<SnapshotModel>>(_ms);


            return _repositorySnapshots;
        }


        // await ResticClientService.GetSnapshot(id);
        public static async Task<SnapshotModel?> GetSnapshot(string snapshotId)
        {

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "restic",
                    Arguments = $"snapshots {snapshotId} --json",
                    RedirectStandardOutput = true
                }
            };

            process.Start();

            var _jsonOutput = await process.StandardOutput.ReadToEndAsync();

            if (_jsonOutput == null) return null;

            var _ms = new MemoryStream(Encoding.UTF8.GetBytes(_jsonOutput));
            var _snapshots = await JsonSerializer.DeserializeAsync<List<SnapshotModel>>(_ms);

            return _snapshots?.FirstOrDefault();
        }
    }
}
