
namespace Exercicio_Metodos_e_classes_abstradas.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome ,int numberOfEmployees)
            :base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIcome * 0.14;
            }
            else
            {
                return AnualIcome * 0.16;
            }

        }
    }
}
