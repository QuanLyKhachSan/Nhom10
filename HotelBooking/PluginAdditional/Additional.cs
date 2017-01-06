using BUS;
using ManagePlugin;

namespace PluginAdditional
{
    public class Additional : IPlugin
    {
        public double UpdateValue(double value)
        {
            if (ThamSoBUS.CapNhatTSPhuThu(value))
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
            return "Phụ thu";
        }
    }
}