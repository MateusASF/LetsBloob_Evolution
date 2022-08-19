using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBlood_2.Banco_de_Dados
{
    public class Doador
    {
        public Doador()
        {

        }
        public string NomeDoador { get; set; }
        public string CpfDoador { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }

        public override string ToString()
        {
            return $"Nome: {NomeDoador} | CPF: {CpfDoador} | Nascimento: {Nascimento} | Telefone: {Telefone} | Email: {Email} | Observação: {Observacao}";
        }
    }
}
