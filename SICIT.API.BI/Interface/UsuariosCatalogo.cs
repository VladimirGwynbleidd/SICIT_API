using SICIT.API.BI;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;

namespace SICIT.BI.Interface
{
    public class UsuariosCatalogo : IUsuarios<Usuarios>
    {
        private readonly UsuariosBI cls = new UsuariosBI();

        public Success<Usuarios> Get(Usuarios param = null)
        {
            return cls.Get();
        }

        public Success<Usuarios> Insert(Usuarios parameters)
        {
            return cls.Insert(parameters);
        }

        public Success<Usuarios> Update(Usuarios parameters)
        {
            return cls.Update(parameters);
        }

        public Success<Usuarios> Delete(Usuarios parameters)
        {
            return cls.Delete(parameters);
        }

        public Success<Usuarios> GetId(string id)
        {
            return cls.GetUser(id);
        }
        public Success<Usuarios> ResetPassword(Usuarios parameters)
        {
            return cls.UpdatePassword(parameters);
        }
    }
}