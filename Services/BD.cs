using System;
using System.Collections.Generic;
using Veterinaria.Models;

namespace Veterinaria.Services
{
    public static class FakeDatabase
    {
        private static List<Propietario> _propietarios = new()
        {
            new Propietario { Nombre = "Juan Pérez", Telefono = "555-1234", Correo = "juan@example.com" },
            new Propietario { Nombre = "Ana Gómez", Telefono = "555-5678", Correo = "ana@example.com" },
            new Propietario { Nombre = "Carlos Ruiz", Telefono = "555-9876", Correo = "carlos@example.com" }
        };

        private static List<Paciente> _pacientes = new()
        {
            new Paciente
            {
                Nombre = "Chocolatito",
                Especie = Especies.Perro,
                Raza = "Beagle",
                FechaNacimiento = new DateTime(2019, 5, 20),
                Sexo = "Macho",
                Propietario = _propietarios[0],
                Padecimientos = "Alergia alimentaria",
                Imagen = "beagle.png",
                Citas = new List<Citas>
                {
                    new Citas { Fecha = new DateTime(2023, 1, 15), Motivo = "Vacunación" },
                    new Citas { Fecha = new DateTime(2023, 6, 10), Motivo = "Revisión general" }
                },
                Intervenciones = new List<Intervencion>
                {
                    new Intervencion { Fecha = new DateTime(2024, 2, 12), Descripcion = "Limpieza dental" }
                }
            },
            new Paciente
            {
                Nombre = "Michi",
                Especie = Especies.Gato,
                Raza = "Persa",
                FechaNacimiento = new DateTime(2020, 8, 10),
                Sexo = "Hembra",
                Propietario = _propietarios[1],
                Padecimientos = "Asma felina",
                Imagen = "gato.png"
            }
        };

        public static List<Propietario> ObtenerPropietarios() => _propietarios;

        public static List<Paciente> ObtenerPacientes() => _pacientes;

        public static void AgregarPaciente(Paciente paciente) => _pacientes.Add(paciente);

        public static void AgregarPropietario(Propietario propietario) => _propietarios.Add(propietario);
    }
}
