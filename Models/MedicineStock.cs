using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.Models
{
    [Table("MedicineStock")]
    public class MedicineStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MedicineName { get; set; }
        public string ChemicalComposition { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public int NumberOfTabletsInStock { get; set; }
        public string TargetAilment { get; set; }
    }
}
