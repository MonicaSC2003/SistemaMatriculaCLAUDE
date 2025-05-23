﻿using DAL.Interfaces.InterfacesDeEntidades;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementaciones.ImplementacionesDeEntidades
{
    public class DALHorarioImpl: DALGenericoImpl<Horario>, IHorarioDAL
    {
        SistemaCursosContext _context;
        public DALHorarioImpl(SistemaCursosContext context) : base(context)
        {
            _context = context;
        }
    }
}
