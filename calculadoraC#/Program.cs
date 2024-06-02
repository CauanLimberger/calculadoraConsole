namespace calculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o peração matematica você deseja fazer:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração"); 
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");

           

            int operacao = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;


            switch(operacao)
            {
                case 1:
                    {
                        resultado = Adicoa(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;  
                    }
                case 3:
                    {
                        resultado = Multiplicao(num1, num2);
                        break ;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                
                default:
                    Console.WriteLine("numero invalido, digite outro numero. ");
                    break;



            }

            Console.WriteLine("O resultado da operação com os numeros {0} e {1} é {2}", num1, num2, resultado);
            Console.ReadLine() ;
            



        } public static int Adicoa(int n1, int n2)
        {
            int resultado = n1 + n2;

            return resultado;
        }
        public static int Subtracao(int n1, int n2)
        {
            int resultado = n1 - n2;

            return resultado;
        }
        public static int Multiplicao(int n1, int n2)
        {
            int resultado = n1 * n2;

            return resultado;
        }
        public static int Divisao(int n1, int n2)
        {
            int resultado = n1 / n2;

            return resultado;
        }


    }        
}
