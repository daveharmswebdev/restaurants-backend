using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using restaurants_backend.Data;
using restaurants_backend.DTOs;
using restaurants_backend.entities; // Import your Staff class and DbContext

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
    private readonly RestaurantsDbContext _context; // Replace YourDbContext with your actual DbContext name
    private readonly IMapper _mapper;

    public StaffController(RestaurantsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/Staff
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StaffDto>>> GetStaff()
    {
        var staffList = await _context.Staff.ToListAsync();
        return Ok(_mapper.Map<List<StaffDto>>(staffList));
    }

    // GET: api/Staff/5
    [HttpGet("{id}")]
    public async Task<ActionResult<StaffDto>> GetStaffById(int id)
    {
        var staff = await _context.Staff.FindAsync(id);

        if (staff == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<StaffDto>(staff));
    }

    // POST: api/Staff
    [HttpPost]
    public async Task<ActionResult<Staff>> CreateStaff([FromBody] CreateStaffDto dto)
    {
        var staff = _mapper.Map<Staff>(dto);
        _context.Staff.Add(staff);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetStaffById), new { id = staff.Id }, staff);
    }

    // PUT: api/Staff/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStaff(int id, UpdateStaffDto dto)
    {
        if (id != dto.Id)
        {
            return BadRequest();
        }

        var staff = _mapper.Map<Staff>(dto);
        _context.Entry(staff).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!StaffExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Staff/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStaff(int id)
    {
        var staff = await _context.Staff.FindAsync(id);

        if (staff == null)
        {
            return NotFound();
        }

        _context.Staff.Remove(staff);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool StaffExists(int id)
    {
        return _context.Staff.Any(e => e.Id == id);
    }
}
