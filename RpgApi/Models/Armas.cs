using RpgApi.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Data;

namespace RpgApi.Models
{
    public class Armas
    {
        public int Id { get; set; }        
        public string Nome { get; set; }        
        public int Dano { get; set; }       
        public Personagem Personagem { get; set; }
        public int PersonagemId { get; set; }         
    }
}