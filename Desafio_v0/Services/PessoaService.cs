using Desafio_v0.Data_Context;
using Desafio_v0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_v0.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly PessoaContext _context;
        public PessoaService(PessoaContext context)
        {
            _context = context;
        }

        public void AddPessoa(Pessoa item)
        {
            _context.Pessoas.Add(item);
            _context.SaveChanges();
        }

        public void DeletePessoa(int id)
        {
            var Pessoa_by_Id = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(Pessoa_by_Id);
            _context.SaveChanges();
        }

        public Pessoa GetPessoa(int id)
        {
            return _context.Pessoas.Find(id);
        }

        public List<Pessoa> GetPessoas()
        {
            return _context.Pessoas.ToList();
        }

        public bool PessoaExists(int id)
        {
            if (_context.Pessoas.Find(id) != null)
                return true;
            else
                return false;
        }

        public void UpdatePessoa(Pessoa item)
        {
            _context.Pessoas.Update(item);
            _context.SaveChanges();
        }
    }
}
