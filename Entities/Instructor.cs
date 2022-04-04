

using Core.Abstract;

namespace Entities
{
    public class Instructor :IEntity
    {

        public int Id { get; set; }

        public string Fullname { get; set; } = null!;


        public string? ProfileImage { get; set; }

        public int? StudentCount { get; set; }   
    }
}