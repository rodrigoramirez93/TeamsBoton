using System.Runtime.InteropServices;

namespace TeamsBotonProject
{
    public partial class MainForm : Form
    {
        public bool Started { get; set; }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public MainForm()
        {
            InitializeComponent();
            Started = false;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Started = !Started;

            if (Started)
                Logic.Enable(this);
            else
                Logic.Disable(this);
        }

        static class Logic
        {
            internal static void Enable(MainForm mainForm)
            {
                UI(mainForm, System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\Resources\cool.png", false, "ESC");
                Timer(mainForm, enabled: true);
            }

            internal static void Disable(MainForm mainForm)
            {
                UI(mainForm, System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\Resources\pissed.png", true, "Iniciar");
                Timer(mainForm, enabled: false);
            }

            static void UI(MainForm mainForm, string imagePath, bool btnEnabled, string btnText)
            {
                mainForm.imgPepe.ImageLocation = imagePath;
                mainForm.btnAction.Enabled = btnEnabled;
                mainForm.btnAction.Text = btnText;
            }

            static void Timer(MainForm mainForm, bool enabled)
            {
                mainForm.timerMouse.Enabled = enabled;
            }
        }

        void timerMouse_Tick(object sender, EventArgs e)
        {
            SetCursorPos(new Random().Next(1, 500), new Random().Next(1, 500));
        }

        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && Started)
            {
                Logic.Disable(this);
                Started = false;
            }
        }
    }
}