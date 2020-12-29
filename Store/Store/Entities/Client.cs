using System;

namespace Store.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Constructor
        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "Client: " + this.Name + " (" + this.BirthDate.ToString("dd/MM/yyyy") + ")" 
                   + " - " + this.Email;
        }
    }
}
