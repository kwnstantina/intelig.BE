using Intellig.Api.Models;
using Intellig.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api.Controllers
{



    [ApiController]
    [Route("intelig/table")]
    public class TableController : ControllerBase
    {

        private readonly ITableRepository _tableRepository;

        public TableController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<TableDto>> GetTableData()
        {
            return await _tableRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TableDto>> GetTableDataById(Guid id)
        {
            return await _tableRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<TableDto>> PostTableData([FromBody] TableDto tabledto)
        {

            var newData = await _tableRepository.Create(tabledto);
            return CreatedAtAction(nameof(GetTableData), new { id = Guid.NewGuid() }, newData);
         
        }



        [HttpPut]
        public async Task<ActionResult> PutTableData(Guid Id, [FromBody] TableDto tabledto)
        {
            if (Id != tabledto.Id)
            {

                return BadRequest();
            }
            await _tableRepository.Update(tabledto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTableData(Guid Id)
        {
            var tablerowDeleted = await _tableRepository.Get(Id);
            if(tablerowDeleted == null)
                return NotFound();

            await _tableRepository.Delete(tablerowDeleted.Id);
            return NoContent();
        }
    }


}
