using Domain.Base;
using Domain.Library.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Models.Entity
{
    [Table("Backups", Schema = "BAC")]
    public class Backup : GeneralEntity
    {
        public BackupType BackupType { get; set; }
        public string FileName { get; set; }
        public string FileAddress { get; set; }

    }
}
