using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Models.Entity
{
    [Table("Loggers", Schema = "LOG")]
    public class Logger : GeneralEntity
    {

    }
}
