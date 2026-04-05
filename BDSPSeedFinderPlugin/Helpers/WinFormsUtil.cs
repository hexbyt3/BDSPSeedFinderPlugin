using System;
using System.Media;
using System.Windows.Forms;

namespace BDSPSeedFinderPlugin.Helpers;

public static class WinFormsUtil
{
    public static DialogResult Alert(params string[] lines)
    {
        SystemSounds.Asterisk.Play();
        string msg = string.Join(Environment.NewLine + Environment.NewLine, lines);
        return MessageBox.Show(msg, "BDSP Seed Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Error(params string[] lines)
    {
        SystemSounds.Hand.Play();
        string msg = string.Join(Environment.NewLine + Environment.NewLine, lines);
        return MessageBox.Show(msg, "BDSP Seed Finder - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
