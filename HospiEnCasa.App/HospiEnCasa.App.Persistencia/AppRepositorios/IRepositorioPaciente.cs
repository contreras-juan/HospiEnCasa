using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IrepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();

        paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente(Paciente paciente);

        void DeletePaciente(int idPaciente);

        Paciente GetPaciente(int idPaciente);
    }
}