using Desafio_v0.Controllers;
using Desafio_v0.Data_Context;
using Desafio_v0.Models;
using Desafio_v0.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDesafioAPI_v0
{
    public class PessoaService_Test
    {
        PessoaServiceMock _service;
        List<Pessoa> _pessoas;

        public PessoaService_Test()
        {
            _service = new PessoaServiceMock();
            _pessoas = new List<Pessoa>()
            {
                new Pessoa(){Id=1, Nome="Joao",
                    Sobrenome="Freire", Email="Joao@email.com"},
                new Pessoa(){Id=2, Nome="Mario",
                    Sobrenome="Quintana", Email="MarioQ@email.com"},
                new Pessoa(){Id=3, Nome="Arnaldo",
                    Sobrenome="Ferreira", Email="ArnaldoF@email.com"}

            };
        }

        [Fact]
        public void Teste_Create_Action()
        {
            _service.AddPessoa(_pessoas[0]);
            var retorno =_service.PessoaExists(1);

            Assert.True(retorno);
        }

        [Fact]
        public void Teste_Update_Action()
        {
            _service.UpdatePessoa(_pessoas[0]);
            var valor_correto = "Maria";

            Assert.Equal(_pessoas[0].Nome, valor_correto);
        }

        }

    }
}
