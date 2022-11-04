﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace todo_domain_entities
{
    public enum ToDoStatus
    {
        Completed,
        InProgress,
        NotStarted
    }

    /// <summary>
    /// ToDoEntry class that represents T0D0 entry of T0D0 list
    /// </summary>
    public class ToDoEntry : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        public int OrdinalNumber { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; } = null;

        [Required]
        public ToDoStatus Status { get; set; } = ToDoStatus.NotStarted;

        [Required]
        public virtual ToDoList ToDoList { get; set; }

        public override bool Equals(object obj)
        {
            return ((ToDoEntry)obj)?.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if(OrdinalNumber == 0)
            {
                errors.Add(new ValidationResult("OrdinalNumber is not set"));
            }

            if(string.IsNullOrEmpty(Title))
            {
                errors.Add(new ValidationResult("Title is not set"));
            }

            if (ToDoList == null)
            {
                errors.Add(new ValidationResult("ToDoList is not set"));
            }

            return errors;
        }

        public bool IsTheSame(ToDoEntry item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!string.Equals(Title, item.Title))
                return false;

            if (!string.Equals(Title, item.Title))
                return false;

            if (DueDate != item.DueDate)
                return false;

            if (!ToDoList.IsTheSame(item.ToDoList))
                return false;

            return true;
        }
    }
}
