using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentValidation;
using Hurtownia.Data;
using Hurtownia.Api.BindingModels;
using Hurtownia.Data.DAO;
//using Hurtownia.Api.Validation;
using Hurtownia.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace Hurtownia.Api.Controllers
{
    [Route("api/produkt")]
    public class ProduktController: Controller
    {
        private readonly HurtowniaDbContext _context;

        public ProduktController(HurtowniaDbContext context)
        {
            _context = context;
        }

        [Route("all")]
        [HttpGet]
        public async Task<IActionResult> GetAllProdukty()
        {
            var produkty = await _context.Produkty.ToListAsync();

            if (produkty != null)
            {
                var produktyViewModel = new List<ProduktViewModel>();

                foreach (var p in produkty)
                {
                    produktyViewModel.Add(new ProduktViewModel()
                    {
                        ProduktId = p.ProduktId,
                        Producent = p.Producent,
                        Model = p.Model,
                        Nazwa = p.Nazwa,
                        
                    });
                }

                return Ok(produktyViewModel);
                

            }

            return NotFound();
        }


        [Route("{id:min(1)}")]
        [HttpGet]
        public async Task<IActionResult> GetProduktFromId(int id)
        {
            var produkt = await _context.Produkty.FirstOrDefaultAsync(x => x.ProduktId.Equals(id));

            if (produkt != null)
            {
                var produktViewModel = new ProduktViewModel()
                {
                    ProduktId = produkt.ProduktId,
                    Producent = produkt.Producent,
                    Model = produkt.Model,
                    Nazwa = produkt.Nazwa,
           
                };

                return Ok(produktViewModel);
            }

            return NotFound();
        }

        [Route("edit/{id:min(1)}")]
        [HttpPut]
        public async Task<IActionResult> EditProdukt([FromBody] EditProdukt editProdukt, int id)
        {
            var produkt = await _context.Produkty.FirstOrDefaultAsync(x => x.ProduktId.Equals(id));

            if (produkt != null)
            {
                produkt.Producent = editProdukt.Producent;
                produkt.Model = editProdukt.Model;
                produkt.Nazwa = editProdukt.Nazwa;
                produkt.CenaNetto = editProdukt.CenaNetto;
                produkt.Kategoria = editProdukt.Kategoria;
                await _context.SaveChangesAsync();
                return Ok("Zmodyfikowano produkt");
            }

            return NotFound();
        }

        public async Task<IActionResult> Post([FromBody] AddProdukt addProdukt)
        {
            var produkt = new Produkt()
            {
                Producent = addProdukt.Producent,
                Model = addProdukt.Model,
                Nazwa = addProdukt.Nazwa,
                CenaNetto = addProdukt.CenaNetto,
                Kategoria = addProdukt.Kategoria
            };

            await _context.AddAsync(produkt);
            await _context.SaveChangesAsync();

            return Created("Dodano klienta", new ProduktViewModel()
            {
                Producent = produkt.Producent,
                Model = produkt.Nazwa,
                Nazwa = produkt.Nazwa,
                CenaNetto = produkt.CenaNetto,
             
            });

        }

        [Route("{id:min(1)}")]
        public async Task<IActionResult> Delete(int id)
        {
            var produkt = await _context.Produkty.FirstOrDefaultAsync(x => x.ProduktId.Equals(id));

            _context.Produkty.Attach(produkt);
            _context.Produkty.Remove(produkt);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}