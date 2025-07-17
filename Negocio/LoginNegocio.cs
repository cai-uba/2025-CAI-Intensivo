using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        public LoginResponse login(String username, String password)
        {
            // Paso 1: Pase las validaciones que corresponden al negocio

            // Paso 2: verifico las credenciales
            LoginPersistencia loginPersistencia = new LoginPersistencia();
            LoginResponse loginResponse = loginPersistencia.login(username, password);

            return loginResponse;
        }

    }
}
