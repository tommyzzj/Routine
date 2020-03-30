﻿using Routine.Api.Entities;
using Routine.Api.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Routine.Api.Models
{
    [EmployeeNoMustDifferentFromFirstName(ErrorMessage = "员工编号不可以等于名！！！")]
    public class EmployeeAddDto : EmployeeAddOrUpdateDto
    { 
    }
}
