
using Digitalware.Apps.Utilities.Cr.DAO;
using Digitalware.Apps.Utilities.Cr.Models;

using SevenFramework.TO;
using System;


namespace Digitalware.Apps.Utilities.Cr.BO
{
    public class BOCrRtmcl
    {
      
      

        public TOTransaction<Cr_Rtmcl> Get(int emp_codi, int tas_cont, int mod_cont, int ite_cont)
        {
            try
            {
                return new TOTransaction<Cr_Rtmcl>() { ObjTransaction = new DAO_Cr_Rtmcl().GetCrRtmcl(emp_codi, tas_cont, mod_cont, ite_cont), Retorno = 0, TxtError = "" };
              
            }
            catch (Exception ex)
            {
                return new TOTransaction<Cr_Rtmcl>() { ObjTransaction = null, Retorno = 1, TxtError = ex.Message };
            }
        }

    }
}
