using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Key_Service
{
    interface IAPI_Key_Service
    {
        string GetAPIKey();

        void SetAPIKey(string key);
    }
}
