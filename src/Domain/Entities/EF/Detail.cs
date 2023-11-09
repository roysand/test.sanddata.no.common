namespace Test.sanddata.no.common.Domain.Entities.EF;

public class Detail
{
    public Guid Id { get; set; }
    public Guid MeasurementId { get; set; }
    public DateTime TimeStamp { get; set; }
    public string Location { get; set; }
    public string Name { get; set; }
    public string ObisCode { get; set; }
    public string Unit { get; set; }
    public string ValueStr { get; set; }
    public decimal ValueNum { get; set; }

    public Detail()
    {
        Id = Guid.NewGuid();
    }
}