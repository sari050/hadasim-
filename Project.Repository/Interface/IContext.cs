using Microsoft.EntityFrameworkCore;
using Project.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Repository.Interface
{
    public interface IContext
    {
        DbSet<PersonalDetails> personalDetailss { get; set; }
        DbSet<CoronaDetails> coronaDetailss { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
