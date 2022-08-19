using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBlood_2.Banco_de_Dados
{
    public static class Dados
    {
        public static List<Doador> listaDoadores = new List<Doador>()
        {
            new Doador ("Juriscreudo Lima", "12345678900",Convert.ToDateTime("1960-10-25"), "11978451236", "juriscreudolima@gmail.com", "Diabetes"),
            new Doador("Marcela Soares", "98765432100",Convert.ToDateTime("2002-10-30"),"11978453213","marcelasoares@gmail.com","Saudável"),
            new Doador("Cristian Lima","11932124578",Convert.ToDateTime("1962-12-07"),"11974457841","cristianlima@gmail.com","Colesterol"),
            new Doador("Bruno Venancio","84043292066",Convert.ToDateTime("1989-12-07"),"11975165541","brunovenancio@gmail.com","Colesterol"),
            new Doador("João de Menezes","82522790072",Convert.ToDateTime("1959-11-16"),"11987231564","joaodemenezes@gmail.com","Saudável"),
            new Doador("Marcelino Abrantes","31779827083",Convert.ToDateTime("1943-12-02"),"11978846543","marcelinoabrantes@gmail.com","Diabetes"),
            new Doador("Edna Felipe","63262031046",Convert.ToDateTime("1943-12-02"),"11975646532","soniafelipe@gmail.com","Saudável"),
            new Doador("Sónia Monteiro","85278227095",Convert.ToDateTime("1981-07-22"),"11938788751","soniamonteiro@gmail.com","Colesterol"),
            new Doador("Valéria Noronha","29902202080",Convert.ToDateTime("1982-04-12"),"11916546521","sonianoronha@gmail.com","Saudável"),

        };

        public static List<Bolsa> listaBolsas = new List<Bolsa>()
        {
            new Bolsa(Convert.ToDateTime("2022-10-25"),"Marcelo Lima","12345678900","Sírio Libanês","AB+","Diabetes"),
            new Bolsa(Convert.ToDateTime("2022-10-30"),"Ana Cristina","98765432100","Sírio Libanês","B+","Saudável"),
            new Bolsa(Convert.ToDateTime("2022-12-07"),"Marcelo Lima","11932124578","Sírio Libanês","AB-","Colesterol"),
            new Bolsa(Convert.ToDateTime("2022-12-07"),"Marcelo Lima","84043292066","Sírio Libanês","A-","Colesterol"),
            new Bolsa(Convert.ToDateTime("2022-11-16"),"Ana Cristina","82522790072","Sírio Libanês","O+","Saudável"),
            new Bolsa(Convert.ToDateTime("2022-12-02"),"Ana Cristina","31779827083","Sírio Libanês","AB+","Diabetes"),
            new Bolsa(Convert.ToDateTime("2022-12-02"),"Marcelo Lima","63262031046","Sírio Libanês","A+","Saudável"),
            new Bolsa(Convert.ToDateTime("2022-07-22"),"Ana Cristina","85278227095","Sírio Libanês","O-","Colesterol"),
            new Bolsa(Convert.ToDateTime("2022-04-12"),"Marcelo Lima","29902202080","Sírio Libanês","B-","Saudável"),

        };



    }
}
