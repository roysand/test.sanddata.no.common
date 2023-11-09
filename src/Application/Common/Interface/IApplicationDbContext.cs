using Test.sanddata.no.common.Domain.Entities.EF;
using Microsoft.EntityFrameworkCore;

namespace Test.sanddata.no.common.Application.Common.Interface;

public interface IApplicationDbContext
{
    DbSet<Detail> DetailSet { get; set; }
}