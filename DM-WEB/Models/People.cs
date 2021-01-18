using System.Collections.Generic;
using System;
using DM_WEB.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DM_WEB.Models
{
    public class People
    {
        [Key]
        [Required(ErrorMessage = "Preencha o CPF.")]
        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF ja foi cadastrado.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o Nome Completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter ate {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha a Data de Nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Preencha o Sexo.")]
        public Sex Sex { get; set; }

        [Required(ErrorMessage = "Selecione um Estado Civil.")]
        [Display(Name = "Estado Civil")]
        public MaritialStatus MaritalStatus { get; set; }

        [Required(ErrorMessage = "Preencha o Estado de Residencia.")]
        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)",
            ErrorMessage = "Informe um estado valido.")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        // public class State
        // {
        //     public List<State> ListStates()
        //     {
        //         return new List<State>
        //         {
        //             new State {States = "Acre" },
        //             new State {States = "Alagoas" },
        //             new State {States = "Amapa" },
        //             new State {States = "Amazonas" },
        //             new State {States = "Bahia" },
        //             new State {States = "Ceara" },
        //             new State {States = "Distrito Federal" },
        //             new State {States = "Espirito Santo" },
        //             new State {States = "Goias" },
        //             new State {States = "Maranhao" },
        //             new State {States = "Mato Grosso" },
        //             new State {States = "Mato Grosso do Sul" },
        //             new State {States = "Minas Gerais" },
        //             new State {States = "Para" },
        //             new State {States = "Paraiba" },
        //             new State {States = "Parana" },
        //             new State {States = "Pernambuco" },
        //             new State {States = "Piaui" },
        //             new State {States = "Rio de Janeiro" },
        //             new State {States = "Rio Grande do Norte" },
        //             new State {States = "Rio Grande do Sul" },
        //             new State {States = "Rondonia" },
        //             new State {States = "Roraima" },
        //             new State {States = "Santa Catarina" },
        //             new State {States = "Sao Paulo" },
        //             new State {States = "Sergipe" },
        //             new State {States = "Tocantins" }
        //         };
        //     }
        // }

        [Required(ErrorMessage = "Preencha a Cidade de Residencia.")]
        [MaxLength(50, ErrorMessage = "O nome da cidade deve ter ate 50 caracteres.")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "Preencha o Endereco Residencial.")]
        [MaxLength(100, ErrorMessage = "O endereco residencial deve ter ate {1} caracteres.")]
        [Display(Name = "Logradouro")]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "Preencha o numero do endereco residencial.")]
        [MaxLength(10, ErrorMessage = "O numero do endereco deve ter ate {1} caracteres")]
        [Display(Name = "Número")]
        public string AddressNumber { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento do endereco deve ter ate {1} caracteres")]
        [Display(Name = "Complemento")]
        public string AddOnAddress { get; set; }

        [Required(ErrorMessage = "Preencha a renda mensal.")]
        [Display(Name = "Renda Mensal")]
        public decimal Income { get; set; }

    }
}