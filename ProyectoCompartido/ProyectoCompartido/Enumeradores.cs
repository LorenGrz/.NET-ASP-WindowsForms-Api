using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompartido
{   
    public enum TipoPilas
    {
        A,        // Pila tipo A
        AA,       // Pila doble A
        AAA,      // Pila triple A
        Bat9V,    // Batería de 9 voltios
        C,        // Tamaño C (más grande que AA)
        D,        // Tamaño D (cilíndricas grandes)
        CR2032,   // Botón, común en relojes y dispositivos pequeños
        LR44,     // Pila botón más pequeña, usada en juguetes o calculadoras
        P_18650     // Batería recargable, popular en linternas y laptops
    }
}
