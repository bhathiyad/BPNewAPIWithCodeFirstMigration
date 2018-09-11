using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.ViewModels
{
    public class TokenResponseViewModel
    {
        #region Constructor
        public TokenResponseViewModel()
        {

        }
        #endregion

        #region Properties
        public string Token { get; set; }
        public int Expiration { get; set; }
        public string RefreshToken { get; set; }
        #endregion
    }
}
