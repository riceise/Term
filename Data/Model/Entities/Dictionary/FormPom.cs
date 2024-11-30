
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Форма медицинской помощи.В НСИ ФФОМС справочник V014
    /// </summary>
    [Table(name: "FormPoms", Schema = "dict")]
    public class FormPom : DictionaryBaseType<int>
    {

    }
}
