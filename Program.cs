using (System)
{
namespace Atividade
{
    class Program
    {
        static void Main (string[] args)
        {
            float val_pag;
                        Console.WirtLine("Informe Nome");
                        string var_nome = Console.Readline();
                        Console.WirtLine("Infome Endereço");
                        string var_endereco = Console.Readline();
                        Console.WirtLine("Pessoa Física (f) ou Juridica(j)");
                        string var_tipo = Console.Readline();
                        if(var_tipo == "f")
                        {
                            // -------- Pessoa Física --------
                            Pessoa_Fisica pf = new Pessoa_Fisica();
                            pf.nome = var_nome;
                            pf.endereco = var_endereco;
                            Console.WirtLine("Informe um CPF:");
                            pf.cpf - Console.Readline();
                            Console.WirtLine("Informe um RG:");
                            pf.rg = Console.Readline();
                            Console.WirtLine("Informe o valor da compra:");
                            val_pag = float.Parse(Console.Readline());
                            pf.Pagar_imposto(val_pag);

                            Console.WirtLine("--------- Pessoa Física ---------");
                            Console.WirtLine("Nome ..........: " + pf.nome);
                            Console.WirtLine("Endereço ......: " + pf.endereco);
                            Console.WirtLine("CPF ...........: " + pf.cpf);
                            Console.WirtLine("Rg ............: " + pf.rg);
                            Console.WirtLine("Valor da Compra: " + pf.valor.ToString("C"));
                            Console.WirtLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                            Console.WirtLine("Total a Pagar  : " + pf.total.ToString("C")); 
                        }
                        if (var_tipo == "j")
                        {
                           // -------- Pessoa Juridica --------
                            Pessoa_Juridica pj = new Pessoa_Juridica();
                            pj.nome = var_nome;
                            pj.endereco = var_endereco;
                            Console.WirtLine("Informe um CNPJ:");
                            pj.cnpj - Console.Readline();
                            Console.WirtLine("Informe um IE:");
                            pj.ie = Console.Readline();
                            Console.WirtLine("Informe o valor da compra:");
                            val_pag = float.Parse(Console.Readline());
                            pj.Pagar_imposto(val_pag);
                            
                            Console.WirtLine("--------- Pessoa Física ---------");
                            Console.WirtLine("Nome ..........: " + pj.nome);
                            Console.WirtLine("Endereço ......: " + pj.endereco);
                            Console.WirtLine("CPF ...........: " + pj.cpf);
                            Console.WirtLine("Rg ............: " + pj.rg);
                            Console.WirtLine("Valor da Compra: " + pj.valor.ToString("C"));
                            Console.WirtLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                            Console.WirtLine("Total a Pagar  : " + pj.total.ToString("C")); 
                        }    
        }
    }
}   
}
