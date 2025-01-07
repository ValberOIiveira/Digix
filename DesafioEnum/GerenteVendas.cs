namespace DesafioEnum
{
    public class GerenteVendas : Vendedor, IGerente
    {
        public Regioes Regioes { get; set; }

        
       public GerenteVendas(string sName, double dSalario, double dSalarioMinimo, int iLicencasPremioRecebidas, TiposEmpregados empregados,StatusLicenca statusLicenca, Regioes regioes, double dComissao) 
           : base(sName, dSalario, dSalarioMinimo, iLicencasPremioRecebidas, empregados, statusLicenca, regioes, dComissao)
       {
           this.dComissao = dComissao;
       }
           
       

        public void autorizar()
        {
            // Exemplo de autorização de um pedido ou ação
            Console.WriteLine($"{sName}, Gerente de Vendas da região {Regioes}, autorizou a ação.");
        }

        // Implementação do método concedeAumento
        public bool concedeAumento()
        {
            // Exemplo de critérios para conceder aumento, por exemplo, baseado nas vendas
            if (this.dSalario >= this.dSalarioMinimo * 2) // Exemplo: salário maior que o dobro do salário mínimo
            {
                double aumento = 0.10 * this.dSalario; // Concede um aumento de 10%
                this.dSalario += aumento;
                Console.WriteLine($"Aumento concedido. Novo salário de {sName}: {this.dSalario}");
                return true;
            }
            else
            {
                Console.WriteLine($"{sName} não atende aos critérios para aumento.");
                return false;
            }
        }

        // Implementação do método autorizaLicenca
        public bool autorizaLincenca()
        {
            // Exemplo de critério: o gerente pode autorizar licença se o número de licenças recebidas for menor que 3
            if (this.iLicencasPremioRecebidas < 3)
            {
                Console.WriteLine($"{sName} autorizou a licença.");
                return true;
            }
            else
            {
                Console.WriteLine($"{sName} não pode autorizar mais licenças. Limite de licenças atingido.");
                return false;
            }
        }
    }
}