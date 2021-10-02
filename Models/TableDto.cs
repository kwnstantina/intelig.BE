using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellig.Api.Models
{
    public class TableDto
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public string MnemonicWord { get; set; }


    }
}
