using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string HireDate { get; set; }

    public int StationAssignment { get; set; }
    public int Rent { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}