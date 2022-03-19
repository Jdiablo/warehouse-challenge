using Domain.Common.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Service
{
    public interface IDeleteService
    {
        public Task DeleteAsync(object id);
    }
}
