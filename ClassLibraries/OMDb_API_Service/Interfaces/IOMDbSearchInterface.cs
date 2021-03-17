using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMDb_API_Service.Interfaces.IOMDbSearchInterface
{
    interface IOMDbSearchInterface
    {
        void SearchByIMDbId(string id);

        void SearchByMovieTitle(string title);
    }
}