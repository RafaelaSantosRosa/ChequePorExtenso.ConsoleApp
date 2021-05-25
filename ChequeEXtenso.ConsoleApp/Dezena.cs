using System;

namespace ChequeEXtenso.ConsoleApp
{
    public class Dezena : Unidade
    {
        Unidade unidadeClasse;
        

        
        Numero numero1 = new Numero();

        //protected static string vinte = "vinte";
        //public string VerificarDe10a19(string numero)
        //{
        //    if (numero == "10")
        //       return("dez");
        //    if (numero == "11")
        //       return("onze");
        //    if (numero == "12")
        //       return("doze");
        //    if (numero == "13")
        //       return("treze");
        //    if (numero == "14")
        //       return("quatorze");
        //    if (numero == "15")
        //       return("quinze");
        //    if (numero == "16")
        //       return("dezessei");
        //    if (numero == "17")
        //       return("dezessete");
        //    if (numero == "18")
        //       return("dezoito");
        //    if (numero == "19")
        //       return("dezenove");

        //    return null;
        //}

        //public string VerificarDezena(string[] numero, Unidade unidadeClasse)
        //{
        //    if (numero[0] == "2")
        //    {
        //        return numero1.numero_extenso += vinte + " e " + unidadeClasse.VerificarUnidade(numero[0]);
        //    }

        //    return null;
        //}


        public string VerificaDe10a19(string montagem, int a, int c)
        {
            if (c == 0) montagem += ((a > 0) ? " e " : string.Empty) + "dez";
            else if (c == 1) montagem += ((a > 0) ? " e " : string.Empty) + "onze";
            else if (c == 2) montagem += ((a > 0) ? " e " : string.Empty) + "doze";
            else if (c == 3) montagem += ((a > 0) ? " e " : string.Empty) + "treze";
            else if (c == 4) montagem += ((a > 0) ? " e " : string.Empty) + "quatorze";
            else if (c == 5) montagem += ((a > 0) ? " e " : string.Empty) + "quinze";
            else if (c == 6) montagem += ((a > 0) ? " e " : string.Empty) + "dezesseis";
            else if (c == 7) montagem += ((a > 0) ? " e " : string.Empty) + "dezessete";
            else if (c == 8) montagem += ((a > 0) ? " e " : string.Empty) + "dezoito";
            else if (c == 9) montagem += ((a > 0) ? " e " : string.Empty) + "dezenove";
            return montagem;
        }

        public string VerificaDe20a90(string montagem, int a, int b, int c)
        {
            if (b == 1)
            {
                montagem = VerificaDe10a19(montagem, a, c);
            }
            else if (b == 2) montagem += ((a > 0) ? " e " : string.Empty) + "vinte";
            else if (b == 3) montagem += ((a > 0) ? " e " : string.Empty) + "trinta";
            else if (b == 4) montagem += ((a > 0) ? " e " : string.Empty) + "quarenta";
            else if (b == 5) montagem += ((a > 0) ? " e " : string.Empty) + "cinquenta";
            else if (b == 6) montagem += ((a > 0) ? " e " : string.Empty) + "sessenta";
            else if (b == 7) montagem += ((a > 0) ? " e " : string.Empty) + "setenta";
            else if (b == 8) montagem += ((a > 0) ? " e " : string.Empty) + "oitenta";
            else if (b == 9) montagem += ((a > 0) ? " e " : string.Empty) + "noventa";
            return montagem;
        }
    }
}
