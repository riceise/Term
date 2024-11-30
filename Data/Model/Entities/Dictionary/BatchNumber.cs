using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Номер партии для пакета
    /// </summary>
    [Table(name: "BatchNumbers", Schema = "dict")]
    [Index(nameof(Code))]
    public class BatchNumber : DictionaryBaseType<int>
    {
    }
}
