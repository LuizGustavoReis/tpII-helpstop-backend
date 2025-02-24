using HelpApp.Domain.Validation;
using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region Atributos
        public int Id { get; set; }

        public string Name { get; set; }
        #endregion

        #region Constructorns 
        public Category(string name)
        {
            Name = name;
                
        }

        public ICollection<Product> Products { get; set; }

        #endregion

        #region valição 
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "invalida name, name is required");
            DomainExceptionValidation.When(name.Length < 3,
                "invalid name, too short, minimum 3 characters.");

            Name = name;


        }

        #endregion




    }
}
