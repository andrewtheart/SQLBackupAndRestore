using SQLServerDatabaseBackup.Models;
using SQLServerDatabaseBackup.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SQLServerDatabaseBackup.Process
{

    public class DriveRepository : IDriveRepository
    {

        public List<Drive> GetDrives(String serverName)
        {

            var drives = new List<Drive>();

            if (serverName.Contains("\\"))
            {
                serverName = serverName.Split('\\')[0];
            }

            foreach (var d in DriveInfo.GetDrives())
            {
                drives.Add
                (
                    new Drive
                    {
                        LocalDriveName = d.Name.Replace("\\", ""),
                        UNCDriveName = d.Name.Replace(":", "").Replace(@"\", "") + @"$\", Path = serverName,
                        TotalFreeSpace = (ulong)d.AvailableFreeSpace
                    }
                );
            }


            return drives;
        }

        public Drive GetDrive(String serverName, String drive)
        {
            Drive theDrive = null;

            if (serverName.Contains("\\"))
            {
                serverName = serverName.Split('\\')[0];
            }

            theDrive = new Drive { LocalDriveName = drive + ":", UNCDriveName = drive + "$", Path = serverName };

            theDrive.TotalFreeSpace = DriveUtils.DriveBytesFree("\\\\" + serverName + "\\" + theDrive.UNCDriveName);

            return theDrive;
        }

        public ulong GetFreeDriveSpace(Drive d)
        {
            return DriveUtils.DriveBytesFree(d.UNCDriveName);
        }



    }
}
