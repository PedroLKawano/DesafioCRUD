﻿using Dapper;

namespace DesafioCRUD.Repositories
{
    public class GeneroRepository
    {
        public int BuscarGeneroId(string descricao)
        {
            using (var conexao = ConexaoSql.ObterConexao())
            {
                conexao.Open();

                return conexao.QueryFirstOrDefault<int>("SELECT Id FROM [Genero] WHERE Descricao = @Descricao", new { Descricao = descricao });
            }
        }
        public void CadastrarGenero(string descricao)
        {
            using (var conexao = ConexaoSql.ObterConexao())
            {
                conexao.Open();
                var generoId = conexao.QueryFirstOrDefault<int>("SELECT Id FROM [Genero] WHERE Descricao = @Descricao", new { Descricao = descricao });

                if(generoId == 0)
                    conexao.QueryFirstOrDefault<int>("SELECT Id FROM [Genero] WHERE Descricao = @Descricao", new { Descricao = descricao });                
            }
        }
    }
}