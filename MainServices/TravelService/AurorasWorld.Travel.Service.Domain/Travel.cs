using AurorasWorld.Enums;
using System;
using System.Collections.Generic;

namespace AurorasWorld.Travel.Service.Domain
{
    public class Travel
    {
        public Guid Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime TravelDate { get; set; }
        public Languages Language { get; set; }
        public int PeopleAmount { get; set; }
        public decimal TotalCost { get; set; }       
        public IEnumerable<Catering> Caterings { get; set; }
        public IEnumerable<Suit> Suits { get; set; }
        public IEnumerable<Shoe> Shoes { get; set; }
        public Travel(Guid id, string fisrtName, string lastName, string email, DateTime travelDate, Languages language, int peopleAmount, decimal totalCost, IEnumerable<Catering> caterings, IEnumerable<Suit> suits, IEnumerable<Shoe> shoes)
        {
            Id = id;
            FisrtName = fisrtName;
            LastName = lastName;
            Email = email;
            TravelDate = travelDate;
            Language = language;
            PeopleAmount = peopleAmount;
            TotalCost = totalCost;
            Caterings = caterings;
            Suits = suits;
            Shoes = shoes;
        }
    }
}
