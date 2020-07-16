﻿using System;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;

namespace DevIO.Business.Services
{
    public class FornecedorService : BaseService
    {

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

        }


        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}