using SmartHomeSimulator.Comm;
using System.Windows.Forms;

namespace SmartHomeSimulator.Util
{
    public delegate void VoidDelegate();
    public delegate void BoolDelegate(bool parameter);
    public delegate void IntDelegate(int parameter);
    public delegate void StringDelegate(string parameter);

    public delegate void CheckBoxDelegate(CheckBox chkBox, bool parameter);
    
    public delegate void ClientStoppedEventHandler(CommClient source);
}
