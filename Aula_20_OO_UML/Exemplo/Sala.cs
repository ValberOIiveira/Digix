namespace Aula_20_OO_UML
{
    public class Sala
    {
        public PortaSala PortaSala { get; set; }
        public Porta PortaAuxiliar { get; set; }
        public double MetragemQuadrada { get; set; }

        // Constructor corrected: Removed unnecessary instantiation and fixed the type mismatch
        public Sala(PortaSala portaSala, Porta portaAuxiliar, double metragemQuadrada)
        {
            PortaSala = portaSala;  // Direct assignment (no need for new PortaSala)
            PortaAuxiliar = portaAuxiliar;
            MetragemQuadrada = metragemQuadrada;
        }

        public void AbrirPortaAuxiliar()
        {
            PortaAuxiliar.Abrir();
        }
    }
}
