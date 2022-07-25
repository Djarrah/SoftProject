using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal interface TabellaSQL
    {
        void Insert();

        void Update();

        DataTable Select();

        DataTable Select(int ID);
    }
