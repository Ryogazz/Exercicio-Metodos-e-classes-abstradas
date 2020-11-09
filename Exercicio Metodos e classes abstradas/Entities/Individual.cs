using Exercicio_Metodos_e_classes_abstradas.Entities;

namespace Exercicio_Metodos_e_classes_abstradas.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualincome, double helthExpenditures)
            : base(name, anualincome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIcome < 20000.0)
            {
                return AnualIcome * 0.15 - HelthExpenditures * 0.5;
            }
            else
            {
                return AnualIcome * 0.25 - HelthExpenditures * 0.5;
            }
                
        }
    }


}
