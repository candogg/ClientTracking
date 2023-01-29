using MusteriTakip.Common.Enums;
using MusteriTakip.Common.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace MusteriTakip.Common.Models.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class ClientItem : ItemBase
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [MaxLength(150)]
        public string School { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [MaxLength(150)]
        public string MothersName { get; set; }

        [Required]
        [MaxLength(150)]
        public string MothersSurname { get; set; }

        [MaxLength(150)]
        public string MothersJob { get; set; }

        [Required]
        [MaxLength(15)]
        public string MothersCellphone { get; set; }

        [MaxLength(150)]
        public string MothersMail { get; set; }

        [Required]
        [MaxLength(150)]
        public string FathersName { get; set; }

        [Required]
        [MaxLength(150)]
        public string FathersSurname { get; set; }

        [MaxLength(150)]
        public string FathersJob { get; set; }

        [Required]
        [MaxLength(15)]
        public string FathersCellphone { get; set; }

        [MaxLength(150)]
        public string FathersMail { get; set; }

        [Required]
        public ChildResponsibleEnum Responsible { get; set; }

        [Required]
        [Range(0, 1)]
        public int ReminderActive { get; set; }
    }
}
