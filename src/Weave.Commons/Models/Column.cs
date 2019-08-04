using System;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    /// <summary>
    /// A column in a dataset.
    /// </summary>
    [DataContract]
    public class Column : ICloneable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class.
        /// </summary>
        public Column()
        {
            ColumnName = "";
            Tokenize = false;
        }

        /// <summary>
        /// The name of the column.
        /// </summary>
        /// <example>NRIC</example>
        [DataMember(Order = 0)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Whether this column should be tokenized.
        /// <para/>Defaults to false.
        /// </summary>
        [DataMember(Order = 1)]
        public bool Tokenize { get; set; }

        /// <summary>
        /// Metadata of the <see cref="Column"/>.
        /// <para/>Will not be processed by WEAVE.
        /// <para/>Can be any datatype or structure. <see cref="String"/> is recommended for compatibility.
        /// </summary>
        [DataMember(Order = 2)]
        public object ColumnMetadata { get; set; }

        /// <summary>
        /// Creates a new <see cref="Column"/> that is a deep copy of the current <see cref="Column"/>.
        /// </summary>
        public virtual object Clone()
        {
            return new Column()
            {
                ColumnName = ColumnName,
                Tokenize = Tokenize,
                ColumnMetadata = ColumnMetadata
            };
        }
    }
}
