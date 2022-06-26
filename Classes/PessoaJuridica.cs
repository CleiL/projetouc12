using PROJETOUC12_CONTAS.Interface;

namespace PROJETOUC12_CONTAS.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        
        public string ?cnpj { get; set; }
        public string ?razaoSocial {get; set; }
        
        
        public override float pagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}