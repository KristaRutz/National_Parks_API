namespace NationalParkDirectoryApi.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
    public string Name { get; set; }
    public string AlphaCode { get; set; }
    public string StateCode { get; set; }
    public string Region { get; set; }
    public string Url { get; set; }
  }
}