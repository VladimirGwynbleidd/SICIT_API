using SICIT.API.ENTITIES;

namespace SICIT.API.Interface
{
    public interface ICatalogo<T> where T : class
    {
        Success<T> Get(T param = null);
        Success<T> GetId(int id);
        Success<T> Insert(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }

    public interface IUsuarios<T> where T : class
    {
        Success<T> Get(T param = null);
        Success<T> GetId(string id);
        Success<T> Insert(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
        Success<T> ResetPassword(T parameters);
    }


    public interface IEntidades<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }

    public interface IBitacoraNormatividad<T> where T : class
    {
        Success<T> ObtenerId(T parameters);
    }

    public interface IBitacoraAsociacion<T> where T : class
    {
        Success<T> ObtenerId(T parameters);
    }

    public interface IBitacoraMicrositio<T> where T : class
    {
        Success<T> Obtener(T param = null);
    }

    public interface IBitacoraPregunta<T> where T : class
    {
        Success<T> Obtener(T param = null);
    }

    public interface IAsociacion<T> where T : class
    {
        Success<T> Obtener(T param = null);
        Success<T> ObtenerAsocIdNorma(int idNorma);
        Success<T> ObtenerAsocIdNorma(T parameters);
        Success<T> Agregar(T parameters);
        Success<T> Actualizar(T parameters);
        Success<T> Eliminar(T parameters);
    }

    public interface IArchivo<T> where T : class
    {
        Success<T> ObtenerArchivoNormativaId(int idNormativa);
        Success<T> ObtenerArchivoAsociadaId(int idAsociada);
        Success<T> ObtenerArchivoPreguntaId(int idPregunta);
    }

    public interface IPublicacion<T> where T : class
    {
        Success<T> Actualizar(T parameters);
    }

    public interface IConfigMicrositio<T> where T : class
    {
        Success<T> Obtener(T param = null);
        Success<T> Agregar(T parameters);
    }

    public interface IPreguntaFrecuente<T> where T : class
    {
        Success<T> Obtener(T param = null);
        Success<T> Agregar(T parameters);
        Success<T> Actualizar(T parameters);
    }


    public interface ICabeceros<T> where T : class
    {
        Success<T> Obtener(T param = null);
    }

    public interface IAcceso<T> where T : class
    {
        Success<T> ObtenerAcceso(T parameters);
    }

    public interface ITipoEntidad<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }


    public interface IAreas<T> where T : class
    {
        Success<T> Get(T param = null);
        Success<T> GetById(T parameters);
        Success<T> Insert(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }

    public interface IPuestos<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Insert(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
        Success<T> GetId(T parameters);
    }

    public interface IBitacoraAcciones<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }

    public interface IBitacoraSesiones<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
        Success<T> ObtenerBitacora(T parameters = null);
        Success<T> AgregarBitacora(T parameters);
    }

    public interface IPerfiles<T> where T : class
    {
        Success<T> Get(T parameters);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }

    public interface IConsultas<T> where T : class
    {
        Success<T> Get(T parameters = null);
        Success<T> Add(T parameters);
        Success<T> Update(T parameters);
        Success<T> Delete(T parameters);
    }


    public interface IParametros<T> where T : class
    {
        Success<T> ObtenerParametros(T parameters = null);
    }

    public interface IAccion<T> where T : class
    {
        Success<T> AgregarAccion(T parameters);
    }

}

