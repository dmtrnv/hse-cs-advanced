using System;


namespace PluginInterface
{
    [AttributeUsage(AttributeTargets.Class)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public int Patch { get; private set; }

        public VersionAttribute(int major, int minor, int patch)
        {
            if (major < 0 || minor < 0 || patch < 0)
            {
                throw new ArgumentException("Номер версии не может быть отрицательным.");
            }

            Major = major;
            Minor = minor;
            Patch = patch;
        }

        public override string ToString()
            => $"{Major}.{Minor}.{Patch}";
    }
}