using Microsoft.Extensions.Configuration;
using Weave.Commons.Models;

namespace Weave.Commons
{
    /// <summary>
    /// Interface for WEAVE authority node plugins.
    /// Plugins can be developed to process and store datasets when submitted,
    /// as well as update datasets in a data store.
    /// </summary>
    public interface IDatasetStore
    {
        /// <summary>
        /// Receives all configuration parameters.
        /// Called on WEAVE authority node startup.
        /// </summary>
        /// <param name="configuration">Application configuration properties.</param>
        /// <returns>
        /// Whether function completed successfully.
        /// </returns>
        bool LoadConfig(IConfiguration configuration);

        /// <summary>
        /// Receives a submitted dataset.
        /// Called whenever a dataset is ready (tokenized and joined).
        /// </summary>
        /// <param name="dataset">Ready tokenized dataset.</param>
        /// <returns>
        /// Whether function completed successfully.
        /// </returns>
        bool DatasetReady(Dataset dataset);

        /// <summary>
        /// Gets an update key and public key to update all datasets in data store.
        /// Called whenever datasets needs to be updated due to key changes.
        /// </summary>
        /// <param name="updateKey">Update key to update datasets with.</param>
        /// <param name="publicKey">Public key to update datasets with.</param>
        /// <returns>
        /// Whether function completed successfully.
        /// </returns>
        bool UpdateDatasets(byte[] updateKey, byte[] publicKey);
    }
}
