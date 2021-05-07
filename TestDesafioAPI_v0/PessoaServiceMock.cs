using Desafio_v0.Models;
using Desafio_v0.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDesafioAPI_v0
{
    public class PessoaServiceMock : IPessoaService
    {
        List<Pessoa> pessoas;
        public PessoaServiceMock()
        {
            pessoas = new List<Pessoa>()
                            {
                new Pessoa(){Id=1, Nome="Joao",
                    Sobrenome="Freire", Email="Joao@email.com"},
                new Pessoa(){Id=2, Nome="Mario",
                    Sobrenome="Quintana", Email="MarioQ@email.com"},
                new Pessoa(){Id=3, Nome="Arnaldo",
                    Sobrenome="Ferreira", Email="ArnaldoF@email.com"}

            };
        }

        public void AddPessoa(Pessoa item)
        {
            pessoas.Add(item);
        }

        public void DeletePessoa(int id)
        {
            pessoas.Remove(pessoas[id-1]);
        }

        public Pessoa GetPessoa(int id)
        {
            return pessoas[id-1];
        }

        public List<Pessoa> GetPessoas()
        {
            return pessoas;
        }

        public bool PessoaExists(int id)
        {
            if (pessoas[id-1]!=null)
            {
                return true;
            }
            return false;
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
