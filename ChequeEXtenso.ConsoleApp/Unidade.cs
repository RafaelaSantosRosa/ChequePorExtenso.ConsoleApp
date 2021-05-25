using System;


namespace ChequeEXtenso.ConsoleApp
{
    public class Unidade 
    {
        //public string numero = "";
        //public string VerificarUnidade(string numero)
        //{
        //    if (numero == "0")
        //        return "";
        //    if (numero == "1")
        //        return "um";
        //    if (numero == "2")
        //        return("dois");
        //    if (numero == "3")
        //        return("três");
        //    if (numero == "4")
        //        return("quatro");
        //    if (numero == "5")
        //        return("cinco");
        //    if (numero == "6")
        //        return("seis");
        //    if (numero == "7")
        //        return("sete");
        //    if (numero == "8")
        //        return("oito");
        //    if (numero == "9")
        //        return("nove");
        //    return null;
        //}

        public string VerificaUnidade(string montagem, int c)
        {
            if (c == 1) montagem += "um";
            else if (c == 2) montagem += "dois";
            else if (c == 3) montagem += "três";
            else if (c == 4) montagem += "quatro";
            else if (c == 5) montagem += "cinco";
            else if (c == 6) montagem += "seis";
            else if (c == 7) montagem += "sete";
            else if (c == 8) montagem += "oito";
            else if (c == 9) montagem += "nove";
            return montagem;
        }
    }
}
