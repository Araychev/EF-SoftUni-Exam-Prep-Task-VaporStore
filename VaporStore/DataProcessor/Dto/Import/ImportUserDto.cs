using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class ImportUserDto
    {
        [Required]
        [StringLength(20),MinLength(3)]
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"^([A-Z]{1}[a-z]+)\s([A-Z]{1}[a-z]+)$")]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(3,103)]
        public int Age { get; set; }

        public ImportCardsDto[] Cards { get; set; }
    }

    public class ImportCardsDto
    {
        [Required]
        [RegularExpression(@"^(\d{4})\s(\d{4})\s(\d{4})\s(\d{4})$")]
        public string Number { get; set; }
        [Required]
        [MaxLength(3)]
        [RegularExpression(@"^(\d{3})$")]
        [JsonProperty("CVC")]
        public string Cvc { get; set; }
        [Required]
        public string Type { get; set; }

    }
}

//
//  "FullName": "Kathy Carroll",
//  "Username": "kcarroll",
//  "Email": "kcarroll@softuni.bg",
//   "Age": 52,
//  "Cards": [
//  {
//    "Number": "2844 3311 3796 4444",
//    "CVC": "137",
//    "Type": "Debit"
//   },
//  {
//    "Number": "7716 6230 0769 9366",
//    "CVC": "656",
//    "Type": "Credit"
//  },
//  {
//    "Number": "2829 0002 6052 6217",
//    "CVC": "259",
//    "Type": "Credit"
//  }
//   ]
//