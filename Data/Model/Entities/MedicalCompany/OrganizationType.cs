using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//using Telerik.SvgIcons;

namespace Data.Model.Entities.MedicalCompany
{
    /// <summary>
    /// Тип организации
    /// </summary>
    [Table(name: "OrganizationTypes", Schema = "LPU")]
    public class OrganizationType : BaseEntityforApiV1
    {
        [MaxLength(250)]
        public string Name { get; set; }
        public OrganizationType()
        {
            Name = string.Empty;
        }
    }
}
