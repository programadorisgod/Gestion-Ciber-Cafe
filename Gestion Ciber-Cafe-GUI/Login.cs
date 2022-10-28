using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Login : Form
    {
        Logica.Procesamiento procesamiento = new Logica.Procesamiento();
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           

        }
        void Pordefecto()
        {
            if (txtUsuario.Text == "Usuario...")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }
        void Salirtexto()
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario...";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            Pordefecto();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            Salirtexto();
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña...")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña...";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario...")
            {
                if (txtContraseña.Text != "Contraseña...")
                {
                    bool PassLogin = procesamiento.PassLogin(txtUsuario.Text, txtContraseña.Text);

                    if (PassLogin == true)
                    {
                        this.Hide();
                        Principal principal = new Principal();
                        principal.Show();
                    }
                    else
                    {
                        msgError("Usuario o contraseña invalido");
                    }
                }
                else
                {
                    msgError("Por favor ingrese su contraseña");
                }
            }
            else
            {
                msgError("Por favor ingrese su usuario");
            }
            
        }
        private void msgError(string msg)
        {
            labelError.Text = "    " + msg;
            labelError.Visible = true;
        }
<<<<<<< HEAD

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtContraseña.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.Focus();
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsuario.Focus();
            }
        }
=======
>>>>>>> d3103f5ab1e675e1f037628da66a81cbda63ff95
    }
}
