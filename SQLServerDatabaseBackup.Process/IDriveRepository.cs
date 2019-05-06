using SQLServerDatabaseBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLServerDatabaseBackup.Process
{
    public interface IDriveRepository
    {
        ulong GetFreeDriveSpace(Drive d);
        List<Drive> GetDrives(String serverName);
        Drive GetDrive(String serverName, String drive);
    }
}
