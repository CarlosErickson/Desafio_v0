using Desafio_v0.Models;
using Desafio_v0.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDesafioAPI_v0
{
    class PessoaServiceMock : IPessoaService
    {
        List<Pessoa> _pessoas;
        public PessoaServiceMock()
        {
            _pessoas = new List<Pessoa>();
        }

        public void AddPessoa(Pessoa item)
        {
            _pessoas.Add(item);
        }

        public void DeletePessoa(int id)
        {
            _pessoas.Remove(_pessoas[id-1]);
        }

        public Pessoa GetPessoa(int id)
        {
            return _pessoas[id-1];
        }

        public List<Pessoa> GetPessoas()
        {
            return _pessoas;
        }

        public bool PessoaExists(int id)
        {
            if (_pessoas[id-1]!=null)
            {
                return true;
            }
            return false;
            return true;
        }

        public void UpdatePessoa(Pessoa item)
        {
            item.Id = 1;
            item.Nome = "Maria";
            item.Sobrenome = "Freire";
            item.Email = "maria@email.com";
        }
    }
}
