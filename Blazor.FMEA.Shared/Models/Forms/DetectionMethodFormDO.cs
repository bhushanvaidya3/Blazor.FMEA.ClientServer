using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.FMEA.Shared.Models.Forms
{
    public class DetectionMethodFormDO
    {
        public int Detection_ID { get; set; }
        public string Product_Class { get; set; }
        public string Site { get; set; }
        public double Escape_ID { get; set; }
        public int Detection_Master_ID { get; set; }
        public string PD_Characteristics_Desc { get; set; }
        public string Detection_Method { get; set; }
        public string Escape_Description { get; set; }
        public int Product_Characteristic_ID { get; set; }
        //public IEnumerable<Entity.Models.Master.ProductCharacteristics> ProductCharacteristicsMasterRecords { get; set; }
        //public IEnumerable<Entity.Models.Master.SiteMaster> SiteMasterRecords { get; set; }
        //public IEnumerable<Entity.Models.Master.DetectionMethod> DetectionMethodMasterRecords { get; set; }
        //public IEnumerable<Entity.Models.Master.EscapeMaster> EscapeMasterRecords { get; set; }
        //public IEnumerable<Entity.Models.Master.Product> ProductMasterRecords { get; set; }
        public string Escape_ID_Description { get; set; }
    }
}
