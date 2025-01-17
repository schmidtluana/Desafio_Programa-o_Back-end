﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using treinamento.Models;

namespace treinamento.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CafeController : ApiController
    {
        
        // GET: api/Cafe
        public IEnumerable<dynamic> Get()
        {
            using (programa_GODEVEntities bd = new programa_GODEVEntities())
            {
                var cafes = from ca in bd.cafe
                            select new { ca.id, ca.nome, ca.lotacao };
                return cafes;
            }
                
        }

        // GET: api/Cafe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cafe
        public string Post([FromBody] cafe caf)
        {
            using (programa_GODEVEntities bd = new programa_GODEVEntities())
            {
                bd.cafe.Add(caf);
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
               
        }

        // PUT: api/Cafe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cafe/5
        public void Delete(int id)
        {
        }
    }
}
