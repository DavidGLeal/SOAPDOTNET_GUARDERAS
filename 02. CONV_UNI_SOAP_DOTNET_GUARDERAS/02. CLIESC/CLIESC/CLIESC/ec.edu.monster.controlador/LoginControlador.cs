using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CLIESC.ec.edu.monster.controlador
{
    public class LoginControlador
    {
        private string usuario = "Monster";
        private string clave = "7fbdfcdd431cb77a5bce52182f863d807544fdbea2edb49dc396d5ba30481f64";

        public bool verificar(string usuario, string clave)
        {
            string hashClave = hashSHA256(clave);
            if (this.usuario == usuario && this.clave == hashClave)
            {
                return true;
            }
            return false;
        }

        private string hashSHA256(string entrada)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(entrada);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder hexString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hexString.Append(b.ToString("x2"));
                }
                return hexString.ToString();
            }
        }

    }
}
