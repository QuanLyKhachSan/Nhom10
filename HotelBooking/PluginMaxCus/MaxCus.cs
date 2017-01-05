using BUS;
using ManagePlugin;

namespace PluginMaxCus
{
    public class MaxCus : IPlugin
    {
        public double UpdateValue(double value)
        {
            if (ThamSoBUS.CapNhatTSSoKhachToiDa(value))
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
            return "Số khách tối đa";
        }
    }
}