﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasRepetitivas
{
    public class Prueba
    {
        public int codAlumno { get; set; }
        public string? nombre { get; set; }
        public int edad { get; set; }

        public override string ToString()
        {
            return codAlumno + " " + nombre + " " + edad;
              
        }

    }
}
