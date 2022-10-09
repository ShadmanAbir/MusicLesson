﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MusicLesson.Models;

public partial class MusicLessonsDBContext : DbContext
{
    public MusicLessonsDBContext()
    {
    }

    public MusicLessonsDBContext(DbContextOptions<MusicLessonsDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Duration> Duration { get; set; }

    public virtual DbSet<Instrument> Instrument { get; set; }

    public virtual DbSet<Lessons> Lessons { get; set; }

    public virtual DbSet<Letters> Letters { get; set; }

    public virtual DbSet<Students> Students { get; set; }

    public virtual DbSet<Tutors> Tutors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-4504LM0;Initial Catalog=MusicLessonsDB;Integrated Security=True;TrustServerCertificate=True" +
            "");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Duration>(entity =>
        {
            entity.Property(e => e.DurationID).HasColumnOrder(0);
            entity.Property(e => e.Cost).HasColumnOrder(2);
            entity.Property(e => e.Length)
                .HasColumnOrder(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<Instrument>(entity =>
        {
            entity.Property(e => e.InstrumentID).HasColumnOrder(0);
            entity.Property(e => e.InstrumentName).HasColumnOrder(1);
        });

        modelBuilder.Entity<Lessons>(entity =>
        {
            entity.Property(e => e.LessonID).HasColumnOrder(0);
            entity.Property(e => e.DurationID).HasColumnOrder(4);
            entity.Property(e => e.InstrumentID).HasColumnOrder(2);
            entity.Property(e => e.LessonDateTime).HasColumnOrder(5);
            entity.Property(e => e.LetterID).HasColumnOrder(6);
            entity.Property(e => e.StudentID).HasColumnOrder(1);
            entity.Property(e => e.TutorID).HasColumnOrder(3);

            entity.HasOne(d => d.Duration).WithMany(p => p.Lessons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessons_Duration");

            entity.HasOne(d => d.Instrument).WithMany(p => p.Lessons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessons_Instrument");

            entity.HasOne(d => d.Letter).WithMany(p => p.Lessons).HasConstraintName("FK_Lessons_Letters");

            entity.HasOne(d => d.Student).WithMany(p => p.Lessons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessons_Students");

            entity.HasOne(d => d.Tutor).WithMany(p => p.Lessons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessons_Tutors");
        });

        modelBuilder.Entity<Letters>(entity =>
        {
            entity.Property(e => e.LetterID).HasColumnOrder(0);
            entity.Property(e => e.AccountNo).HasColumnOrder(7);
            entity.Property(e => e.BSB).HasColumnOrder(6);
            entity.Property(e => e.BankAccount).HasColumnOrder(5);
            entity.Property(e => e.BeginningComment).HasColumnOrder(3);
            entity.Property(e => e.PaymentStatus).HasColumnOrder(2);
            entity.Property(e => e.Reference).HasColumnOrder(1);
            entity.Property(e => e.Semester).HasColumnOrder(9);
            entity.Property(e => e.Signature).HasColumnOrder(4);
            entity.Property(e => e.Term).HasColumnOrder(8);
            entity.Property(e => e.TermStartDate).HasColumnOrder(11);
            entity.Property(e => e.TotalCost).HasColumnOrder(12);
            entity.Property(e => e.Year).HasColumnOrder(10);
        });

        modelBuilder.Entity<Students>(entity =>
        {
            entity.Property(e => e.StudentID).HasColumnOrder(0);
            entity.Property(e => e.DOB).HasColumnOrder(3);
            entity.Property(e => e.Email).HasColumnOrder(5);
            entity.Property(e => e.FirstName).HasColumnOrder(1);
            entity.Property(e => e.Guardian).HasColumnOrder(4);
            entity.Property(e => e.LastName).HasColumnOrder(2);
            entity.Property(e => e.Mobile)
                .HasColumnOrder(6)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tutors>(entity =>
        {
            entity.Property(e => e.TutorID).HasColumnOrder(0);
            entity.Property(e => e.TutorName).HasColumnOrder(1);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}