﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ErenEmlak.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DBEntities2 : DbContext
{
    public DBEntities2()
        : base("name=DBEntities2")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Bridge> Bridge { get; set; }

    public virtual DbSet<Student> Student { get; set; }

    public virtual DbSet<Subject> Subject { get; set; }

}

}

