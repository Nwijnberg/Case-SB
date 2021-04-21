using System;
using System.Collections.Generic;
using System.Linq;
using AddressApp;
using AddressApp.Models;
using AddressApp.dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AddressApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDataController : ControllerBase
    {
        private readonly AddressContext _context;

        public AddressDataController(AddressContext context)
        {
            _context = context;
        }

        // GET: api/AddressDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAddressData()
        {
            return await _context.ADDRESS_DATA
                .Select(x => AddressDataToDTO(x))
                .ToListAsync();
        }

        [HttpGet("{postcode}")]
        public async Task<ActionResult<AddressDataDTO>> GetAddressData(string postcode)
        {
            var addressData = await _context.ADDRESS_DATA.FindAsync(postcode);

            if (addressData == null)
            {
                return NotFound();
            }

            return AddressDataToDTO(addressData);
        }

        [HttpPut("{postcode}")]
        public async Task<IActionResult> updateAddressData(string postcode, AddressDataDTO addressDataDTO)
        {
            if (postcode != addressDataDTO.Postcode)
            {
                return BadRequest();
            }

            var addressData = await _context.ADDRESS_DATA.FindAsync(postcode);
            if (addressData == null)
            {
                return NotFound();
            }

            addressData.Postcode = addressDataDTO.Postcode;
            addressData.Street = addressDataDTO.Street;
            addressData.House_Number = addressDataDTO.House_Number;
            addressData.City = addressDataDTO.City;
            addressData.Country = addressDataDTO.Country;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!AddressDataExists(postcode))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<AddressDataDTO>> CreateAddressData(AddressDataDTO addressDataDTO)
        {
            var addressData = new AddressData
            {
                Postcode = addressDataDTO.Postcode,
                Street = addressDataDTO.Street,
                House_Number = addressDataDTO.House_Number,
                City = addressDataDTO.City,
                Country = addressDataDTO.Country
            };

            _context.ADDRESS_DATA.Add(addressData);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetAddressData),
                new { Postcode = addressData.Postcode },
                AddressDataToDTO(addressData));
        }

        [HttpDelete("{postcode}")]
        public async Task<IActionResult> DeleteAddressData(string postcode)
        {
            var todoItem = await _context.ADDRESS_DATA.FindAsync(postcode);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.ADDRESS_DATA.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool  AddressDataExists(string Postcode) =>
             _context.ADDRESS_DATA.Any(e => e.Postcode == e.Postcode);

        private static AddressDataDTO AddressDataToDTO(AddressData addressData) =>
            new AddressDataDTO
            {
                Postcode = addressData.Postcode,
                Street = addressData.Street,
                House_Number = addressData.House_Number,
                City = addressData.City,
                Country = addressData.Country
            };
    }
}
