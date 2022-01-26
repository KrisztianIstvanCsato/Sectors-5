namespace Sectors.Server.Data.Sample
{
    public interface ISectorValueModel
    {
        int Indentation { get; set; }
        string Name { get; set; }
        int SectorId { get; set; }
        int? SectorParent { get; set; }
    }
}