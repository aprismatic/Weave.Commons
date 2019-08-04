using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    /// <summary>
    /// Represents a dataset with columns and matching rows.
    /// </summary>
    [DataContract]
    public class Dataset : DatasetBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset"/> class.
        /// </summary>
        public Dataset()
        {
            DatasetName = "";
            Columns = new List<Column>();
            Rows = new List<List<object>>();
        }

        /// <summary>
        /// Array of columns in the dataset.
        /// </summary>
        [Required]
        [DataMember(Order = 20)]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// Array of array of data in the dataset.
        /// <para/>Data value objects <code>{}</code> can be any datatype.
        /// </summary>
        [Required]
        [DataMember(Order = 21)]
        public List<List<object>> Rows { get; set; }

        /// <summary>
        /// Whether the dataset is empty (no rows or columns).
        /// </summary>
        public bool IsEmpty => Rows.Count == 0 || Columns.Count == 0;

        /// <summary>
        /// Creates a new <see cref="Dataset"/> that is a deep copy of the current <see cref="Dataset"/>.
        /// </summary>
        public override object Clone()
        {
            var res = new Dataset()
            {
                DatasetName = DatasetName,
                DatasetMetadata = DatasetMetadata
            };

            foreach (var col in Columns)
                res.Columns.Add((Column)col.Clone());

            foreach (var row in Rows)
            {
                var newRow = new List<object>();
                foreach (var value in row)
                    newRow.Add(value);
                res.Rows.Add(newRow);
            }

            return res;
        }
    }
}
