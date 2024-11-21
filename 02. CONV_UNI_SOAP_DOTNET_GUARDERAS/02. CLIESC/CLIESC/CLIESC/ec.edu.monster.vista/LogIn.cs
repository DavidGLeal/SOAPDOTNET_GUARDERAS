using CLIESC.ec.edu.monster.controlador;
using CLIESC;

namespace CLIESC.ec.edu.monster.vista
{
    public partial class LogIn : Form
    {
        LoginControlador loginControlador;
        public LogIn()
        {
            InitializeComponent();
            loginControlador = new LoginControlador();
        }

        
    }
}
