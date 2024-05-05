﻿namespace QuartzMysqlProject.Api.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }

    }
}
