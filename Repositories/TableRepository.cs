using Intellig.Api.Contexts;
using Intellig.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api.Repository
{
    public class TableRepository : ITableRepository
    {

        private readonly TableDtoContext _context;
        public TableRepository(TableDtoContext context)
        {
            _context = context;
        }
        public async Task<TableDto> Create(TableDto data)
        {
             _context.TableData.Add(data);
             await _context.SaveChangesAsync();

            return data;

        }

        public async  Task Delete(Guid Id)
        {
            var tablerowToDelete = await _context.TableData.FindAsync(Id);
            _context.TableData.Remove(tablerowToDelete);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<TableDto>> Get()
        {
            return await _context.TableData.ToListAsync();
        }

        public async Task<TableDto> Get(Guid Id)
        {
            return await _context.TableData.FindAsync(Id);
        }

        public async Task Update(TableDto data)
        {
            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
