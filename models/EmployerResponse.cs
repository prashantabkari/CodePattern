

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployerApi.Models.Employer;

// Record is created because Employer Object is immutable
public record Employer
{
    //Key denotes its a Primary key for the Employer Entity
    [Key] public Guid EmployerId { get; init; }

    [MaxLength(64)]
    public string? Name { get; init; }

    [MaxLength(64)]
    public string? ClientDealerCode { get; init; }

    public  bool Active { get; init; }

}
