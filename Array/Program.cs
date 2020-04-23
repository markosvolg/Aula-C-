using System;
using System.Collections.Generic;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgramadeIdade();
            //FuncionarioSalario();
            //CalculoMediaVetor();
            // VetorComDoisProduto();
            //SomaComVetor();
            // List();

            List<Funcionario> lista = new List<Funcionario>();

            Console.WriteLine("Digite a quantidade de Funcionarios");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("ID : ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome : ");
                string Nome = Console.ReadLine();
                Console.Write("Salario : ");
                double Salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(Id,Nome,Salario));  //Cria Construtor que aceita parametros na classe Fucionario
                Console.WriteLine();
            }

            Console.WriteLine("Qual o ID do salario que você gostaria de aumentar ?");
            int searchID = int.Parse(Console.ReadLine());


            Funcionario fun = lista.Find(x => x.Id == searchID);

            if (fun != null)
            {
                Console.WriteLine("Inseri o percentual : ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.AumentoSalario(percentual);

            }
            else
            {
                Console.WriteLine("Id não encontrado");
            }

            Console.WriteLine("Salario Atualizado");
            foreach (Funcionario item in lista)
            {
                Console.WriteLine(item);
            }


            


        //    lista.Add();


        }

        private static void List()
        {
            List<string> lista = new List<string>();


            lista.Add("Marcos"); //Add adiciona no final da lista
            lista.Add("Julia");
            lista.Add("Heloisa");
            lista.Insert(0, "Shirley"); //Insert vai inserir na primeira posicao 


            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(lista.Count);


            string j1 = lista.Find(x => x[0] == 'H'); //Pega o primeiro nome que começa com a letra H
            Console.WriteLine(j1);

            string j2 = lista.FindLast(x => x[0] == 'S'); //Pega o ultimo nome que termina com a letra A
            Console.WriteLine(j2);


            int pos1 = lista.FindIndex(x => x[0] == 'S');//Pega a posicao na lista
            Console.WriteLine(pos1);

            List<string> lista2 = lista.FindAll(x => x.Length <= 5);

            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAll(x => x[0] == 'M');
        }

        private static void SomaComVetor()
        {
            int a = SomaComVetor(2, 3, 5, 2);



            Console.WriteLine(a);
        }

        public static int SomaComVetor(params int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];

            }

            return soma;
        }



        private static void VetorComDoisProduto()
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vetor[i] = new Produto { Name = nome, Preco = preco };


            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;

            }


            double avg = soma / n;

            Console.WriteLine("Media do Produto e " + avg);
        }

        private static void CalculoMediaVetor()
        {
            int N = int.Parse(Console.ReadLine());

            double[] vect = new double[N]; // Armazenando Vetor na memoria 



            for (int i = 0; i < N; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }



            double sum = 0.0;

            for (int i = 0; i < N; i++)
            {
                sum += vect[i];
            }

            double avg = sum / N;

            Console.WriteLine("Media" + avg);
        }
        
        private static void FuncionarioSalario()
        {
            Funcionario funcionario = new Funcionario();
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Digite seu Nome");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Salario");
            funcionario.Salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite seu Nome");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Salario");
            funcionario1.Salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite seu Nome");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Salario");
            funcionario2.Salario = double.Parse(Console.ReadLine());


            double media = (funcionario1.Salario + funcionario.Salario + funcionario2.Salario) / 3;

            Console.WriteLine("Salário médio = " + media);
        }
        

        private static void ProgramadeIdade()
        {
            Pessoa pessoa1 = new Pessoa();


            Console.WriteLine("Digite seu Nome");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Pessoa pessoa2 = new Pessoa();


            Console.WriteLine("Digite seu Nome");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade");
            pessoa2.Idade = int.Parse(Console.ReadLine());



            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("A pessoa mais velha e " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha e " + pessoa2.Nome);
            }
        }

        public void CalculoTriangulo()
        {
            Triangulo x, y;

            x = new Triangulo();

            y = new Triangulo();

            double ax, bx, cx, ya, yb, yc;

            Console.WriteLine("Entre com as medisa do Triangulo X:");


            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medisa do Triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
