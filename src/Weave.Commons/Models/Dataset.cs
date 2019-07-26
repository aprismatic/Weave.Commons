using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Weave.Commons.Models
{
    [DataContract]
    public class Dataset : DatasetBase
    {
        public Dataset()
        {
            DatasetName = "";
            Columns = new List<Column>();
            Rows = new List<List<object>>();
        }

        /// <summary>
        /// Array of columns in the dataset
        /// </summary>
        [Required]
        [DataMember(Order = 20)]
        public List<Column> Columns { get; set; }
        /// <summary>
        /// Array of array of data in the dataset
        /// <para/>Data value objects <code>{}</code> can be any datatype
        /// </summary>
        [Required]
        [DataMember(Order = 21)]
        public List<List<object>> Rows { get; set; }

        public bool IsEmpty => Rows.Count == 0 || Columns.Count == 0;

        public override object Clone()
        {
            var res = new Dataset()
            {
                DatasetName = DatasetName
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
