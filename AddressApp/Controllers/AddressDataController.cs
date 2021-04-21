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
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAllAddressData()
        {
            return await _context.ADDRESS_DATA
                .Select(x => AddressDataToDTO(x))
                .ToListAsync();
        }

        [HttpGet("postcode/{postcode}")]
        public async Task<ActionResult<AddressDataDTO>> GetAddressDataByPostcode(string postcode)
        {
            var addressData = await _context.ADDRESS_DATA.FindAsync(postcode);

            if (addressData == null)
            {
                return NotFound();
            }

            return AddressDataToDTO(addressData);
        }

        [HttpGet("street/{street}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAddressDataByStreet(string street)
        {
            var addressData = await _context.ADDRESS_DATA
                            .Where(x => x.Street == street)
                            .Select(x => AddressDataToDTO(x))
                            .ToListAsync();

            if (addressData == null || !addressData.Any())
            {
                return NotFound();
            }

            return addressData;
        }

        [HttpGet("housenumber/{house_number}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAddressDataByHouseNumber(long house_number)
        {
            var addressData = await _context.ADDRESS_DATA
                            .Where(x => x.House_Number == house_number)
                            .Select(x => AddressDataToDTO(x))
                            .ToListAsync();

            if (addressData == null || !addressData.Any())
            {
                return NotFound();
            }

            return addressData;
        }

        [HttpGet("city/{city}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAddressDataByCity(string city)
        {
            var addressData = await _context.ADDRESS_DATA
                            .Where(x => x.City == city)
                            .Select(x => AddressDataToDTO(x))
                            .ToListAsync();

            if (addressData == null || !addressData.Any())
            {
                return NotFound();
            }

            return addressData;
        }

        [HttpGet("country/{country}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> GetAddressDataByCountry(string country)
        {
            var addressData = await _context.ADDRESS_DATA
                            .Where(x => x.Country == country)
                            .Select(x => AddressDataToDTO(x))
                            .ToListAsync();

            if (addressData == null || !addressData.Any())
            {
                return NotFound();
            }

            return addressData;
        }

        [HttpGet("sort/postcode/{AscOrDesc}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> SortAddressDataByPostcode(string AscOrDesc)
        {
            if (AscOrDesc == "Ascend" || AscOrDesc == "Asc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderBy(x => x.Postcode)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else if (AscOrDesc == "Descend" || AscOrDesc == "Desc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderByDescending(x => x.Postcode)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else { return NoContent(); }
        }

        [HttpGet("sort/street/{AscOrDesc}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> SortAddressDataByStreet(string AscOrDesc)
        {
            if (AscOrDesc == "Ascend" || AscOrDesc == "Asc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderBy(x => x.Street)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else if (AscOrDesc == "Descend" || AscOrDesc == "Desc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderByDescending(x => x.Street)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else { return NoContent(); }
        }

        [HttpGet("sort/housenumber/{AscOrDesc}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> SortAddressDataByHouseNumber(string AscOrDesc)
        {
            if (AscOrDesc == "Ascend" || AscOrDesc == "Asc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderBy(x => x.House_Number)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else if (AscOrDesc == "Descend" || AscOrDesc == "Desc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderByDescending(x => x.House_Number)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else { return NoContent(); }
        }

        [HttpGet("sort/city/{AscOrDesc}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> SortAddressDataByCity(string AscOrDesc)
        {
            if (AscOrDesc == "Ascend" || AscOrDesc == "Asc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderBy(x => x.City)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else if (AscOrDesc == "Descend" || AscOrDesc == "Desc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderByDescending(x => x.City)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else { return NoContent(); }
        }

        [HttpGet("sort/country/{AscOrDesc}")]
        public async Task<ActionResult<IEnumerable<AddressDataDTO>>> SortAddressDataByCountry(string AscOrDesc)
        {
            if (AscOrDesc == "Ascend" || AscOrDesc == "Asc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderBy(x => x.Country)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else if (AscOrDesc == "Descend" || AscOrDesc == "Desc")
            {
                var addressData = await _context.ADDRESS_DATA
                                   .OrderByDescending(x => x.Country)
                                   .Select(x => AddressDataToDTO(x))
                                   .ToListAsync();

                if (addressData == null || !addressData.Any())
                {
                    return NotFound();
                }

                return addressData;
            }
            else { return NoContent(); }
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
                nameof(GetAddressDataByPostcode),
                new { Postcode = addressData.Postcode },
                AddressDataToDTO(addressData));
        }

        [HttpDelete("{postcode}")]
        public async Task<IActionResult> DeleteAddressData(string postcode)
        {
            var addressData = await _context.ADDRESS_DATA.FindAsync(postcode);

            if (addressData == null)
            {
                return NotFound();
            }

            _context.ADDRESS_DATA.Remove(addressData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressDataExists(string Postcode) =>
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
