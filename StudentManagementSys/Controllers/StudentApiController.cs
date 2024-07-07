// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using StudentManagement.Data;
// using StudentManagement.Models;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace StudentManagement.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class StudentsApiController : ControllerBase
//     {
//         private readonly ApplicationDbContext _context;

//         public StudentsApiController(ApplicationDbContext context)
//         {
//             _context = context;
//         }

//         // GET: api/StudentsApi
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
//         {
//             return await _context.Students.ToListAsync();
//         }

//         // GET: api/StudentsApi/5
//         [HttpGet("{id}")]
//         public async Task<ActionResult<Student>> GetStudent(int id)
//         {
//             var student = await _context.Students.FindAsync(id);

//             if (student == null)
//             {
//                 return NotFound();
//             }

//             return student;
//         }

//         // POST: api/StudentsApi
//         [HttpPost]
//         public async Task<ActionResult<Student>> PostStudent(Student student)
//         {
//             _context.Students.Add(student);
//             await _context.SaveChangesAsync();

//             return CreatedAtAction("GetStudent", new { id = student.Id }, student);
//         }

//         // PUT: api/StudentsApi/5
//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutStudent(int id, Student student)
//         {
//             if (id != student.Id)
//             {
//                 return BadRequest();
//             }

//             _context.Entry(student).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!StudentExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // DELETE: api/StudentsApi/5
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> DeleteStudent(int id)
//         {
//             var student = await _context.Students.FindAsync(id);
//             if (student == null)
//             {
//                 return NotFound();
//             }

//             _context.Students.Remove(student);
//             await _context.SaveChangesAsync();

//             return NoContent();
//         }

//         private bool StudentExists(int id)
//         {
//             return _context.Students.Any(e => e.Id == id);
//         }
//     }
// }
