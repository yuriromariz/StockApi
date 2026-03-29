using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System;

namespace StockApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        // Brand or Trade Name (e.g., Novalgina)
        public string ReferenceName { get; set; } = string.Empty;
        
        // Active Ingredient or Generic Name (e.g., Dipirona)
        public string GenericName { get; set; } = string.Empty;
        
        // Pharmaceutical Manufacturer
        public string Manufacturer { get; set; } = string.Empty;

        // Dosage numerical value (e.g., 500, 25, 0.5)
        public double DosageValue { get; set; }

        // Dosage unit of measurement (e.g., mg, mg/ml, %)
        public string DosageUnit { get; set; } = string.Empty;

        // Batch or Lot Number for traceability
        public string LotNumber { get; set; } = string.Empty;

        // Current quantity in stock
        public int StockQuantity { get; set; }

        // Date of manufacturing
        public DateTime ManufacturingDate { get; set; }

        // Expiration date
        public DateTime ExpirationDate { get; set; }
    }
}