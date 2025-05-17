using LacunaDevOps.Site.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LacunaDevOps.Site.Business
{
    public partial class BusinessService
    {
        private readonly AppDbContext dbContext;
        public BusinessService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
