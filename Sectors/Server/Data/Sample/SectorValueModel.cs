namespace Sectors.Server.Data.Sample
{
    public class SectorValueModel : ISectorValueModel
    {
        public int SectorId { get; set; }
        public string Name { get; set; }
        public int Indentation { get; set; }
        public int? SectorParent { get; set; }
    }
}
