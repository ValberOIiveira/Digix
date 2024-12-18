namespace Aula_20_OO_UML
{
    public class Escola
    {
        // Composicao:
        private Aluno aluno;
        private Professor professor;

        public Escola(string nomeAluno)
        {
            aluno = new Aluno(nomeAluno);
        }

        public void ContratarProfessor(Professor professor)
        {
             this.professor = professor;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {aluno.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}