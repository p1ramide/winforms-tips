using System.Runtime.InteropServices;

public class DarkMode
{
    private const int attributo = 20;

    [DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
    private static extern int setAttributo(IntPtr hwnd, int attr, ref int valoreAttributo, int dimensioneAttributo);

    public static void attivaDarkMode(IntPtr handle)
    {
        int usaDarkMode = 1;
        setAttributo(handle, attributo, ref usaDarkMode, sizeof(int));
    }
}

private void Form1_Load(object sender, EventArgs e)
{
   DarkMode.attivaDarkMode(this.Handle);
}
