using BUS;
using ManagePlugin;

namespace PluginCoefficient
{
    public class Coefficient : IPlugin
    {
        public double UpdateValue(double value)
        {
            if (ThamSoBUS.CapNhatTSHeSo(value))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string GetName()
        {
            return "Hệ số";
        }
    }
}