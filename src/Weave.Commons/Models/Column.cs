using System;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    [DataContract]
    public class Column : ICloneable
    {
        public Column()
        {
            ColumnName = "";
            Tokenize = false;
        }

        /// <summary>
        /// The name of the column
        /// </summary>
        /// <example>NRIC</example>
        [DataMember(Order = 0)]
        public string ColumnName { get; set; }
        /// <summary>
        /// Whether this column should be tokenized
        /// <para/>Defaults to false
        /// </summary>
        [DataMember(Order = 1)]
        public bool Tokenize { get; set; }

        public virtual object Clone()
        {
            return new Column()
            {
                ColumnName = ColumnName,
                Tokenize = Tokenize
            };
        }
    }
}
