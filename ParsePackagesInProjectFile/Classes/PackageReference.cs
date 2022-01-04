using System;

namespace ParsePackagesInProjectFile
{
    public class PackageReference
    {
        public string FileName { get; set; }
        public string Include { get; set; }
        public Version Version { get; set; }
        public override string ToString() => Include;

    }
}