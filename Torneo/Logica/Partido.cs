﻿using System;

namespace Torneo_Clases.Logica
{
    public class Partido
    {
        public int Id { get; set; }
        public int IdTorneo { get; set; }
        public Equipo Equipo1 { get; set; }
        public Equipo Equipo2 { get; set; }
        public string Estadio { get; set; }
        public string Juez { get; set; }
        public DateTime Fecha { get; set; }
        public Resultado Resultado { get; set; }
    }
}
