using System;
using System.Linq;

namespace TDDAno
{
    class Ano
    {
        public Ano()
        {
        }

        public String VerificarAnoBissexto(String StrAno)
        {
            try
            {
                /*String numeros = "0123456789";
                for (int i = 0; i < StrAno.Length; i++)
                {
                    if (!numeros.Contains(StrAno[i]))
                    {
                        return "Ano Invalido";
                    }
                }*/


                if (StrAno.Contains("+") || StrAno.Contains("-"))
                {
                    return "Ano Invalido";
                }

                int ano = Convert.ToInt32(StrAno);                
                if (ano % 100 == 0)
                {
                    return "Ano " + StrAno + (ano % 400 == 0 ? "" : " não") + " é Bissexto";
                }
                else
                {
                    return "Ano " + StrAno + (ano % 4 == 0 ? "" : " não") + " é Bissexto";
                }                
            }
            catch 
            {
                return "Ano Invalido";
            }
        }
    }
}