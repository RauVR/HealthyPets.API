﻿using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Profiles.Domain.Model;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Client = MySqlX.XDevAPI.Client;

namespace HealthyPets.API.MedicalRecords.Domain.Models;

public class Evaluation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    public Client Client { get; set; }
    public Pet Pet { get; set; }
    public  Vet Vet { get; set; }
    public string Report { get; set; }
    
}