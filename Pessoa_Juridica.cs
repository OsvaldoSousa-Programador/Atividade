namespace Atividade
{
    class Pessoa_Juridica
    {
        public string cnpj {get; protected set;}
        public string ie {get; protected set;}

        public override void Pagar_imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20/00;
            this.total = this.valor + this.valor_imposto;
        }
    }
    
}