﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class ColorDao
    {
        ShoesStore db = new ShoesStore();

        public List<Color> GetAllColor()
        {
            return db.Colors.ToList();
        }
    }
}
