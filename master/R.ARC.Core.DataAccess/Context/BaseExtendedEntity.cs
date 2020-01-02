using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAM.Core.DataAccess.Entities
{
    public class BaseExtendedEntity<T> where T : class
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        private string _extendedData { get; set; }

        [NotMapped]
        public T ExtendedData {
            get => _extendedData == null ? null : JsonConvert.DeserializeObject<T>(_extendedData);
            set => _extendedData = JsonConvert.SerializeObject(value);
        }
    }
}
