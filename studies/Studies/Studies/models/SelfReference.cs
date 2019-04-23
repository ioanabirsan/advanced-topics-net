using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studies.models
{
    public sealed class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; set; }

        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; set; }

        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }

        public ICollection<SelfReference> References { get; set; }

        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
    }
}