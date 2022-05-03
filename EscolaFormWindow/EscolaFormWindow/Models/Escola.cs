﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaFormWindow.Models
{
    class Escola
    {
        public int Id { get; set; }

        public string NomeFantasia { get; set; }

        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public string InscricaoEstadual { get; set; }

        public string Tipo { get; set; }

        public string NomeResponsavel { get; set; }

        public string TelefoneResponsavel { get; set; }

        public string TelefoneContato { get; set; }

        public string EmailContato { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Data { get; set; }

        public string Estado { get; set; }
    }
}
