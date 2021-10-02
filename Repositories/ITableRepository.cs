using Intellig.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api.Repository
{
    public interface ITableRepository
    {
        Task<IEnumerable<TableDto>> Get();
        Task<TableDto> Get(Guid Id);
        Task<TableDto> Create(TableDto data);
        Task Update(TableDto data);
        Task Delete(Guid Id);

    }
}
