using System;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Room
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
