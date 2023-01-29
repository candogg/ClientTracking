using System;
using System.ComponentModel.DataAnnotations;

namespace MusteriTakip.Common.Models.Base
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class ItemBase
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public Guid UniqueId { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        [MaxLength(150)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime ModifyDate { get; set; }

        [Required]
        [MaxLength(150)]
        public string ModifiedBy { get; set; }

        [Required]
        [Range(0, 1)]
        public int IsActive { get; set; }
    }
}
