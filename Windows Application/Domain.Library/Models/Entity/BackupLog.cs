using Domain.Base;
using Domain.Library.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Models.Entity
{
    [Table("BackupLogs", Schema = "LOG")]
    public class BackupLog : GeneralEntity
    {
        public BackupType BackupType { get; set; }
        public string FileName { get; set; }
        public string FileAddress { get; set; }

    }
}
