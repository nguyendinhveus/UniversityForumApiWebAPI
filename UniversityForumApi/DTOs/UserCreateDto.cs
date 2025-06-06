﻿using System.ComponentModel.DataAnnotations;

namespace UniversityForumApi.DTOs
{
    public class UserCreateDto
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone]
        public string Contact { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
