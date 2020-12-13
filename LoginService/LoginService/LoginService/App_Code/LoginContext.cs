using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для LoginContext
/// </summary>
public class LoginContext : DbContext
{
    public LoginContext()
        : base("DBConnection")
    { }

    public DbSet<UserModel> Users { get; set; }
}