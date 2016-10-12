using SmartHomeSimulator.Controls;

namespace SmartHomeSimulator.Model
{
    public class BaseResource
    {
        protected IctlDevice Parent;

        public BaseResource(IctlDevice deciveCtl)
        {
            Parent = deciveCtl;
        }
    }
}
