using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class User : IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } //Doğum Tarihi
        public string NationalityId { get; set; } //Tc numarası
    }
}
