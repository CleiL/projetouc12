using PROJETOUC12_CONTAS.Interface;
namespace PROJETOUC12_CONTAS.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set;}
        public string ?endereco {get; set;}
        public string ?rendimento { get; set;}
        
        public abstract float pagarImposto(float rendimento);

    }
}