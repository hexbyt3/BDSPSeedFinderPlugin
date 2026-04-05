using System;

namespace BDSPSeedFinderPlugin;

public static class PluginVersion
{
    public static Version? PluginAssemblyVersion => GetLoadedVersion("BDSPSeedFinderPlugin");
    public static Version? LoadedPKHeXVersion => GetLoadedVersion("PKHeX.Core");

    public static bool IsCompatible()
    {
        var loaded = LoadedPKHeXVersion;
        var plugin = PluginAssemblyVersion;
        if (loaded == null || plugin == null)
            return true;
        return loaded.Major == plugin.Major && loaded.Minor == plugin.Minor;
    }

    public static string GetCompatibilityMessage()
    {
        var loaded = LoadedPKHeXVersion;
        var plugin = PluginAssemblyVersion;
        if (loaded == null || plugin == null)
            return "Unable to detect version information.";
        if (IsCompatible())
            return $"Plugin v{plugin} - Compatible with PKHeX v{loaded}";
        return $"Version mismatch! Plugin v{plugin} may not be compatible with PKHeX v{loaded}";
    }

    public static bool HasVersionMismatch()
    {
        var loaded = LoadedPKHeXVersion;
        var plugin = PluginAssemblyVersion;
        if (loaded == null || plugin == null)
            return false;
        return loaded.Major != plugin.Major || loaded.Minor != plugin.Minor;
    }

    private static Version? GetLoadedVersion(string assemblyName)
    {
        try
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var assembly = Array.Find(assemblies, x => x.GetName().Name == assemblyName);
            return assembly?.GetName().Version;
        }
        catch
        {
            return null;
        }
    }
}
