namespace DesafioEnum
{
    public class Vendedor : Empregado
    {
       public double dComissao { get; set; }

       public Vendedor(string sName, double dSalario, double dSalarioMinimo, int iLicencasPremioRecebidas, TiposEmpregados empregados,StatusLicenca statusLicenca, Regioes regioes, double dComissao) 
           : base(sName, dSalario, dSalarioMinimo, iLicencasPremioRecebidas, empregados, regioes, statusLicenca)
       {
           this.dComissao = dComissao;
       }

       public override double getSalario()
       {
         return (dComissao * 0.5) + 2500;
       }
    }
}
