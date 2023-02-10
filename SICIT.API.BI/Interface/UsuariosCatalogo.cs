using SICIT.API.BI;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;

namespace SICIT.BI.Interface
{
    public class UsuariosCatalogo : ICatalogo<Usuarios>
    {
        private readonly UsuariosBI cls = new UsuariosBI();
        //public Success<Usuarios> Obtener(Usuarios parameters = null)
        //{
        //    return cls.Obtener();
        //}
        //public Success<Usuarios> Agregar(Usuarios parameters)
        //{
        //    return cls.Agregar(parameters);
        //}
        //public Success<Usuarios> Eliminar(Usuarios parameters)
        //{
        //    return cls.Eliminar(parameters);
        //}
        //public Success<Usuarios> Actualizar(Usuarios parameters)
        //{
        //    return cls.Actualizar(parameters);
        //}

        //public Success<Usuarios> ObtenerId(int id)
        //{
        //    throw new System.NotImplementedException();
        //}

        public Success<Usuarios> Get(Usuarios param = null)
        {
            return cls.Get();
        }

        public Success<Usuarios> GetId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Success<Usuarios> Insert(Usuarios parameters)
        {
            throw new System.NotImplementedException();
        }

        public Success<Usuarios> Update(Usuarios parameters)
        {
            throw new System.NotImplementedException();
        }

        public Success<Usuarios> Delete(Usuarios parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}