using DesafioEnum;

namespace DesafioEnum
{
    
    public class Empregado : Pessoa
    {
        public double dSalario { get; set; }
        public double dSalarioMinimo = 240;
        public int iLicencasPremioRecebidas;

        // Alteração: Renomeado para TipoEmpregado para deixar mais claro
        public TiposEmpregados TipoEmpregado { get; set; }
        public StatusLicenca StatusLicenca { get; set; }

        public Regioes regioes{ get; set; }

        public Empregado() { }

        public Empregado(string sName, double dSalario, double dSalarioMinimo, int iLicencasPremioRecebidas, TiposEmpregados tipoEmpregado, Regioes regioes, StatusLicenca statusLicenca)
        {
            this.sName = sName;
            this.dSalario = dSalario;
            this.dSalarioMinimo = dSalarioMinimo;
            this.iLicencasPremioRecebidas = iLicencasPremioRecebidas;
            this.TipoEmpregado = tipoEmpregado;
            this.StatusLicenca = statusLicenca;
            this.regioes = regioes;
        }

        public virtual double getSalario()
        {
            return dSalario;
        }

        public int getLicencasPremioRecebidas()
        {
            return iLicencasPremioRecebidas;
        }

        public void setSalario(double dSalario)
        {
            this.dSalario = dSalario;
        }

        public void setLicencasPremioRecebidas(int iLicencasPremioRecebidas)
        {
            this.iLicencasPremioRecebidas = iLicencasPremioRecebidas;
        }
    }

}
