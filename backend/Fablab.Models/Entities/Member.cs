using Fablab.Models.Entities.Base;

namespace Fablab.Models.Entities
{
    public class Member : BaseEntity
    {
        public string Name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Newsletter { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Job { get; set; }
        public string Interest { get; set; }
        public string Cad_software { get; set; }
        public string Group { get; set; }
        public string Signature { get; set; }
        public string Validated_training { get; set; }
        public string Tags { get; set; }
        public string Invoice_disabled { get; set; }
        public string Projects { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public int Number_Invoices { get; set; }
        public string Ecocience { get; set; }
        public string Organization { get; set; }
        public string Organization_Address { get; set; }
        public int Aux_Group { get; set; }
        public int Aux_Training { get; set; }
        public int Aux_Group_Training { get; set; }
    }
}