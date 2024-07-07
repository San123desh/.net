using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;


namespace StudentManagement.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
