﻿using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.Pessoas;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories.Pessoas
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public IEnumerable<Pessoa> FindByName(string nome)
        {
            return Db.Pessoas.Where(p => p.Nome == nome);
        }
    }
}