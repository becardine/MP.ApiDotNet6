using MP.ApiDotNet6.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodeErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }


        public Product(string name, string codeErp, decimal price) 
        {
            Validation(name, codeErp, price);
        }

        public Product(int id, string name, string codeErp, decimal price)
        {
            DomainValidationException.When(id < 0, "ID do produto deve ser informado");
            Id = id;
            Validation(name, codeErp, price);   
        }

        private void Validation(string name, string codeErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codeErp), "Código ERP deve ser informado");
            DomainValidationException.When(price < 0, "Preço deve ser informado");

            Name = name;
            CodeErp = codeErp;
            Price = price;
        }
    }
}
