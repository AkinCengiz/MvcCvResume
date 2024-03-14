using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCvResume.Entities.Concrete;

namespace MvcCvResume.DataAccess.Concrete.EntityFramework.Contexts;
public class MvcCvResumeContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=ACENGIZ\AKINCENGIZ; initial catalog=MvcCvDB;Integrated Security=True;Trust Server Certificate=True;");
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Intro> Intros { get; set; }
    public DbSet<PersonalDetail> PersonalDetails { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialAccount> SocialAccounts { get; set; }


}
