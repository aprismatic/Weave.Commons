using System;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    [DataContract]
    public abstract class DatasetBase : ICloneable
    {
        /// <summary>
        /// The name of the dataset
        /// </summary>
        /// <example>Customers</example>
        [DataMember(Order = 10)]
        public string DatasetName { get; set; }

        public abstract object Clone();
    }
}
