using System;

namespace CalculadoraNotasUnip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variaveis mediaAnual e mediaExame
            //Serão responsaveis para a validação do desvio condicional composto (if/else)
            //Receberam o retorno dos métodos de cálculo
            //calcularMediaAlunoAnual e calcularMediaExameFinal
            //criados dentro da classe Notas
            double mediaAnual, mediaExame;

            //Instaciar as classe Aluno e Notas para obter acesso
            //as propriedades e métodos de cada classe, desde que as mesmas
            //estejam como público
            Aluno objAluno = new Aluno();
            Notas objNotas = new Notas();

            //Nessa etapa os valores digitados em tela serão encapsulados
            //nas propriedades nota1, nota2, nota3 e nota4 contidos na classe Aluno
            Console.Write("Informar nota1: ");
            objNotas.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informar nota2: ");
            objNotas.Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informar nota3: ");
            objNotas.Nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informar nota4: ");
            objNotas.Nota4 = Convert.ToDouble(Console.ReadLine());

            //Será executado o método calcularMediaAlunoAnual com as propriedades
            //encapsuladas na classe Notas
            //o retorno da execução desse método retornará o valor para a variavel mediaAnual
            mediaAnual = objAluno.calcularMediaAlunoAnual(objNotas);

            //Desvio condicional composto para aplicar a regra de aprovação
            if (mediaAnual >= 7)
            {
                Console.Write(String.Format("Aluno aprovado na disciplina. Sua média é: {0}", mediaAnual));
                Console.ReadLine();
            }
            else
            {
                Console.Write(String.Format("Aluno devérá fazer a prova exame. Sua média é: {0}", mediaAnual));
                Console.ReadLine();
                Console.Write("Informar nota do Exame: ");
                objNotas.NotaExame = Convert.ToDouble(Console.ReadLine());


                //Será executado o método calcularMediaExameFinal com as propriedades
                //encapsuladas na classe Notas
                //o retorno da execução desse método retornará o valor para a variavel mediaExame
                mediaExame = objAluno.calcularMediaExameFinal(objNotas);

                //Desvio condicional composto para aplicar a regra de aprovação
                if (mediaExame >= 5)
                {
                    Console.Write(String.Format("Aluno aprovado na disciplina. Sua média é: {0}", mediaExame));
                    Console.ReadLine();
                }
                else
                {
                    Console.Write(String.Format("Aluno deverá cursar DP da disciplina. Sua média é: {0}", mediaExame));
                    Console.ReadLine();
                }
            }

        }
    }
}
