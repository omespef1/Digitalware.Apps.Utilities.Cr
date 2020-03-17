using Digitalware.Apps.Utilities.Cr.Models;
using SevenFramework;
using SevenFramework.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalware.Apps.Utilities.Cr.DAO
{
    public class DAO_Cr_Rtmcl
    {
        public Cr_Rtmcl Get()
        {
            throw new NotImplementedException();
        }

        public Cr_Rtmcl GetCrRtmcl(int emp_codi, int tas_cont, int mod_cont, int ite_cont)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("  SELECT RTM_PLAZ, RTM.LIC_CONT,LIC.LIC_NOMB,TOP_CODI  ");
            sql.Append("  FROM   CR_RTMCL RTM                         ");
            sql.Append("  INNER JOIN CA_LICRE LIC                     ");
            sql.Append("  ON RTM.EMP_CODI = LIC.EMP_CODI              ");
            sql.Append("  AND RTM.LIC_CONT = LIC.LIC_CONT             ");
            sql.Append("  WHERE TAS_CONT = @TAS_CONT                         ");
            sql.Append("  AND MOD_CONT = @MOD_CONT                           ");
            sql.Append("  AND ITE_CONT = @ITE_CONT                            ");
            sql.Append("  AND RTM.EMP_CODI = @EMP_CODI                     ");
            List<SQLParams> sQLParams = new List<SQLParams>();
            sQLParams.Add(new SQLParams("EMP_CODI", emp_codi));
            sQLParams.Add(new SQLParams("MOD_CONT", mod_cont));
            sQLParams.Add(new SQLParams("TAS_CONT", tas_cont));
            sQLParams.Add(new SQLParams("ITE_CONT", ite_cont));
            return new DbConnection().Get<Cr_Rtmcl>(sql.ToString(), sQLParams);
        }
    }
}
