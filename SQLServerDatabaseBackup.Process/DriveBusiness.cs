using SQLServerDatabaseBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLServerDatabaseBackup.Process
{
    public class DriveBusiness
    {
        IDriveRepository _repository;

        public DriveBusiness(IDriveRepository repository)
        {
            _repository = repository;
        }
        
        public List<Drive> GetDrives(String serverName)
        {
            return _repository.GetDrives(serverName);
        }

        public Drive GetLeastFilledDrive(String serverName)
        {
            return _repository.GetDrives(serverName)
                              .OrderByDescending(x => x.TotalFreeSpace)
                              .First();
        }

        public Drive GetDrive(String serverName, String drive)
        {
            return _repository.GetDrive(serverName, drive);
        }
    }

}
