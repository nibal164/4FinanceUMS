﻿namespace _4FinanceTMS.Dtos
{
    public class TeacherDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Specality { get; set; } = string.Empty;
    }
}
