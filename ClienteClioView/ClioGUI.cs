using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClienteClioLogic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Timers;



namespace ClienteClioView
{
    public partial class ClioGUI : Form
    {
        private bool logged = false;
        private String username;
        private String password;
        private bool control;
        System.Timers.Timer timer;
        // Structure contain information about low-level keyboard input event
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        //System level functions to be used for hook and unhook keyboard input
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);


        //Declaring Global objects
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess; 

        public ClioGUI()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
           
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false;

            //this.TopMost = true;
            
        }
        private void ClioGUI_Load(object sender, System.EventArgs e)
        {
            
        }

        public void logout() {
            bool res = Logica.logout();
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            label3.Text = "";
            Show();

            this.WindowState = FormWindowState.Maximized;
            logged = false;
            Thread a = new Thread(Refresh);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int ancho = this.ClientSize.Width;
            int alto = this.ClientSize.Height;
            panel2.Top = alto / 2 - 75;
            panel2.Left = ancho / 2 - 135;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
       

        private void ClioGUI_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool res = Logica.logout();
            textBox1.Text = "";
            label3.Text="";
            maskedTextBox1.Text = "";
            Show();
            this.WindowState = FormWindowState.Maximized;
            logged = false;
            Thread a = new Thread(Refresh);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            username=textBox1.Text;
            password = maskedTextBox1.Text;
            if (checkBox1.Checked) {
                if (Logica.RegistrarCliente(textBox1.Text, maskedTextBox1.Text))
                {
                    long res = Logica.Login2(textBox1.Text, maskedTextBox1.Text);
                    if (res!=0)
                    {
                        if (!(username.Equals("admin") && password.Equals("admin")))
                        {
                            registrarPcCLienteToolStripMenuItem.Visible = false;
                            cerrarProgramaToolStripMenuItem.Visible = false;
                        }
                        this.WindowState = FormWindowState.Minimized;
                        logged = true;
                        label3.Text = "";

                        if (res > 0) {
                            ThreadStart param = delegate { controlTiempo(res); };
                            Thread hilo = new Thread(param);
                            hilo.Start();
                          
                        }

                    }

                }
                else
                    label3.Text = "";
                    label3.Text = "Credenciales no válidas, o el usuario ya se encuentra registrado";
            }
            else
            {
               long res = Logica.Login2(textBox1.Text, maskedTextBox1.Text);
               if (res!=0){
                    if (!(username.Equals("admin") && password.Equals("admin")))
                    {
                        registrarPcCLienteToolStripMenuItem.Visible = false;
                        cerrarProgramaToolStripMenuItem.Visible = false;
                    }
                    this.WindowState = FormWindowState.Minimized;
                    logged = true;
                    label3.Text = "";
                    if (res > 0)
                    {
                        ThreadStart param = delegate { controlTiempo(res); };
                        Thread hilo = new Thread(param);
                        hilo.Start();
                       
                    }

                }
                else
                    label3.Text = "                        Credenciales no válidas";
            }
           // Refresh();
           Thread a= new Thread(Refresh);
        }

         void mostrarNotificacion(object sender, EventArgs e)

        {
            if (control)
            {
                timer.Stop();
                timer.Enabled = false;
                timer = null;
                Mensaje ventana = new Mensaje("Su tiempo ha expirado. Se cerrara su sesión en 3 minutos");
                
                //Application.Run(ventana);
                // ventana.Show();
                //ThreadStart param = delegate { new Mensaje(); };
                ThreadStart param = delegate { Application.Run(ventana); };

                Thread serverThread = new Thread(param);
                serverThread.Start();
                
                            
                timer = new System.Timers.Timer();
                timer.Elapsed += new ElapsedEventHandler(mostrarNotificacion);          
                timer.Interval = 5000;             
                timer.Enabled = true;                      
                timer.Start();  
                control=false;
            }
            else { 
                timer.Stop();
                timer.Enabled = false;
                timer = null;                                   

                logout();// Enable the timer            
            }

        }
        public void controlTiempo(long time) {
            control = true;
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(mostrarNotificacion);          
            timer.Interval = time;             
            timer.Enabled = true;                      
            timer.Start();                                                      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                if (objKeyInfo.key == Keys.Escape && objKeyInfo.key == Keys.Shift && objKeyInfo.key == Keys.Control && logged == false) // Disabling Windows keys
                {

                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }



        private void ClioGUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        public byte [] SaveScreenShot(string filename, ImageFormat format)
        {
            Bitmap screenShot = CaptureScreenShot();
            MemoryStream ms = new MemoryStream();
            screenShot.Save(ms, format);
            return ms.ToArray();
        }

        /// <summary>
        /// Saves a picture of the screen to a bitmap image.
        /// </summary>
        /// <returns>The saved bitmap.</returns>
        private Bitmap CaptureScreenShot()
        {
            // get the bounding area of the screen containing (0,0)
            // remember in a multidisplay environment you don't know which display holds this point
            Rectangle bounds = Screen.GetBounds(Point.Empty);

            // create the bitmap to copy the screen shot to
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            // now copy the screen image to the graphics device from the bitmap
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }

            return bitmap;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registrarPcCLienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPC registro = new RegistrarPC();
            registro.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
          }
}
