using System;

namespace ChequeEXtenso.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Numero numero = new Numero();
            //    Unidade unidade = new Unidade();
            //    Dezena dezena = new Dezena();
            //    Conversor conversor = new Conversor();

            //    while (true)
            //    {

            //        try
            //        {
            //            Console.Write("Digite um número para ser escrito por extenso: ");
            //            numero.numero = Console.ReadLine();

            //            string[] numeroConvertido = conversor.Converte(numero.numero);

            //            numero.numero_extenso += unidade.VerificarUnidade(numeroConvertido[0]);
            //            numero.numero_extenso += dezena.VerificarDe10a19(numeroConvertido[0]);
            //            numero.numero_extenso += dezena.VerificarDezena(numeroConvertido);

            //            if (numeroConvertido[0] == "0")
            //            {
            //                Console.WriteLine("Não é possível efetuar cheques com valor nulo");
            //                Console.ReadLine();
            //                break;
            //            }

            //            if (numeroConvertido[0] == "1" )
            //                numero.numero_extenso += " real";

            //            else if (numeroConvertido[0] != "1")
            //                numero.numero_extenso += " reais";


            //            Console.WriteLine("Número extenso: " + numero.numero_extenso);
            //            Console.ReadLine();
            //            numero.numero_extenso = null;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            Console.ReadLine();
            //        }
            //    }
            //}

            Numero numeroClasse = new Numero();
            Unidade unidadeClasse = new Unidade();
            Dezena dezenaClasse = new Dezena();
            Centena centenaClasse = new Centena();
            VerificaPlural plural = new VerificaPlural();
            Base base1 = new Base(numeroClasse, unidadeClasse, centenaClasse, dezenaClasse, plural);

            while (true)
            {
                try
                {
                    Console.Write("Digite um número para ser escrito por extenso: ");
                    decimal valor = Convert.ToDecimal(Console.ReadLine());

                    base1.toExtenso(valor);
                    Console.WriteLine(base1.toExtenso(valor));
                    Console.ResetColor();
                    Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                Console.Clear();  
            }
        }
    }
}
