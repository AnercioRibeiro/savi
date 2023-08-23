using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class County
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Province Province { get; set; }
        //[ForeignKey("Province")]
        //public int ProvinceId { get; set; }
    }
}