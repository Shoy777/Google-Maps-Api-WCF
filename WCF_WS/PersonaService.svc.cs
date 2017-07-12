using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_WS.Data;

namespace WCF_WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PersonaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PersonaService.svc o PersonaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PersonaService : IPersonaService
    {
        private Context context = new Context();
        /*
        public PersonaEntity GetPersona(int id)
        {
            return context.Persona.Where(x => x.Id == id).Select(p => new PersonaEntity
            {
                Id = p.Id,
                Apellido = p.Apellido,
                Nombre = p.Nombre,
                FechaNacimiento = p.FechaNacimiento,
                CX = p.CX,
                CY = p.CY
            }).First();

        }

        public List<PersonaEntity> GetAllPersonas()
        {
            return context.Persona.Select(p => new PersonaEntity
            {
                Id = p.Id,
                Apellido = p.Apellido,
                Nombre = p.Nombre,
                FechaNacimiento = p.FechaNacimiento,
                CX = p.CX,
                CY = p.CY
            }).ToList();
        }

        public bool CreatePersona(PersonaEntity p)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Persona per = new Persona();

                    per.Apellido = p.Apellido;
                    per.Nombre = p.Nombre;
                    per.FechaNacimiento = p.FechaNacimiento;
                    per.CX = p.CX;
                    per.CY = p.CY;

                    context.Persona.Add(per);
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }

        public bool EditPersona(PersonaEntity p)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Persona per = new Persona();

                    per.Apellido = p.Apellido;
                    per.Nombre = p.Nombre;
                    per.FechaNacimiento = p.FechaNacimiento;
                    per.CX = p.CX;
                    per.CY = p.CY;

                    context.Entry(per).State = EntityState.Modified;
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }

        public bool DeletePersona(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Persona per = context.Persona.Find(id);

                    context.Persona.Remove(per);
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }
        */


        public Persona GetPersona(int id)
        {
            return context.Persona.Find(id);

        }

        public List<Persona> GetAllPersonas()
        {
            return context.Persona.ToList();
        }

        public bool CreatePersona(Persona p)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Persona.Add(p);
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }

        public bool EditPersona(Persona p)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Entry(p).State = EntityState.Modified;
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }

        public bool DeletePersona(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Persona per = context.Persona.Find(id);

                    context.Persona.Remove(per);
                    context.SaveChanges();

                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    return false;
                }
            }
        }
    }

}