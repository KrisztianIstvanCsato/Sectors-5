﻿using Sectors.Server.Data.Sample;
using Sectors.Shared;

namespace Sectors.Server.Data
{
    public class SampleSectorSelector
    {
        private List<SectorModel> list = new List<SectorModel>{
                 new SectorModel { Id = 1, SectorId = 1, Name = "Manufacturing" },
                 new SectorModel { Id = 2, SectorId = 19, Name = "Construction materials" },
                 new SectorModel { Id = 3, SectorId = 18, Name = "Electronics and Optics" },
                 new SectorModel { Id = 4, SectorId = 6, Name = "Food and Beverage" },
                 new SectorModel { Id = 5, SectorId = 342, Name = "Bakery & confectionery products" },
                 new SectorModel { Id = 6, SectorId = 43, Name = "Beverages" },
                 new SectorModel { Id = 7, SectorId = 42, Name = "Fish & fish products" },
                 new SectorModel { Id = 8, SectorId = 40, Name = "Meat & meat products" },
                 new SectorModel { Id = 9, SectorId = 39, Name = "Milk & dairy products" },
                 new SectorModel { Id = 10, SectorId = 437, Name = "Other" },
                 new SectorModel { Id = 11, SectorId = 378, Name = "Sweets & snack food" },
                 new SectorModel { Id = 12, SectorId = 13, Name = "Furniture" },
                 new SectorModel { Id = 13, SectorId = 389, Name = "Bathroom/sauna" },
                 new SectorModel { Id = 14, SectorId = 385, Name = "Bedroom" },
                 new SectorModel { Id = 15, SectorId = 390, Name = "Children’s room" },
                 new SectorModel { Id = 16, SectorId = 98, Name = "Kitchen" },
                 new SectorModel { Id = 17, SectorId = 101, Name = "Living room" },
                 new SectorModel { Id = 18, SectorId = 392, Name = "Office" },
                 new SectorModel { Id = 19, SectorId = 394, Name = "Other (Furniture)" },
                 new SectorModel { Id = 20, SectorId = 341, Name = "Outdoor" },
                 new SectorModel { Id = 21, SectorId = 99, Name = "Project furniture" },
                 new SectorModel { Id = 22, SectorId = 12, Name = "Machinery" },
                 new SectorModel { Id = 23, SectorId = 94, Name = "Machinery components" },
                 new SectorModel { Id = 24, SectorId = 91, Name = "Machinery equipment/tools" },
                 new SectorModel { Id = 25, SectorId = 224, Name = "Manufacture of machinery" },
                 new SectorModel { Id = 26, SectorId = 97, Name = "Maritime" },
                 new SectorModel { Id = 27, SectorId = 271, Name = "Aluminium and steel workboats" },
                 new SectorModel { Id = 28, SectorId = 269, Name = "Boat/Yacht building" },
                 new SectorModel { Id = 29, SectorId = 230, Name = "Ship repair and conversion" },
                 new SectorModel { Id = 30, SectorId = 93, Name = "Metal structures" },
                 new SectorModel { Id = 31, SectorId = 508, Name = "Other" },
                 new SectorModel { Id = 32, SectorId = 227, Name = "Repair and maintenance service" },
                 new SectorModel { Id = 33, SectorId = 11, Name = "Metalworking" },
                 new SectorModel { Id = 34, SectorId = 67, Name = "Construction of metal structures" },
                 new SectorModel { Id = 35, SectorId = 263, Name = "Houses and buildings" },
                 new SectorModel { Id = 36, SectorId = 267, Name = "Metal products" },
                 new SectorModel { Id = 37, SectorId = 542, Name = "Metal works" },
                 new SectorModel { Id = 38, SectorId = 75, Name = "CNC-machining" },
                 new SectorModel { Id = 39, SectorId = 62, Name = "Forgings, Fasteners" },
                 new SectorModel { Id = 40, SectorId = 69, Name = "Gas, Plasma, Laser cutting" },
                 new SectorModel { Id = 41, SectorId = 66, Name = "MIG, TIG, Aluminum welding" },
                 new SectorModel { Id = 42, SectorId = 9, Name = "Plastic and Rubber" },
                 new SectorModel { Id = 43, SectorId = 54, Name = "Packaging" },
                 new SectorModel { Id = 44, SectorId = 556, Name = "Plastic goods" },
                 new SectorModel { Id = 45, SectorId = 559, Name = "Plastic processing technology" },
                 new SectorModel { Id = 46, SectorId = 55, Name = "Blowing" },
                 new SectorModel { Id = 47, SectorId = 57, Name = "Moulding" },
                 new SectorModel { Id = 48, SectorId = 53, Name = "Plastics welding and processing" },
                 new SectorModel { Id = 49, SectorId = 560, Name = "Plastic profiles" },
                 new SectorModel { Id = 50, SectorId = 5, Name = "Printing" },
                 new SectorModel { Id = 51, SectorId = 148, Name = "Advertising" },
                 new SectorModel { Id = 52, SectorId = 150, Name = "Book/Periodicals printing" },
                 new SectorModel { Id = 53, SectorId = 145, Name = "Labelling and packaging printing" },
                 new SectorModel { Id = 54, SectorId = 7, Name = "Textile and Clothing" },
                 new SectorModel { Id = 55, SectorId = 44, Name = "Clothing" },
                 new SectorModel { Id = 56, SectorId = 45, Name = "Textile" },
                 new SectorModel { Id = 57, SectorId = 8, Name = "Wood" },
                 new SectorModel { Id = 58, SectorId = 337, Name = "Other (Wood)" },
                 new SectorModel { Id = 59, SectorId = 51, Name = "Wooden building materials" },
                 new SectorModel { Id = 60, SectorId = 47, Name = "Wooden houses" },
                 new SectorModel { Id = 61, SectorId = 3, Name = "Other" },
                 new SectorModel { Id = 62, SectorId = 37, Name = "Creative industries" },
                 new SectorModel { Id = 63, SectorId = 29, Name = "Energy technology" },
                 new SectorModel { Id = 64, SectorId = 33, Name = "Environment" },
                 new SectorModel { Id = 65, SectorId = 2, Name = "Service" },
                 new SectorModel { Id = 66, SectorId = 25, Name = "Business services" },
                 new SectorModel { Id = 67, SectorId = 35, Name = "Engineering" },
                 new SectorModel { Id = 68, SectorId = 28, Name = "Information Technology and Telecommunications" },
                 new SectorModel { Id = 69, SectorId = 581, Name = "Data processing, Web portals, E-marketing" },
                 new SectorModel { Id = 70, SectorId = 576, Name = "Programming, Consultancy" },
                 new SectorModel { Id = 71, SectorId = 121, Name = "Software, Hardware" },
                 new SectorModel { Id = 72, SectorId = 122, Name = "Telecommunications" },
                 new SectorModel { Id = 73, SectorId = 22, Name = "Tourism" },
                 new SectorModel { Id = 74, SectorId = 141, Name = "Translation services" },
                 new SectorModel { Id = 75, SectorId = 21, Name = "Transport and Logistics" },
                 new SectorModel { Id = 76, SectorId = 111, Name = "Air" },
                 new SectorModel { Id = 77, SectorId = 114, Name = "Rail" },
                 new SectorModel { Id = 78, SectorId = 112, Name = "Road" },
                 new SectorModel { Id = 79, SectorId = 113, Name = "Water" }
        };

