using System;
using System.ComponentModel.DataAnnotations;

namespace DTO.Models
{
    public class Room
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
