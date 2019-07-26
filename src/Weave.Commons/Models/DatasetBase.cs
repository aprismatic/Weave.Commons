using System;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    /// <summary>
    /// Base class for datasets.
    /// </summary>
    [DataContract]
    public abstract class DatasetBase : ICloneable
    {
        /// <summary>
        /// The name of the dataset.
        /// </summary>
        /// <example>Customers</example>
        [DataMember(Order = 10)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        public abstract object Clone();
    }
}
