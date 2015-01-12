using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class FoxTargetDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr TargetFile { get; set; }
    }
}