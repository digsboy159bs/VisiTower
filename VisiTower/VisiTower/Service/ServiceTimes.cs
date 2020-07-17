using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisiTower.Models;

namespace VisiTower.Service
{
    public class ServiceTimes
    {
        private List<Times> times = new List<Times>
        {
            new Times {Nome = "Barcelona", Status = "Ativo" , ImagemUrl = "Barcelona.png" },
            new Times {Nome = "Juventus", Status = "Ativo" , ImagemUrl = "JuventusCerto.png" },
            new Times {Nome = "Manchester City", Status = "Ativo" , ImagemUrl = "ManchesterCity.png" },
            new Times {Nome = "Liverpool", Status = "Ativo" , ImagemUrl = "Liverpool.png" }
        };

        public IEnumerable<Times> GetTimes()
        {
            return times;
        }
    }
}
