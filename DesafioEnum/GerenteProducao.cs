namespace DesafioEnum
{
    public class GerenteProducao : Empregado, IGerente
    {

        public GerenteProducao(string sName, double dSalario, double dSalarioMinimo, int iLicencasPremioRecebidas, TiposEmpregados empregados, Regioes regioes, StatusLicenca statusLicenca) 
           : base(sName, dSalario, dSalarioMinimo, iLicencasPremioRecebidas, empregados, regioes, statusLicenca)
       {
           
       }


        public void autorizar()
        {
            // Exemplo de autorização de um pedido ou ação
            Console.WriteLine($"{sName}, Gerente de Vendas {sName}, autorizou a ação.");
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