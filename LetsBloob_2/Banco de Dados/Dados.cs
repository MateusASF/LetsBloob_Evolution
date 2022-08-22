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
            new Doador ("Juriscreudo Lima", "12345678900","1960-10-25", "11978451236", "juriscreudolima@gmail.com", "Diabetes"),
            new Doador("Marcela Soares", "98765432100","2002-10-30","11978453213","marcelasoares@gmail.com","Saudável"),
            new Doador("Cristian Lima","11932124578","1962-12-07","11974457841","cristianlima@gmail.com","Colesterol"),
            new Doador("Bruno Venancio","84043292066","1989-12-07","11975165541","brunovenancio@gmail.com","Colesterol"),
            new Doador("João de Menezes","82522790072","1959-11-16","11987231564","joaodemenezes@gmail.com","Saudável"),
            new Doador("Marcelino Abrantes","31779827083","1943-12-02","11978846543","marcelinoabrantes@gmail.com","Diabetes"),
            new Doador("Edna Felipe","63262031046","1943-12-02","11975646532","soniafelipe@gmail.com","Saudável"),
            new Doador("Sónia Monteiro","85278227095","1981-07-22","11938788751","soniamonteiro@gmail.com","Colesterol"),
            new Doador("Valéria Noronha","29902202080","1982-04-12","11916546521","sonianoronha@gmail.com","Saudável"),
        };

        public static List<Bolsa> listaBolsas = new List<Bolsa>()
        {
            new Bolsa("10/10/2022","Marcelo Lima","12345678900","Sírio Libanês","AB+","Diabetes"),
            new Bolsa("05/01/2022","Ana Cristina","98765432100","Sírio Libanês","B+","Saudável"),
            new Bolsa("18/05/2022","Marcelo Lima","11932124578","Sírio Libanês","AB-","Colesterol"),
            new Bolsa("25/01/2022","Marcelo Lima","84043292066","Sírio Libanês","A-","Colesterol"),
            new Bolsa("19/02/2022","Ana Cristina","82522790072","Sírio Libanês","O+","Saudável"),
            new Bolsa("28/03/2022","Ana Cristina","31779827083","Sírio Libanês","AB+","Diabetes"),
            new Bolsa("04/07/2022","Marcelo Lima","63262031046","Sírio Libanês","A+","Saudável"),
            new Bolsa("02/09/2022","Ana Cristina","85278227095","Sírio Libanês","O-","Colesterol"),
            new Bolsa("10/08/2022","Marcelo Lima","29902202080","Sírio Libanês","B-","Saudável"),

        };



    }
}
