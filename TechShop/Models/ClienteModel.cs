﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.App.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Documento { get; set; }
    }
}
