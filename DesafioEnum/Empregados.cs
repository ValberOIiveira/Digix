using DesafioEnum;

namespace DesafioEnum
{
    public class Empregados
    {
        public int iNumeroMaximo = 50;
        public List<Empregado> aEmpregados;

        public int iNumeroEmpregados;

        public Empregados()
        {
            aEmpregados = new List<Empregado>();
            iNumeroEmpregados = 0;
        }

        // Modificado para incluir o Tipo de Empregado
        public void insere(TiposEmpregados tipo)
        {
            if (iNumeroEmpregados < iNumeroMaximo)
            {
                // Cria um novo empregado com tipo
                Empregado novoEmpregado = new Empregado();
                novoEmpregado.TipoEmpregado = tipo;  // Atribui o tipo ao novo empregado
                aEmpregados.Add(novoEmpregado);
                iNumeroEmpregados++;
            }
            else
            {
                Console.WriteLine("Não é possível adicionar mais empregados.");
            }
        }

        public void imprime()
        {
            foreach (Empregado empregado in aEmpregados)
            {
                Console.WriteLine($"Nome: {empregado.sName}, Tipo: {empregado.TipoEmpregado}, Salário: {empregado.dSalario}");
            }
        }

        public double doFolhaPagamento()
        {
            double dFolhaPagamento = 0;

            foreach (Empregado empregado in aEmpregados)
            {
                dFolhaPagamento += empregado.getSalario();
            }

            return dFolhaPagamento;
        }
    }
}
