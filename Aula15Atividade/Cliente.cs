﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15Atividade
{
    internal class Cliente
    {
        //atributos
        public string nome;
        public int idade;
        public Usuario usuario;

        //construtor
        public Cliente(string nome, int idade, Usuario usuario) 
        {
            this.nome = nome;
            this.idade = idade;
            this.usuario = usuario;
        }

        //metodos
    }
}
