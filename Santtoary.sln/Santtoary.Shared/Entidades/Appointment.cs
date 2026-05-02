using Santtoary.Shared.Entidades;
using Santtooary.Shared.Entidades;
using System;
using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int EstimatedHours { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
