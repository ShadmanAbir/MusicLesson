﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MusicLesson.Models;

public partial class Letters
{
    [Key]
    public int LetterID { get; set; }

    [Required]
    [StringLength(500)]
    [Unicode(false)]
    public string Reference { get; set; }

    public bool PaymentStatus { get; set; }

    [Required]
    public string BeginningComment { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string Signature { get; set; }

    [Required]
    public string BankAccount { get; set; }

    [Required]
    [StringLength(6)]
    public string BSB { get; set; }

    [Required]
    [StringLength(30)]
    public string AccountNo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal TotalCost { get; set; }

    [InverseProperty("Letter")]
    public virtual ICollection<Lessons> Lessons { get; } = new List<Lessons>();
    [NotMapped]
    public List<Lessons>? LessonList { get; set; }
}