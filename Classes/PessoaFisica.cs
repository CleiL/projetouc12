using PROJETOUC12_CONTAS.Interface;

namespace PROJETOUC12_CONTAS.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf {get; set;}
        public DateTime ?dataNascimento { get; set; }
        
        public override float pagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}