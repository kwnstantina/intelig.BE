using Intellig.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api
{
    public class TableDataStore
    {

        public List<TableDto> TableData { get; set; }

        public static TableDataStore Current { get; } = new TableDataStore();

        public TableDataStore()
        {
            TableData = new List<TableDto>()
            {
                new TableDto()
                {
                    Id=new Guid(),
                    Title="test",
                    Source="http:/sda.com",
                    Description="mucis",
                    Date=new DateTime(),
                    MnemonicWord="my inderest",
                 

                }

            };
        }
    }
}
