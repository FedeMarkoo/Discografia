﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Discografias
{
    class Magia
    {
        public Magia(String dir)
        {
            var file = TagLib.File.Create(dir);

        }
    }
}
