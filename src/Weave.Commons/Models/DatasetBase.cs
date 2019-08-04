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
        /// Metadata of the <see cref="Dataset"/>.
        /// <para/>Will not be processed by WEAVE.
        /// <para/>Can be any datatype or structure. <see cref="String"/> is recommended for compatibility.
        /// </summary>
        [DataMember(Order = 11)]
        public object DatasetMetadata { get; set; }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        public abstract object Clone();
    }
}
