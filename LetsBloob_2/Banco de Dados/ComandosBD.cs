using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsBloob_2.Banco_de_Dados;

namespace LetsBloob_2.Banco_de_Dados
{
    internal class ComandosBD
    {

        //public DataSet GetDoadores()
        //{
        //    DbConnection conexao = class_Conexao_BD.GetConexao();
        //    DbCommand comando = class_Conexao_BD.GetComando(conexao);
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = "SELECT * FROM medico"; //instrucao sql
        //    DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
        //    DataSet ds = new DataSet(); // criamos o data set que vai ser populado
        //    adapter.Fill(ds, "medico"); // vai preencher nosso data set com o que veio da consulta
        //    return ds;

        //    //Da pra fazer com data reader ai usuaria o tipo DataTable ==> pesquise
        //    //DbDataReader reader = DAOUtils.GetDataReader(comando); //recupera os dados trazidos pela exec do comando
        //    //...
        //}

        //public void CadastrarDoadores()
        //{
        //    //fazer

        //}

        //public void Excluir(int id)
        //{
        //    DbConnection conexao = class_Conexao_BD.GetConexao();
        //    DbCommand comando = class_Conexao_BD.GetComando(conexao);
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = "DELETE FROM CONTATOS WHERE ID = @id"; //NAO CONCATENE!! DANGERRR
        //    comando.Parameters.Add(new SqlParameter("@id", id)); //Use parametros S2
        //    comando.ExecuteNonQuery(); //executa e nao traz nada
        //}
    }
}
