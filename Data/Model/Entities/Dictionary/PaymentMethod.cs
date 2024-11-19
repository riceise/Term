using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Cпособы оплаты медицинской помощи. В НСИ ФФОМС справочник V010
    /// </summary>
    [Table(name: "PaymentMethods", Schema = "dict")]
    public class PaymentMethod : DictionaryBaseType<int>
    {

    }
}
