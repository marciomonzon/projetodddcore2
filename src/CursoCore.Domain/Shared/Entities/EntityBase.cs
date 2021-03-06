﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Shared.Entities
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            ListaErros = new List<string>();
        }

        public int Id { get; set; }
        public List<string> ListaErros { get; set; }

        // implementação obrigatoria
        public abstract bool EstaConsistente();
    }
}
