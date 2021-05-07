using Desafio_v0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_v0.Services
{
    public interface IPessoaService
    {
        List<Pessoa> GetPessoas();
        Pessoa GetPessoa(int id);
        void AddPessoa(Pessoa item);
        void UpdatePessoa(Pessoa item);
        void DeletePessoa(int id);
        bool PessoaExists(int id);
    }
}
