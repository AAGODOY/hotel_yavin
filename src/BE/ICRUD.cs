﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUD<T>
    {
        int Add(T objAlta);
        int Delete(T objBaja);
        int Update(T objUpdate);
        List<T> SelectAll();
    }
}
