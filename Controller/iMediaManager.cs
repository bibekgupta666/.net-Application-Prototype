using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface iMediaManager
    {
        DataTable ViewAllMedia();
        DataTable CustomSearch(String director, String genre);


    }
}
