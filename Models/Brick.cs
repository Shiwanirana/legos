using System.ComponentModel.DataAnnotations;

namespace Legos.Models
{
  public class Brick
  {
    [Required]
    public string Name{get;set;}
    public string Color{get;set;}
    // public int Width{get;set;}
    // public int Length{get;set;}
    public int id{get;set;}
   }
}