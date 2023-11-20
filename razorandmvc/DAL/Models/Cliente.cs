using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cliente
    {
        public string Cliid { get; set; }   
        public string Clinome { get; set; } 
        public string Clicpf {  get; set; } 
        public string Clidatanascimento { get; set; }   
        public string Cliendereco { get; set; } 
        public string Cliphone { get; set; }    
        public string Climail { get; set; } 
        public string Uidinsert {  get; set; }          
        public string UIddtInsert { get; set; }
        public string Uidupdate { get; set; }
        public string Uiddtupdate { get; set; }
    }
}
