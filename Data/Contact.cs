﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace CMS.Data
{
    /// <summary>
    /// Contact entity.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [Required]
        [StringLength(250, ErrorMessage = "First name cannot exceed 250 characters.")]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional last name.
        /// </summary>
        [Required]
        [StringLength(250, ErrorMessage = "Last name cannot exceed 250 characters.")]
        public string LastName { get; set; }

        /// <summary>
        /// Phone.
        /// </summary>
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 digits.")]
        public string Phone { get; set; }

        /// <summary>
        /// BirthDate
        /// </summary>
        [Required]
        public DateTime BirthDate { get; set; }

        

    }
}
