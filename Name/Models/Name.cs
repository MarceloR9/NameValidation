using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name.Models
{
    public class Name
    {
        
        public void ValidarName(string nameDigitado) 
        {
            

            if (nameDigitado != "Marcelo")
            {
                Console.WriteLine("Nome incorreto! Digite novamente");
            }

            else 
            {
                Console.WriteLine("Seja bem vindo de volta!");
            }
        }
    }
}
