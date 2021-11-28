using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Import
{
    [XmlType("Purchase")]
    public class ImportPurchasDto
    {
        [Required]
        [XmlElement("Type")]
        public string Type { get; set; }
        [Required]
        [XmlElement("Key")]
        [RegularExpression("^([A-Z0-9]{4})\\-([A-Z0-9]{4})\\-([A-Z0-9]{4})$")]
        public string Key { get; set; }
        [Required]
        [XmlElement("Date")]
        public string Date { get; set; }
        [Required]
        [RegularExpression("^(\\d{4})\\s(\\d{4})\\s(\\d{4})\\s(\\d{4})$")]
        [XmlElement("Card")]
        public string CardNumber{ get; set; }
        [Required]
        [XmlAttribute("title")]
        public string GameTitle { get; set; }
    }
}

//
//     <Purchase title="Dungeon Warfare 2">
//    <Type>Digital</Type>
//    <Key>ZTZ3-0D2S-G4TJ</Key>
//    <Card>1833 5024 0553 6211</Card>
//    <Date>07/12/2016 05:49</Date>
//    </Purchase>