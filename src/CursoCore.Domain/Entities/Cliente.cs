using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoCore.Domain.Entities
{
    public class Cliente : Pessoa
    {

        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerTamanhoLimite();
            NomeDeveSerPreenchido();
            CpfCnpjDeveSerPreenchido();
            CpfCnpjDeveSerValido();
            EmailDeveSerValido();

            return !ListaErros.Any();
        }

        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListaErros.Add("Apelido deve ser preenchido!"); 
        }

        private void ApelidoDeveTerTamanhoLimite()
        {
            if (Apelido.Trim().Length > 20) ListaErros.Add("O campo apelido deve ter no máximo 20 caracteres!");
        }

        private void NomeDeveSerPreenchido()
        {
            if (Nome.Trim().Length > 20) ListaErros.Add("Nome deve ser preenchido!");
        }

        private void NomeDeveTerTamanhoLimite()
        {
            if (Nome.Trim().Length > 100) ListaErros.Add("O campo nome deve ter no máximo 100 caracteres!");
        }

        private void CpfCnpjDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(CpfCnpj.Numero)) ListaErros.Add("CPF/CNPJ deve ser preenchido!");
        }

        private void CpfCnpjDeveSerValido()
        {
            if (!CpfCnpj.Validar(CpfCnpj.Numero)) ListaErros.Add("CPF/CNPJ é inválido!");
        }

        private void EmailDeveSerValido()
        {
            if (!Email.Validar(Email.Endereco)) ListaErros.Add("Email inválido!");
        }
    }
}
