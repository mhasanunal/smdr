using Microsoft.EntityFrameworkCore;
using SMDR.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SMDR.DataAccessLayer
{
    public class CallContext : DbContext
    {
        public CallContext([NotNullAttribute] DbContextOptions<CallContext> options) : base(options)
        {
        }

        public DbSet<CallLog> CallLogs { get; set; }
    }
}
