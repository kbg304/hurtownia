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
    
    [Route("api/klient")]
public class KlientController: Controller
{
    private readonly HurtowniaDbContext _context;

    public KlientController(HurtowniaDbContext context)
    {
        _context = context;
    }

    [Route("all")]
    [HttpGet]
    public async Task<IActionResult> GetAllKlienci()
    {
        var klienci = await _context.Klienci.ToListAsync();
        var adresy = await _context.Adresy.ToListAsync();

        if (klienci != null)
        {
            var klienciViewModel = new List<KlientViewModel>();

            foreach (var k in klienci)
            {
                klienciViewModel.Add(new KlientViewModel()
                {
                    KlientId = k.KlientId,
                    Imie = k.Imie,
                    Nazwisko = k.Nazwisko,
                    Email = k.Email
                });   
            }
            
            return Ok(klienciViewModel);
        }

        return NotFound();
    }

    [Route("{id:min(1)}")]
    [HttpGet]
    public async Task<IActionResult> GetKlientFromId(int id)
    {
        var klient = await _context.Klienci.FirstOrDefaultAsync(x => x.KlientId.Equals(id));

        if (klient != null)
        {
            return Ok(new KlientViewModel()
            {
                KlientId = klient.KlientId,
                Imie = klient.Imie,
                Nazwisko = klient.Nazwisko,
                Email = klient.Email
            });
        }

        return NotFound();
    }

    [Route("edit/{id:min(1)}")]
    [HttpPut]
    public async Task<IActionResult> EditKlient([FromBody] EditUser editUser, int id)
    {
        var klient = await _context.Klienci.FirstOrDefaultAsync(x => x.KlientId.Equals(id));
        klient.Imie = editUser.Imie;
        klient.Nazwisko = editUser.Nazwisko;
        klient.Email = editUser.Email;
        klient.NrTel = editUser.NrTel;
        klient.Adres = editUser.Adres;
        await _context.SaveChangesAsync();

        return Ok("Zmodyfikowano klienta");
    }

    
    public async Task<IActionResult> Post([FromBody] CreateKlient createKlient)
    {
        var klient = new Klient()
        {
            Imie = createKlient.Imie,
            Nazwisko = createKlient.Nazwisko,
            NrTel = createKlient.NrTel,
            Email = createKlient.Email,
            Adres = createKlient.Adres
        };

        await _context.Klienci.AddAsync(klient);
        await _context.SaveChangesAsync();

        return Created("Dodano klienta",new KlientViewModel()
        {
            KlientId = klient.KlientId,
            Imie = klient.Imie,
            Nazwisko = klient.Nazwisko,
            Email = klient.Email
        });
    }

    [Route("{id:min(1)}")]
    public async Task<IActionResult> Delete(int id)
    {
        var klient = await _context.Klienci.FirstOrDefaultAsync(x => x.KlientId.Equals(id));
        
        _context.Klienci.Attach(klient);
        _context.Klienci.Remove(klient);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    
    
    
}




}