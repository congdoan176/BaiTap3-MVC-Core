using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiTap3.Models;

namespace BaiTap3.Models
{
    public class BaiTap3Context : DbContext
    {
        public BaiTap3Context (DbContextOptions<BaiTap3Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    RollNumber = "D00123",
                    LastName = "Cong",
                    FirstName = "Doan",
                    Email = "doan@gmail.com"
                },
                new Student()
                {
                    RollNumber = "D001234",
                    LastName = "Nguyen",
                    FirstName = "Doan1",
                    Email = "doan1@gmail.com"
                },
                new Student()
                {
                    RollNumber = "D001235",
                    LastName = "Doan",
                    FirstName = "Doan2",
                    Email = "doan2@gmail.com"
                }
            );
            modelBuilder.Entity<Mark>().HasData(
                new Mark()
                {
                    Id = 1,
                    SubjectName = "Java",
                    SubjectMark = 5,
                    StudentRollNumber = "D00123"
                },
                new Mark()
                {
                    Id = 2,
                    SubjectName = "C#",
                    SubjectMark = 15,
                    StudentRollNumber = "D00123"
                },
                new Mark()
                {
                    Id = 3,
                    SubjectName = "Java",
                    SubjectMark = 15,
                    StudentRollNumber = "D001234"
                },
                new Mark()
                {
                    Id = 4,
                    SubjectName = "HTML",
                    SubjectMark = 10,
                    StudentRollNumber = "D001234"
                }
                );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BaiTap3.Models.Student> Student { get; set; }

        public DbSet<BaiTap3.Models.Mark> Mark { get; set; }
    }
}
