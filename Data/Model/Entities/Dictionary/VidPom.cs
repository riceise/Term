using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Вид медицинской помощи.В НСИ ФФОМС справочник V008 Приложение А
    /// </summary>
    [Table(name: "VidPoms", Schema = "dict")]
    public class VidPom : DictionaryBaseType<int>
    {

    }
}
