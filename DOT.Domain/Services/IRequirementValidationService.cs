using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Entities;

namespace DOT.Domain.Services
{
    public interface IRequirementValidationService
    {
        ValidationResult ValidateRequirement(Requirement requirement);
        ValidationResult ValidateRequirementForUpdate(Requirement existing, Requirement newRequirement);
        List<string> GetValidationErrors(Requirement requirement);
    }

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; } = new();
        public List<string> Warnings { get; set; } = new();
    }
}
