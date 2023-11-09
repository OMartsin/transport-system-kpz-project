﻿namespace TransportSystem.DTO; 

public class TransportInsuranceDto {
    public int TransportInsuranceId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string? PolicyNumber { get; set; }
    public int InsuranceAgentId { get; set; }
}