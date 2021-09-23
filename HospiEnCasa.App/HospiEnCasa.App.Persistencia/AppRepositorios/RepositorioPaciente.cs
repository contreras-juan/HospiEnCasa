using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{

    
    public class RepositorioPaciente : IRepositorioPaciente
    {

        /// <summary>
        /// Referencia al contexto de paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Método constructor 
        /// </summary>
        /// <param name="appContext"> </param>//

        public RepositorioPaciente(AppContext appcontext)
        {
            _appContext=appContext;
        }

    
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Paciente.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(Paciente paciente)
        {
            var pacienteEncontrado=_appContext.Paciente.FirstOrDefault(p => p.Id==idPaciente);
            if(pacienteEncontrado==null)
            {
                return;
                _appContext.Paciente.Remove(pacienteEncontrado);
                _appContext.SaveChanges();
            }
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Paciente;
        }

        Paciente IrepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Paciente.FirstOrDefault(p => p.Id==idPaciente);

        }

        Paciente IrepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado=_appContext.Paciente.FirstOrDefault(p => p.Id==paciente.Id);
            if(pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;

            }
            return pacienteEncontrado;
        }
    }
}