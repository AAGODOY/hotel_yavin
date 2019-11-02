using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Services
    {
        public static HELPER.Help helper = new HELPER.Help();

        #region SQL Connection

        public static Boolean ValidarConexion(string str)
        {
            return helper.ValidarConexion(str);
        }

        public static Boolean ValidarConexion(string servidor, string nombreBD, bool seguridadIntegrada, string usuario, string contraseña)
        {
            string connstring = "Data Source=" + servidor + ";Initial Catalog=" + nombreBD + ";";
            if (seguridadIntegrada)
            {
                connstring += "Integrated Security=True;";
            }
            else
            {
                connstring += "User ID=" + usuario + "Password=" + contraseña + ";";
            }
            return helper.ValidarConexion(connstring);
        }

        #endregion

        #region Validación uso patente

        /*
         * FUNCION: valida la regla: "toda patente tiene que estar ASIGNADA y NO NEGADA a un USUARIO ACTIVO"
         * RESULTADO: retorna 0 si la regla no se cumple (excluyendo al usuario sobre el que se intenta x acción).
         */
        public static int VerificarUsoPatente(int id_usuario, int id_patente)
        {
            string query = @"BEGIN
	                            declare @idUsuario Int = " + id_usuario + @"
	                            declare @idPatente Int = " + id_patente + @"
	                            declare @counter Int = 0
	                            BEGIN
		                            BEGIN
		                            --PATENTE: ¿Uno o más usuarios tienen la patente asignada y no negada?
		                            set @counter = @counter +
		                            (select count(*)
		                            from UsuarioPatente up
		                            INNER JOIN Usuario u ON up.id_usuario = u.id_usuario
		                            where up.id_patente = @idPatente AND up.patenteNegada = 0 AND u.activo = 1 AND u.id_usuario != @idUsuario)
		                            END
		                            --FAMILIA: ¿Uno o más usuarios tienen la patente asignada por familia activa?
		                            BEGIN
		                            set @counter = @counter +
		                            (select COUNT(*)
		                            from FamiliaUsuario fu
		                            INNER JOIN Usuario u ON fu.id_usuario = u.id_usuario
		                            INNER JOIN FamiliaPatente fp ON fu.id_familia = fp.id_familia
		                            INNER JOIN Familia f ON fp.id_familia = f.id_familia
		                            where fp.id_patente = @idPatente AND f.activo = 1 AND u.activo = 1 AND u.id_usuario != @idUsuario)
		                            END
	                            END
	                            SELECT @counter
                            END";
            return Convert.ToInt32(helper.ExecuteScalar(query));
        }

        #endregion

    }
}
