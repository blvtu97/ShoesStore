﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class TopTrendingProduct
    {
        public TopTrendingView TopTrending { get; set; }

        public List<ListAllProductView> OtherColorProductList { get; set; }
    }
}
