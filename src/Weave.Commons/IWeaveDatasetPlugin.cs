using Microsoft.Extensions.Configuration;
using Weave.Commons.Models;

namespace Weave.Commons
{
    public interface IWeaveDatasetPlugin
    {
        void LoadConfig(IConfiguration configuration);
        void DatasetReady(Dataset dataset);
        void UpdateDatasets(byte[] updateKey, byte[] publicKey);
    }
}
