using MP.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MP.ApiDotNet6.Domain.Entities
{
    public sealed class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }


        public Purchase(int productId, int personId, DateTime? date)
        {
            Validation(productId, personId, date);
        }
        
        public Purchase(int id, int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(id < 0, "Necessário informar o ID da compra");
            Id = id;
            Validation(productId, personId, date);
        }

        private void Validation(int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(productId < 0, "Necessário informar o ID do produto");
            DomainValidationException.When(personId < 0, "Necessário informar o ID do cliente");
            DomainValidationException.When(!date.HasValue, "Necessário informar a data da compra");

            ProductId = productId; 
            PersonId = personId;
            Date = date.Value;
        }
    }
}
