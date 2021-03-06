using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
 public abstract class Pessoa : IPessoa
 {
        protected Pessoa(string nome, Endereco endereco, float rendimento)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.rendimento = rendimento;
        }

        public string ?nome { get; set; }

    public Endereco ?endereco { get; set; }

    public float ?rendimento { get; set; }

    public abstract float PagarImposto(float rendimento);
     }
}
