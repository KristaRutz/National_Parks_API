using System.ComponentModel.DataAnnotations;

namespace NationalParkDirectoryApi.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
    public string Name { get; set; }

    [StringLength(4)]
    public string AlphaCode { get; set; }

    [StringLength(2)]
    public string StateCode { get; set; }
    public string Region { get; set; }
    public string Url { get; set; }
    public bool IsOpen { get; set; }
  }
}