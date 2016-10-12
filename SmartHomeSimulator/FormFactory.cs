using SmartHomeSimulator.Controls;
using SmartHomeSimulator.Model;
using System.Windows.Forms;

namespace SmartHomeSimulator
{
    class FormFactory
    {
        public static ViewForm CreateForm(Building building)
        {
            ViewForm frmMain = ViewForm.Instance;

            foreach (Floor floor in building.Floors)
            {
                Control floorCtl = frmMain.AddFloor(floor.Name);

                int roomNum = 0;
                foreach (Room room in floor.Rooms)
                {
                    bool isLast = (roomNum == (floor.Rooms.Count - 1));
                    Control roomCtl = frmMain.AddRoom(floorCtl, room.Name, isLast);

                    foreach (Device device in room.Devices)
                    {
                        try
                        {
                            Control deviceCtl = frmMain.AddDevice(roomCtl, device.Type, device.ID);
                            device.View = deviceCtl as IctlDevice;
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    roomNum++;
                }
            }

            return frmMain;
        }
    }
}
