using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBlood_2.Banco_de_Dados
{
    public class Bolsa
    {
        public Bolsa()
        {
            
        }

        public DateTime DataColeta { get; set; }
        public string NomeMedico { get; set; }
        public string CpfDoador { get; set; }
        public string HospitalDestino { get; set; }
        public string ObservacaoBolsa { get; set; }
        public string TipoSanguineo { get; set; }

        public override string ToString()
        {
            return $"Data da Coleta: {DataColeta} | Nome Medico: {NomeMedico} | CPF Doador: {CpfDoador} | Hospital de Destino: {HospitalDestino} | Observação: {ObservacaoBolsa} | Tipo Sanguíneo: {TipoSanguineo}";
        }
    }
}
