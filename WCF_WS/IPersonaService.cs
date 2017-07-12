using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_WS.Data;

namespace WCF_WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPersonaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPersonaService
    {
        [OperationContract]
        Persona GetPersona(int id);

        [OperationContract]
        List<Persona> GetAllPersonas();

        [OperationContract]
        bool CreatePersona(Persona p);

        [OperationContract]
        bool EditPersona(Persona p);

        [OperationContract]
        bool DeletePersona(int id);

    }
}