        private readonly string _sampleString = @"
    <option value=1>
      Manufacturing
    </option>
    <option value=19>
      &nbsp;&nbsp;&nbsp;&nbsp;Construction materials
    </option>
    <option value=18>
      &nbsp;&nbsp;&nbsp;&nbsp;Electronics and Optics
    </option>
    <option value=6>
      &nbsp;&nbsp;&nbsp;&nbsp;Food and Beverage
    </option>
    <option value=342>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bakery & confectionery products
    </option>
    <option value=43>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Beverages
    </option>
    <option value=42>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fish & fish products
    </option>
    <option value=40>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Meat & meat products
    </option>
    <option value=39>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Milk & dairy products
    </option>
    <option value=437>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other
    </option>
    <option value=378>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Sweets & snack food
    </option>
    <option value=13>
      &nbsp;&nbsp;&nbsp;&nbsp;Furniture
    </option>
    <option value=389>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bathroom/sauna
    </option>
    <option value=385>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bedroom
    </option>
    <option value=390>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Children’s room
    </option>
    <option value=98>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Kitchen
    </option>
    <option value=101>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Living room
    </option>
    <option value=392>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Office
    </option>
    <option value=394>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other (Furniture)
    </option>
    <option value=341>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Outdoor
    </option>
    <option value=99>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Project furniture
    </option>
    <option value=12>
      &nbsp;&nbsp;&nbsp;&nbsp;Machinery
    </option>
    <option value=94>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Machinery components
    </option>
    <option value=91>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Machinery equipment/tools
    </option>
    <option value=224>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manufacture of machinery
    </option>
    <option value=97>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Maritime
    </option>
    <option value=271>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Aluminium and steel workboats
    </option>
    <option value=269>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Boat/Yacht building
    </option>
    <option value=230>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Ship repair and conversion
    </option>
    <option value=93>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Metal structures
    </option>
    <option value=508>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other
    </option>
    <option value=227>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Repair and maintenance service
    </option>
    <option value=11>
      &nbsp;&nbsp;&nbsp;&nbsp;Metalworking
    </option>
    <option value=67>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Construction of metal structures
    </option>
    <option value=263>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Houses and buildings
    </option>
    <option value=267>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Metal products
    </option>
    <option value=542>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Metal works
    </option>
    <option value=75>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;CNC-machining
    </option>
    <option value=62>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Forgings, Fasteners
    </option>
    <option value=69>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Gas, Plasma, Laser cutting
    </option>
    <option value=66>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MIG, TIG, Aluminum welding
    </option>
    <option value=9>
      &nbsp;&nbsp;&nbsp;&nbsp;Plastic and Rubber
    </option>
    <option value=54>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Packaging
    </option>
    <option value=556>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Plastic goods
    </option>
    <option value=559>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Plastic processing technology
    </option>
    <option value=55>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Blowing
    </option>
    <option value=57>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Moulding
    </option>
    <option value=53>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Plastics welding and processing
    </option>
    <option value=560>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Plastic profiles
    </option>
    <option value=5>
      &nbsp;&nbsp;&nbsp;&nbsp;Printing
    </option>
    <option value=148>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Advertising
    </option>
    <option value=150>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Book/Periodicals printing
    </option>
    <option value=145>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Labelling and packaging printing
    </option>
    <option value=7>
      &nbsp;&nbsp;&nbsp;&nbsp;Textile and Clothing
    </option>
    <option value=44>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Clothing
    </option>
    <option value=45>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Textile
    </option>
    <option value=8>
      &nbsp;&nbsp;&nbsp;&nbsp;Wood
    </option>
    <option value=337>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other (Wood)
    </option>
    <option value=51>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wooden building materials
    </option>
    <option value=47>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wooden houses
    </option>
    <option value=3>
      Other
    </option>
    <option value=37>
      &nbsp;&nbsp;&nbsp;&nbsp;Creative industries
    </option>
    <option value=29>
      &nbsp;&nbsp;&nbsp;&nbsp;Energy technology
    </option>
    <option value=33>
      &nbsp;&nbsp;&nbsp;&nbsp;Environment
    </option>
    <option value=2>
      Service
    </option>
    <option value=25>
      &nbsp;&nbsp;&nbsp;&nbsp;Business services
    </option>
    <option value=35>
      &nbsp;&nbsp;&nbsp;&nbsp;Engineering
    </option>
    <option value=28>
      &nbsp;&nbsp;&nbsp;&nbsp;Information Technology and Telecommunications
    </option>
    <option value=581>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Data processing, Web portals, E-marketing
    </option>
    <option value=576>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Programming, Consultancy
    </option>
    <option value=121>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Software, Hardware
    </option>
    <option value=122>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Telecommunications
    </option>
    <option value=22>
      &nbsp;&nbsp;&nbsp;&nbsp;Tourism
    </option>
    <option value=141>
      &nbsp;&nbsp;&nbsp;&nbsp;Translation services
    </option>
    <option value=21>
      &nbsp;&nbsp;&nbsp;&nbsp;Transport and Logistics
    </option>
    <option value=111>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Air
    </option>
    <option value=114>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Rail
    </option>
    <option value=112>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Road
    </option>
    <option value=113>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Water
    </option>";

        public List<SectorValueModel> ProcessSample()
        {
            var processedSample = _sampleString;
            List<SectorValueModel> sectorValueModels = new();

            processedSample = processedSample.Replace(@"</option>
    < option value = ", ",");
            processedSample = processedSample.Replace("<option value=", "");
            processedSample = processedSample.Replace("</option>", "");
            
            var sampleArray = processedSample.Split(",");
            
            foreach(var item in sampleArray)
            {
                var itemPartsArray = item.Split("<");
                var sectorId = itemPartsArray[0];
                var indentationSplit = itemPartsArray[1].Split("nbsp;");
                var indentationCount = indentationSplit.Length;
                var indentationNumber = indentationCount.Equals(1) ? 0 : indentationCount - 1;
                var sectorName = indentationCount.Equals(1) ? indentationSplit[0] : indentationSplit[indentationCount - 1];
                var sectorParent =

                new SectorValueModel
                {
                    //SectorId = Int32.Parse(itemPartsArray[0]),
                    //Name = sectorName,
                    //Indentation = indentationNumber,
                    //SectorParent = 
                };
                //sectorValueModels.Add
            };

            return sectorValueModels;
        }
    }
}
