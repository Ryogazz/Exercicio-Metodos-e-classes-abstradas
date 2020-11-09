namespace Exercicio_Metodos_e_classes_abstradas.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIcome { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIcome)
        {
            Name = name;
            AnualIcome = anualIcome;
        }

        public abstract double Tax();
    }
}
