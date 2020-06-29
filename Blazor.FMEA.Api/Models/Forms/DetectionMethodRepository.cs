using Blazor.FMEA.Shared.Common;
using Blazor.FMEA.Shared.Models.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.FMEA.Api.Models.Forms
{
    public class DetectionMethodRepository : IDetectionMethodRepository
    {
        public AppDbContext _appDbContext { get; }

        private string FMEADBConnectionstring = "Data Source=VirtualDopey;database=FMEA; uid=Carsuper; pwd=Supercar";

        private int FMEADBTimeout { get; } = 300;

        public DetectionMethodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<DetectionMethodFormDO> GetAll()
        {
            List<DetectionMethodFormDO> lstDetectionMethodFormDO = new List<DetectionMethodFormDO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_GetAllDetectionFormRecords";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DetectionMethodFormDO dmf = new DetectionMethodFormDO()
                            {
                                Detection_ID = reader.GetInt32(reader.GetOrdinal(FMEAConstants.Detection_ID)),
                                Product_Class = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Product_Class)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Product_Class)),
                                Product_Characteristic_ID = reader.GetInt32(reader.GetOrdinal(FMEAConstants.Product_Characteristic_ID)),
                                Site = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Site)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Site)),
                                Escape_ID = reader.GetDouble(reader.GetOrdinal(FMEAConstants.Escape_ID)),
                                Detection_Master_ID = reader.GetInt32(reader.GetOrdinal(FMEAConstants.Detection_Master_ID)),
                                Detection_Method = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Detection_Method)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Detection_Method)),
                                PD_Characteristics_Desc = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.PD_Characteristics_Desc)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.PD_Characteristics_Desc)),
                                Escape_Description = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Escape_Description)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Escape_Description)),
                                Escape_ID_Description = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Escape_ID_Description)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Escape_ID_Description)),
                            };
                            lstDetectionMethodFormDO.Add(dmf);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lstDetectionMethodFormDO.OrderBy(r => r.PD_Characteristics_Desc);
        }
    }
}
