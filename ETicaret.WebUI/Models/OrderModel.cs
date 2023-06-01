﻿using ETicaret.Entities;

namespace ETicaret.WebUI.Models
{
    public class OrderModel
    {
        // Sonu model ille biten Classlarımız kullanıcıya veri göstermej ya da kullanıcıdan veri almak için kullandığımız classlarımızdır. buradaki alanlar 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string Cvc { get; set; }
        
        public CartModel CartModel { get; set; }


    }
}
