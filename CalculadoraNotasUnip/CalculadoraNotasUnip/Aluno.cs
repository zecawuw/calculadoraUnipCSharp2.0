namespace CalculadoraNotasUnip
{
    public class Aluno
    {
        public double calcularMediaAlunoAnual(Notas objNotas)
        {
            //Regra de cálculo da média anual do aluno            
            double mediaAlunoAnual = (objNotas.Nota1 + objNotas.Nota2 + objNotas.Nota3 + objNotas.Nota4) / 4;
            return mediaAlunoAnual;
        }
        public double calcularMediaExameFinal(Notas objNotas)
        {
            //Regra de cálculo da média exame final do aluno
            double mediaExameFinal = (objNotas.MediaAnual + objNotas.NotaExame) / 2;
            return mediaExameFinal;
        }
    }
}