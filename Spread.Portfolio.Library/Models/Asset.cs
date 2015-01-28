using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spread.Portfolio.Library.Models
{
    public class Asset
    {
    
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAsset { get; set; }

        public int IdCategory { get; set; }

        public string NmAsset { get; set; }

        public string CodeISIN { get; set; }

        public string CodeSELIC { get; set; }

        public DateTime MaturityDate { get; set; }

        public int MaturityExpectedInDays { get; set; }

        public decimal GraceDate { get; set; }

        public decimal GraceExpectedInDays { get; set; }
    }
}
