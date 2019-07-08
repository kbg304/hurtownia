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
    
    [Route("api/pracownik")]
    public class PracownikController: Controller
    {
        private readonly HurtowniaDbContext _context;

        public PracownikController(HurtowniaDbContext context)
        {
            _context = context;
        }


        [Route("all")]
        [HttpGet]
        public async Task<IActionResult> GetAllPracownicy()
        {
            var pracownicy = await _context.Pracownicy.ToListAsync();

            if (pracownicy != null)
            {
               var pracownicyViewModel = new List<PracownikViewModel>();
               
                           foreach (var p in pracownicy)
                           {
                               pracownicyViewModel.Add(new PracownikViewModel()
                               {
                                   PracownikId = p.PracownikId,
                                   Imie = p.Imie,
                                   Nazwisko = p.Nazwisko,
                                   Stanowisko = p.Stanowisko,
                                   PensjaBrutto = p.PensjaBrutto
                               });
                           }
               
                           return Ok(pracownicyViewModel); 
            }

            return NotFound();
        }


        [Route("{id:min(1)}")]
        [HttpGet]
        public async Task<IActionResult> GetPracownikFromId(int id)
        {
            var pracownik = await _context.Pracownicy.FirstOrDefaultAsync(x => x.PracownikId.Equals(id));

            if (pracownik != null)
            {
                return Ok(new PracownikViewModel()
                {
                    PracownikId = pracownik.PracownikId,
                    Imie = pracownik.Imie,
                    Nazwisko = pracownik.Nazwisko,
                    Stanowisko = pracownik.Stanowisko,
                    PensjaBrutto = pracownik.PensjaBrutto
                });
            }

            return NotFound();
        }

        public async Task<IActionResult> Post([FromBody] CreatePracownik createPracownik)
        {
            var pracownik = new Pracownik()
            {
                Imie = createPracownik.Imie,
                Nazwisko = createPracownik.Nazwisko,
                Stanowisko = createPracownik.Stanowisko,
                PensjaBrutto = createPracownik.PensjaBrutto,
                Adres = createPracownik.Adres
            };

            await _context.Pracownicy.AddAsync(pracownik);
            await _context.SaveChangesAsync();

            return Created("Dodano pracownika", new PracownikViewModel()
            {
                Imie = pracownik.Imie,
                Nazwisko = pracownik.Nazwisko,
                Stanowisko = pracownik.Stanowisko,
                PensjaBrutto = pracownik.PensjaBrutto
            });
        }


        [Route("edit/{id:min(1)}")]
        [HttpPut]
        public async Task<IActionResult> EditPracownik([FromBody] EditPracownik editPracownik, int id)
        {
            var pracownik = await _context.Pracownicy.FirstOrDefaultAsync(x => x.PracownikId.Equals(id));

            if (pracownik != null)
            {
               pracownik.Imie = editPracownik.Imie;
               pracownik.Nazwisko = editPracownik.Nazwisko;
               pracownik.Stanowisko = editPracownik.Stanowisko;
               pracownik.PensjaBrutto = editPracownik.PensjaBrutto;
               pracownik.Adres = editPracownik.Adres;
               await _context.SaveChangesAsync();
               return Ok("Zmodyfikowano pracownika");
            }

            return NotFound();

        }

        [Route("{id:min(1)}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pracownik = await _context.Pracownicy.FirstOrDefaultAsync(x => x.PracownikId.Equals(id));

            _context.Pracownicy.Attach(pracownik);
            _context.Pracownicy.Remove(pracownik);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}