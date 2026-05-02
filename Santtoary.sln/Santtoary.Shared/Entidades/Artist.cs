using Santtoary.Shared.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialty { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Design> Designs { get; set; }
    }
}